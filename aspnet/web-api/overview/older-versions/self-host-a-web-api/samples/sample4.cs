var config = new HttpSelfHostConfiguration("http://localhost:8080");

config.Routes.MapHttpRoute(
    "API Default", "api/{controller}/{id}", 
    new { id = RouteParameter.Optional });

/* 不要使用using 程序会崩溃
using (HttpSelfHostServer server = new HttpSelfHostServer(config))
{
    server.OpenAsync().Wait();
    Console.WriteLine("Press Enter to quit.");
    Console.ReadLine();
}
*/
 HttpSelfHostServer server = new HttpSelfHostServer(config);
 server.OpenAsync().Wait();
 Console.WriteLine("Press Enter to quit.");
 Console.ReadLine();
