using Microsoft.AspNetCore.Hosting;
using SWII6_TP1;

// Pedro Henrique Botelho Lima

new TestBook();

IWebHost host = new WebHostBuilder()
    .UseKestrel()
    .UseStartup<Startup>()
    .Build();

host.Run();