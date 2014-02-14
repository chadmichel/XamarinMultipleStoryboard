// This file has been autogenerated from a class added in the UI designer.

using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Test3
{
	public partial class YellowViewController : UIViewController
	{
		YellowViewController yellowViewController;
		OtherViewController otherViewController;

		public YellowViewController(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		public void Initialize()
		{
			var myStoryboard = AppDelegate.Storyboard;
			//yellowViewController = myStoryboard.InstantiateViewController("YellowViewController") as YellowViewController;
			otherViewController = AppDelegate.OtherStoryboard.InstantiateViewController("OtherViewController") as OtherViewController;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.SwitchButton.TouchUpInside += (o, e) => {
				//this.NavigationController.PushViewController(yellowViewController, true);
				this.NavigationController.PushViewController(otherViewController, true);
			};
		}
	}
}
