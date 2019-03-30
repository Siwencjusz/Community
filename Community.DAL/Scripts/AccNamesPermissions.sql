SELECT        CAST(ROW_NUMBER() OVER (ORDER BY dbo.Users.Id) AS int) AS ID, dbo.Users.AccName, dbo.Permissions.PermissionName
FROM            dbo.Users INNER JOIN
                         dbo.PermissionUsers ON dbo.Users.Id = dbo.PermissionUsers.User_Id INNER JOIN
                         dbo.Permissions ON dbo.PermissionUsers.Permission_Id = dbo.Permissions.Id