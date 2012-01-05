using Nancy;

namespace Webtop.UI.Modules
{
    public class HelloWebKitWorld : NancyModule
    {
        public HelloWebKitWorld()
        {
            Get["/"] = x => View["Views/HelloPage.html"];
            Get["Views/{page}"] = x => View["Views/" + x.page.ToString()];
        }
    }
}
