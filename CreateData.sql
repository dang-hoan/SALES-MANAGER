USE [SalesManagerDB]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 
GO
INSERT [dbo].[Account] ([Id], [Username], [Password], [StatusId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'DangHoan', N'danghoan', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Account] ([Id], [Username], [Password], [StatusId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'VanA', N'1234', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Account] ([Id], [Username], [Password], [StatusId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (3, N'ThiB', N'123', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'Giày thể thao', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'Dụng cụ nhà bếp', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (3, N'Dụng cụ cầu lông', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'VanG', CAST(N'2023-04-10T08:14:09.000' AS DateTime), N'VanB', CAST(N'2023-04-11T08:14:09.000' AS DateTime), N'02 Tôn Đản, Hoà Phát, Cẩm Lệ, ĐN', NULL, CAST(31.00 AS Decimal(8, 2)), 8, 38, CAST(2457.33 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-10T10:43:59.963' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:49:46.720' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (3, N'VanA', CAST(N'2023-04-03T00:00:00.000' AS DateTime), N'VanB', CAST(N'2023-04-05T00:00:00.000' AS DateTime), N'54 Nguyễn Lương Bằng', NULL, CAST(5.00 AS Decimal(8, 2)), 9, 5, CAST(52896.19 AS Decimal(8, 2)), N'thanh toán trực tuyến', N'', CAST(N'2023-04-10T10:43:59.963' AS DateTime), N'danghoan', CAST(N'2023-04-13T10:34:35.987' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (6, N'DangHan', CAST(N'2023-04-10T10:42:37.000' AS DateTime), N'CaoH', CAST(N'2023-04-11T10:42:37.000' AS DateTime), N'02 Lý Thái Tổ', NULL, CAST(12.00 AS Decimal(8, 2)), 8, 0, CAST(38113.60 AS Decimal(8, 2)), N'thanh toán trực tiếp', N'', CAST(N'2023-04-10T10:43:59.963' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:50:04.923' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (9, N'ThanhTuan', CAST(N'2023-04-09T10:09:35.000' AS DateTime), N'VanB', CAST(N'2023-04-11T10:09:35.000' AS DateTime), N'101 Long Biên, Hà Nội', NULL, CAST(0.00 AS Decimal(8, 2)), 9, 0, CAST(813.12 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-11T10:10:30.120' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:26:20.773' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (13, N'VanManh', CAST(N'2023-04-05T10:32:31.000' AS DateTime), N'CaoH', CAST(N'2023-04-11T10:32:31.000' AS DateTime), N'123 Sài Gòn', NULL, CAST(5.00 AS Decimal(8, 2)), 9, 12, CAST(90932.03 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-11T10:33:46.643' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:26:39.880' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (14, N'VanD', CAST(N'2020-10-11T13:47:18.000' AS DateTime), N'VanB', CAST(N'2020-10-13T13:47:18.000' AS DateTime), N'121 Bạch Đằng', NULL, CAST(3.00 AS Decimal(8, 2)), 8, 32, CAST(4919.25 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-11T13:48:17.497' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:50:19.267' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (15, N'ThiB', CAST(N'2021-04-11T13:48:23.000' AS DateTime), N'VanB', CAST(N'2021-04-11T13:48:23.000' AS DateTime), N'572 Cầu Giấy, Hà Nội', NULL, CAST(0.00 AS Decimal(8, 2)), 8, 32, CAST(84270.27 AS Decimal(8, 2)), N'trực tiếp', N'', CAST(N'2023-04-11T13:49:19.830' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:50:26.363' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (16, N'ThuyNga', CAST(N'2022-04-11T13:49:23.000' AS DateTime), N'CaoH', CAST(N'2022-04-11T13:49:23.000' AS DateTime), N'384 Tôn Đức Thắng', NULL, CAST(3.00 AS Decimal(8, 2)), 8, 2, CAST(69265.36 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-11T13:50:20.287' AS DateTime), N'danghoan', CAST(N'2023-04-11T14:49:58.480' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (17, N'Thanh Dat', CAST(N'2023-04-13T10:43:59.920' AS DateTime), N'CaoH', CAST(N'2023-04-15T10:43:59.000' AS DateTime), N'Quảng Trị', NULL, CAST(0.00 AS Decimal(8, 2)), 9, 0, CAST(1411.20 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-13T10:44:38.817' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (18, N'Thanh Van', CAST(N'2023-04-13T10:46:55.000' AS DateTime), N'CaoH', CAST(N'2023-04-13T10:46:55.000' AS DateTime), N'Quảng Trị', NULL, CAST(0.00 AS Decimal(8, 2)), 9, 0, CAST(0.00 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-13T10:47:18.020' AS DateTime), N'danghoan', CAST(N'2023-04-13T11:37:58.303' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (19, N'User', CAST(N'2023-04-13T11:23:48.000' AS DateTime), N'CaoH', CAST(N'2023-04-15T11:23:48.000' AS DateTime), N'Quảng Bình', NULL, CAST(0.00 AS Decimal(8, 2)), 8, 0, CAST(0.00 AS Decimal(8, 2)), N'online', N'', CAST(N'2023-04-13T11:24:11.963' AS DateTime), N'danghoan', CAST(N'2023-04-13T11:24:23.270' AS DateTime), N'danghoan', CAST(N'2023-04-13T11:27:28.080' AS DateTime), N'danghoan', 1)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (20, N'wf', CAST(N'2023-04-13T11:26:52.000' AS DateTime), N'VanB', CAST(N'2023-04-13T11:26:52.000' AS DateTime), N'f', NULL, CAST(0.00 AS Decimal(8, 2)), 8, 0, CAST(0.00 AS Decimal(8, 2)), N'fwf', N'', CAST(N'2023-04-13T11:27:05.173' AS DateTime), N'danghoan', CAST(N'2023-04-13T11:27:14.403' AS DateTime), N'danghoan', CAST(N'2023-04-13T11:27:23.910' AS DateTime), N'danghoan', 1)
GO
INSERT [dbo].[Order] ([Id], [CustomerName], [OrderDate], [ShipperId], [ShipDate], [ShipAddress], [ShipPostalCode], [ShipPrice], [StatusId], [PrivateDiscount], [TotalPrice], [PaymentMethod], [Note], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (21, N'owhgw', CAST(N'2023-04-13T11:27:32.927' AS DateTime), N'CaoH', CAST(N'2023-04-13T11:27:32.927' AS DateTime), N'gwg', NULL, CAST(0.00 AS Decimal(8, 2)), 8, 0, CAST(7969.50 AS Decimal(8, 2)), N'wg', N'', CAST(N'2023-04-13T11:27:50.553' AS DateTime), N'danghoan', NULL, NULL, CAST(N'2023-04-13T11:27:59.207' AS DateTime), N'danghoan', 1)
GO
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (1, 1, 4, CAST(704.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (1, 6, 8, CAST(2168.32 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (3, 6, 195, CAST(52852.80 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (3, 7, 24, CAST(2822.40 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (6, 6, 140, CAST(37945.60 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (6, 8, 52, CAST(156.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (9, 9, 535, CAST(129202.50 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (13, 6, 334, CAST(90527.36 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (13, 9, 53, CAST(12799.50 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (14, 1, 3, CAST(528.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (14, 7, 57, CAST(6703.20 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (15, 20, 56, CAST(123926.88 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (16, 1, 43, CAST(7568.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (16, 7, 34, CAST(3998.40 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (16, 9, 34, CAST(8211.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (16, 20, 23, CAST(50898.54 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (17, 7, 12, CAST(1411.20 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (21, 6, 0, CAST(0.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [NumberOfProducts], [TotalPriceOfProducts]) VALUES (21, 9, 33, CAST(7969.50 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[Permission] ON 
GO
INSERT [dbo].[Permission] ([Id], [PermissionName], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'Add, Delete, Update', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Permission] ([Id], [PermissionName], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'View', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Permission] OFF
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'CaoH', N'Cao Thị', N'H', 0, NULL, N'057347589345', NULL, NULL, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'DangHan', N'Nguyễn Thế', N'Đăng Hân', 1, CAST(N'2002-02-03T22:23:04.000' AS DateTime), N'0889207876', N'danghannguyen09@gmail.com', N'Quảng Nam', 4, CAST(N'2023-04-04T22:24:16.933' AS DateTime), N'danghoan', CAST(N'2023-04-13T10:28:55.253' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'danghan123', N'sf', N'f', 1, CAST(N'2023-02-03T08:31:21.000' AS DateTime), N'058498594', N'abc@gmail.com', N'Quảng Ngãi', 4, CAST(N'2023-04-05T08:32:03.480' AS DateTime), N'danghoan', CAST(N'2023-04-05T08:54:24.727' AS DateTime), N'danghoan', CAST(N'2023-04-05T08:55:34.710' AS DateTime), N'danghoan', 1)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'DangHoan', N'Nguyễn Thế', N'Đăng Hoan', 1, CAST(N'2002-02-03T00:00:00.000' AS DateTime), N'0852556258', N'nguyenthedanghoan@gmail.com', N'Quảng Nam', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'New', N'Customer', N'The New', 1, CAST(N'2023-04-05T09:35:10.760' AS DateTime), N'090487', N'newCustomer@gmail.com', N'faffa', 4, CAST(N'2023-04-05T09:35:41.207' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'User2', N'Trần Văn', N'User2', 1, CAST(N'2023-04-13T10:28:58.240' AS DateTime), N'04782750752087777', N'user2@gmail.com', N'DN', 4, CAST(N'2023-04-13T10:30:08.753' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'VanA', N'Nguyễn Văn', N'A', 1, CAST(N'2002-11-15T00:00:00.000' AS DateTime), N'0428752807', N'vân@gmail.com', N'Quảng Nam', 4, NULL, NULL, CAST(N'2023-04-04T22:22:56.103' AS DateTime), N'danghoan', CAST(N'2023-04-05T08:55:03.413' AS DateTime), N'danghoan', 1)
GO
INSERT [dbo].[Person] ([Username], [LastName], [FirstName], [Gender], [BirthDate], [Phone], [Email], [Address], [RoleId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (N'VanB', N'Trần Văn', N'B', 0, CAST(N'2001-08-09T00:00:00.000' AS DateTime), N'05747583', N'b@gmail.com', N'Quảng Trị', 3, NULL, NULL, NULL, NULL, NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'Giày wika', 1, 1, CAST(200.00 AS Decimal(30, 2)), N'$', 3, 12, 0, 0, NULL, NULL, CAST(N'2023-04-05T11:50:23.273' AS DateTime), N'danghoan', CAST(N'2023-04-07T16:08:28.960' AS DateTime), N'danghoan', 1)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (6, N'Tủ lạnh LG ngăn đá', 2, 2, CAST(484.00 AS Decimal(30, 2)), N'$', 3, 44, 0, 0, NULL, NULL, CAST(N'2023-04-13T10:30:26.287' AS DateTime), N'danghoan', NULL, N'', 0)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (7, N'Vợt yonex', 1, 3, CAST(120.00 AS Decimal(30, 2)), N'$', 3, 2, 0, 0, CAST(N'2023-04-05T11:39:07.377' AS DateTime), N'danghoan', CAST(N'2023-04-05T14:47:20.243' AS DateTime), N'danghoan', NULL, N'', 0)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (8, N'Cầu lông', 4, 3, CAST(3.00 AS Decimal(30, 2)), N'$', 3, 0, 0, 0, CAST(N'2023-04-05T11:50:05.103' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (9, N'Giày asias', 1, 1, CAST(345.00 AS Decimal(30, 2)), N'$', 4, 30, 0, 0, CAST(N'2023-04-05T11:59:30.520' AS DateTime), N'danghoan', CAST(N'2023-04-05T14:49:45.360' AS DateTime), N'danghoan', NULL, NULL, 0)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (19, N'Chảo chống dính', 2, 2, CAST(234.00 AS Decimal(30, 2)), N'$', 3, 24, 0, 0, CAST(N'2023-04-05T14:50:51.557' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (20, N'Tivi Samsung', 2, 2, CAST(3353.00 AS Decimal(30, 2)), N'$', 3, 34, 0, 0, CAST(N'2023-04-05T14:52:37.627' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Product] ([Id], [ProductName], [SupplierId], [CategoryId], [ProductPrice], [UnitPrice], [ProductStatusId], [DiscountPercent], [Rating], [ImageId], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (21, N'Bình đun siêu tốc', 1, 2, CAST(3656.00 AS Decimal(30, 2)), N'$', 3, 34.8, 0, 0, CAST(N'2023-04-13T10:32:02.697' AS DateTime), N'danghoan', NULL, NULL, NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([Id], [RoleName], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'Admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Role] ([Id], [RoleName], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'Employee', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Role] ([Id], [RoleName], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (3, N'Shipper', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Role] ([Id], [RoleName], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (4, N'Customer', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[RolePermission] ([RoleId], [PermissionId]) VALUES (1, 1)
GO
SET IDENTITY_INSERT [dbo].[SalesDetail] ON 
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (1, 1, 1, 1200, 50, CAST(528.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (2, 1, 6, 343, 148, CAST(0.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (3, 2, 8, 3294, 52, CAST(156.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (4, 2, 9, 4322, 67, CAST(7969.50 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (6, 2, 7, 5345, 91, CAST(6703.20 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (7, 1, 19, 25436, 0, CAST(0.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (8, 1, 20, 2542, 79, CAST(123926.88 AS Decimal(8, 2)))
GO
INSERT [dbo].[SalesDetail] ([Id], [WareHouseId], [ProductId], [Total], [SellNumber], [SalesTotal]) VALUES (9, 1, 21, 43, 0, CAST(0.00 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[SalesDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'NORMAL', N'Account', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'BLOCK', N'Account', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (3, N'AVAILABLE', N'Product', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (4, N'UNAVAILABLE', N'Product', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (5, N'DELETE', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (6, N'SUCCESS', N'Null', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (7, N'FAIL', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (8, N'DELEVERED', N'Order', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (9, N'NOT DELEVERY', N'Order', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([Id], [StatusName], [TypeStatus], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (10, N'CANCELED', N'Order', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 
GO
INSERT [dbo].[Supplier] ([Id], [CompanyName], [Address], [Phone], [Email], [Webpage], [Description], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'Công ty TNHH TM&SX Thể thao Hoàng Phong', N'Tầng 1, ô 23 Lô 1, Đền Lừ 2, P. Hoàng Văn Thụ, Q. Hoàng Mai, Hà Nội', N'0986.200.022', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Supplier] ([Id], [CompanyName], [Address], [Phone], [Email], [Webpage], [Description], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'LG Official Store', N'TP HCM', N'0580357387', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Supplier] ([Id], [CompanyName], [Address], [Phone], [Email], [Webpage], [Description], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (4, N'Công ty sản xuất dụng cụ thể thao', N'Đà Nẵng', N'068969376', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[WareHouse] ON 
GO
INSERT [dbo].[WareHouse] ([Id], [WareHouseName], [Address], [TotalProduct], [NumberOfImport], [NumbeOfExport], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (1, N'Kho thiết bị 1', N'Bạch Đằng', 2840, 341, 356, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[WareHouse] ([Id], [WareHouseName], [Address], [TotalProduct], [NumberOfImport], [NumbeOfExport], [CreateDate], [CreateBy], [UpdateDate], [UpdateBy], [DeleteDate], [DeleteBy], [IsDelete]) VALUES (2, N'Kho dụng cụ thể thao', N'Trường Chinh', 3221, 234, 238, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[WareHouse] OFF
GO
