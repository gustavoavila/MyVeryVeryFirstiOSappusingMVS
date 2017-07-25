using UIKit;

namespace HelloFucknWorld
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            //small change to test github
            //Another change
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}