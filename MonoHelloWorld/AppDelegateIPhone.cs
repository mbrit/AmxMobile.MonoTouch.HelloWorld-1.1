		
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoHelloWorld
{

	// The name AppDelegateIPhone is referenced in the MainWindowIPhone.xib file.
	public partial class AppDelegateIPhone : UIApplicationDelegate
	{
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// If you have defined a view, add it here:
			// window.AddSubview (navigationController.View);
			
			window.MakeKeyAndVisible ();
			
			buttonHello.TouchUpInside += HandleButtonHelloTouchUpInside;
			
			return true;
		}

		void HandleButtonHelloTouchUpInside (object sender, EventArgs e)
		{
			UIAlertView view = new UIAlertView();
			view.Title = "Say Hello!";
			view.Message = "Hello, World!";
			view.AddButton("OK");
			view.Show();
		}
	}
}

