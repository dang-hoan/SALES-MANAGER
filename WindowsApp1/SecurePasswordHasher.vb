Imports System.Security.Cryptography

Module SecurePasswordHasher
    Private Const SaltSize As Integer = 16
    Private Const HashSize As Integer = 20

    Function HashFunc(ByVal password As String, ByVal iterations As Integer) As String
        'Create salt
        Dim salt(SaltSize) As Byte
        Dim rng = New RNGCryptoServiceProvider()
        rng.GetBytes(salt)

        'Creat hash
        Dim pbkdf2 = New Rfc2898DeriveBytes(password, salt, iterations)
        Dim hash = pbkdf2.GetBytes(HashSize)

        'Combine salt and hash
        Dim hashBytes(SaltSize + HashSize) As Byte
        Array.Copy(salt, 0, hashBytes, 0, SaltSize)
        Array.Copy(hash, 0, hashBytes, SaltSize, HashSize)

        'Convert to base64
        Dim base64Hash = Convert.ToBase64String(hashBytes)

        'Format hash with extra information
        Return String.Format("$MYHASH$V1${0}${1}", iterations, base64Hash)
    End Function

    Function Hash(ByVal password As String) As String
        Return HashFunc(password, 10000)
    End Function

    Function IsHashSupported(ByVal hashString As String) As Boolean
        Return hashString.Contains("$MYHASH$V1$")
    End Function

    Function Verify(ByVal password As String, ByVal hashedPassword As String) As Boolean
        If Not IsHashSupported(hashedPassword) Then
            Throw New NotSupportedException("The hashtype is not supported")
        End If

        Dim splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split("$"c)
        Dim iterations = Integer.Parse(splittedHashString(0))
        Dim base64Hash = splittedHashString(1)

        'Get hash bytes
        Dim hashBytes = Convert.FromBase64String(base64Hash)

        'Get salt
        Dim salt(SaltSize) As Byte
        Array.Copy(hashBytes, 0, salt, 0, SaltSize)

        'Create hash with given salt
        Dim pbkdf2 = New Rfc2898DeriveBytes(password, salt, iterations)
        Dim hash As Byte() = pbkdf2.GetBytes(HashSize)

        For i = 0 To HashSize - 1
            If hashBytes(i + SaltSize) <> hash(i) Then
                Return False
            End If
        Next

        Return True
    End Function
    'Use
    'Hash
    'Dim hash = SecurePasswordHasher.Hash("mypassword");

    ' Verify
    'Dim result = SecurePasswordHasher.Verify("mypassword", hash);
End Module