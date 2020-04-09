using System;
using UIKit;

namespace SampleFeatureInstructions
{
    public partial class ViewController : UIViewController
    {
        private UIBarButtonItem target;


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Features";

            target = new UIBarButtonItem(UIBarButtonSystemItem.Add, (sender, args) =>
            {
                Console.WriteLine("bar button clicked");

                // Instantiate a new MaterialShowcase
                var showcase = new MaterialShowcase();
                showcase.primaryText = "Hello";
                showcase.secondaryText = "I'm a showcase";

                showcase.backgroundPromptColorAlpha = 0.96f;

                showcase.targetTintColor = UIColor.Blue;
                showcase.targetHolderRadius = 44;
                showcase.targetHolderColor = UIColor.White;

                showcase.primaryTextColor = UIColor.White;
                showcase.secondaryTextColor = UIColor.White;
                showcase.primaryTextSize = 20;
                showcase.secondaryTextSize = 15;
                showcase.primaryTextFont = UIFont.BoldSystemFontOfSize(20);
                showcase.secondaryTextFont = UIFont.SystemFontOfSize(15);

                showcase.aniComeInDuration = 0.5f;
                showcase.aniGoOutDuration = 0.5f;
                showcase.aniRippleScale = 1.5f;
                showcase.aniRippleColor = UIColor.White;
                showcase.aniRippleAlpha = 0.2f;

                showcase.backgroundPromptColor = UIColor.Blue;

                showcase.SetTargetView(target);
                showcase.containerView = UIApplication.SharedApplication.KeyWindow;

                showcase.Show();
            });

            NavigationItem.SetRightBarButtonItem(target, true);
        }
    }
}