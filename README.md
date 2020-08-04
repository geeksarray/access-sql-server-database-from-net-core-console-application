# access sql server database from net core console application
How to connect .NET Core Console application to SQL server database and read table data.

This blogpost explains how to connect .NET Core Console application to SQL server database and read table data. 
You will not be using the Entity framework for this. You will inject the dependency of IConfiguration to read appsettings.

1. **DAL -> DepartmentDAL.cs** - has required code to connect to SQL server and get Department data.
2. **Models -> Department.cs** - is a model for Department entity.

![folder structure for dot net core console application](https://geeksarray.com/images/blog/folder-structure-for-adventure-data-console-app.PNG)

For more details [click here](https://geeksarray.com/blog/access-sql-server-database-from-net-core-console-application)
