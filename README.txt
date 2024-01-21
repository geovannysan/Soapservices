dotnet add package SoapCore --version 1.1.0.39

net core 6


dotnet new web

dotnet add package SoapCore

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.3
dotnet add package Newtonsoft.Json
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet ef dbcontext scaffold "Server=localhost,1433; Database=Prubatienda; User=sa; Password =mssql1Ipw;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.4

dotnet publish /p:Configuration=Release /p:PublishProfile=FolderProfile


app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});
### Add a reference to the project in your main program file (Program.cs)

