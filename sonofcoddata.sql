USE [SonOfCod]
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'85d5aaf8-0a59-461a-a896-a2a0fa9f1358', 0, N'738466f6-f707-4e8f-835e-a578f5eeaaba', NULL, 0, 1, NULL, NULL, N'ADMIN@SONOFCOD.COM', N'AQAAAAEAACcQAAAAEBMa8WO5vSQS9cDm5YxRp6cjRWC5EdWu9WbcYhjri/xh+pWQQYC6sqqNMazrqFM+cw==', NULL, 0, N'61a81143-c289-4088-8e71-31d409df0643', 0, N'admin@sonofcod.com')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170217181648_Initial', N'1.0.0-rtm-21431')
