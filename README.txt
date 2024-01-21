dotnet add package SoapCore --version 1.1.0.39

net core 6


dotnet new web

dotnet add package SoapCore


app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});
### Add a reference to the project in your main program file (Program.cs)

