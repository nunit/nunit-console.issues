namespace WebApi;

public class WebHostStartup
{
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints => { endpoints.MapGet("/", () => "Hello World!"); });
    }
}
