﻿using System;
using System.Drawing;

using Foundation;
using UIKit;
using System.Text;

namespace Web
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            //web.LoadRequest(new NSUrlRequest(new NSUrl("http://comocriaraplicativos.com.br")));

            StringBuilder STR = new StringBuilder();
            STR.Append("<html>");
            STR.Append("<body style='background-color:#ffcc00;'>");
            STR.Append("<img src='teste.png' />");
            STR.Append("</body>");
            STR.Append("</html>");

            web.LoadHtmlString(STR.ToString(),
                new NSUrl(NSBundle.MainBundle.BundlePath + "/HTML/"));


        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}