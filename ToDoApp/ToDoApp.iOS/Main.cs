// Code Idea adapted from Darle Gheorghe:
//(Source: https://github.com/gheorghedarle/Xamarin-ToDoApp retrieved in Feburary 10, 2022.)

using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ToDoApp.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
