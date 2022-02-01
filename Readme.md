### Run docker image
- docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=my-Password123" -p 14001:1433 --name sql1 -h -d mcr.microsoft.com/mssql/server:2019-latest

### Connection string
- "Server=host.docker.internal,14001;Database=main_db;User=sa;Password=my-Password123;"

### Install packages
- dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.1
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.1

### Migrate
- dotnet tool install --global dotnet-ef
- dotnet ef migrations add initialDb
- dotnet ef database update

### Run
https://localhost:SOMEPORT/api/movie/1