using Nancy;

namespace Webtop.UI.Modules
{
    public class HomePage : NancyModule
    {
        public HomePage()
        {
            Get["/"] = x => Response.AsRedirect("http://localhost:1234/Views/HelloPage.html");
        }
    }
}
