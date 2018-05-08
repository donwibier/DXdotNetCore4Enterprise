using System.Collections.Generic;

namespace DXdotNETCore4Enterprise.Models{
    
    public static class StaticHomeData {
        public static HomeModel Data = new HomeModel()
        {
            ContentBlocks = new HomeColumn[] {
                new HomeColumn("Application uses", "col-md-3", new HomeText[] {
                    new HomeText("Sample pages using ASP.NET Core MVC"),
                    new HomeText("Theming using <a href=\"https://go.microsoft.com/fwlink/?LinkID=398939\">Bootstrap</a>")
                }),
                new HomeColumn("How to", "col-md-3", new HomeText[] {
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=398600\">Add a Controller and View</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=699315\">Manage User Secrets using Secret Manager.</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=699316\">Use logging to log a message.</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=699317\">Add packages using NuGet.</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=699319\">Target development, staging or production environment.</a>")
                }),
                new HomeColumn("Overview", "col-md-3", new HomeText[] {
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=518008\">Conceptual overview of what is ASP.NET Core</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=699320\">Fundamentals of ASP.NET Core such as Startup and middleware.</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=398602\">Working with Data</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkId=398603\">Security</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=699321\">Client side development</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=699322\">Develop on different platforms</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=699323\">Read more on the documentation site</a>")
                }),
                new HomeColumn("Run &amp; Deploy", "col-md-3", new HomeText[] {
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=517851\">Run your app</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=517853\">Run tools such as EF migrations and more</a>"),
                    new HomeText("<a href=\"https://go.microsoft.com/fwlink/?LinkID=398609\">Publish to Microsoft Azure Web Apps</a>")
                })                
            }
        };            
    }

    public class HomeModel{
        public IEnumerable<HomeColumn> ContentBlocks{get;set;}        
    }

    public class HomeColumn{
        public HomeColumn(string title, string cssClass, IEnumerable<HomeText> items){
            CssClass = cssClass;
            Title = title;
            Items = items;
        }
        public string CssClass {get; set;}
        public string Title {get; set;}
        public IEnumerable<HomeText> Items{ get; set;}
    }

    public class HomeText {
        public HomeText(string text){
            Text = text;
        }
        public string Text {get; set;}
    }
}