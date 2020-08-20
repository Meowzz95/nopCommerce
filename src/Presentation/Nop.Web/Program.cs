using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Nop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options =>
                {
                    // 500M
                    options.Limits.MaxRequestBodySize = 524288000;
                    options.AddServerHeader = false;
                })
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
