using Nancy;

namespace Webtop.UI.Modules
{
    public class ViewPage : NancyModule
    {
        public ViewPage()
        {
            Get["Views/{page}"] = x => View["Views/" + x.page.ToString()];
        }
    }
}