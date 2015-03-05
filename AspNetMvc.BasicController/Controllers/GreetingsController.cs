using System.Web.Mvc;

namespace AspNetMvc.BasicController
{
    public class GreetingsController : Controller
    {
        // You can run this action by going to http://localhost:60563/Greetings/Hello.
        // (Don't forget to start the project first by clicking on Debug > Start Without Debugging.)
        public string Hello()
        {
            // This is the HTML-code that gets send to the browser. If you right-click on the page in
            // your browser and select View Page Source (or whatever the option is called in your
            // browser of choice) you can see that the source of the page is exactly this string.
            return "<html><body><p>Hello, world!</p></body></html>";
        }

        // Here's another example. It works exactly the same. You can run this action by going to
        // http://localhost:60563/Greetings/Goodbye.
        public string Goodbye()
        {
            return "<html><body><p>Goodbye, <em>cruel</em> world!</p></body></html>";
        }
    }
}