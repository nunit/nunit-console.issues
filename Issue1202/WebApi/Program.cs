namespace WebApi;

public static class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args)
            .Build()
            .Run();
    }

    /// <remarks>This method is extracted to allow testing using WebApplicationFactory.</remarks>
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
                webBuilder.UseStartup<WebHostStartup>()
                    .UseKestrel());
    }
}
