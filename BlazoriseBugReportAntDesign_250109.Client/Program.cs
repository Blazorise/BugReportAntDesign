using Blazorise.AntDesign;
using Blazorise.Icons.FontAwesome;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault( args );

AddBlazorise( builder.Services );

await builder.Build().RunAsync();

void AddBlazorise( IServiceCollection services )
{
    services
        .AddBlazorise();
    services
        .AddAntDesignProviders()
        .AddFontAwesomeIcons();
}