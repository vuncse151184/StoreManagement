USE [FStore]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'member1', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'member2', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'member3@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'member4@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'member5@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'member6@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (7, N'member7@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (8, N'member8@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (9, N'member9@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (10, N'member10@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (11, N'member11@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (12, N'member12@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (13, N'member13@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (14, N'member15@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (15, N'member17@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (16, N'member16@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (17, N'member17@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (18, N'member18@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (19, N'member19@gmail.com', N'company1', N'HCM', N'VietNam', N'123')
GO




INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (101, 1, CAST(N'2012-06-18T22:34:09.000' AS DateTime), CAST(N'2012-06-18T22:34:09.000' AS DateTime), CAST(N'2012-06-18T22:34:09.000' AS DateTime), 1.0000)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (102, 2, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (103, 3, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (104, 4, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (105, 5, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (106, 6, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (107, 7, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (108, 8, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (109, 9, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (110, 10, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (111, 11, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (112, 12, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (113, 13, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (114, 14, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (115, 15, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (116, 16, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (117, 17, CAST(N'2012-06-18T22:34:09.000' AS DateTime), NULL, NULL, NULL)
GO




INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10001, 1, N'T-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10002, 2, N'A-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10003, 3, N'V-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10004, 4, N'B-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10005, 5, N'C-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10006, 6, N'D-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10007, 7, N'R-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10008, 8, N'W-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10009, 9, N'Q-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10010, 10, N'S-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10011, 11, N'T-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10012, 12, N'T-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10013, 13, N'T-shirt', N'2', 0.0001, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (10014, 14, N'T-shirt', N'2', 0.0001, 1)
GO





INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (101, 10001, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (102, 10002, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (103, 10003, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (104, 10004, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (105, 10005, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (106, 10006, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (107, 10007, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (108, 10008, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (109, 10009, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (110, 10010, 2.0000, 1, 1.1)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (111, 10011, 2.0000, 1, 1.1)
GO
