# SVProgressHUD for Xamarin.iOS

[![NuGet version](https://badge.fury.io/nu/SVProgressHUD.svg)](https://badge.fury.io/nu/SVProgressHUD)

> `SVProgressHUD` is a clean and easy-to-use HUD meant to display the progress of an ongoing task on iOS and tvOS.

![SVProgressHUD](http://f.cl.ly/items/2G1F1Z0M0k0h2U3V1p39/SVProgressHUD.gif)

Try `SVProgressHUD` on [Appetize.io](https://appetize.io/app/p8r2cvy8kq74x7q7tjqf5gyatr).

## Xamarin.iOS Binding
**Net 7.0 for iOS is supported**
* This binding is for getting it worked on Xamarin.iOS with fully access to all methods.
* Original Objective-C library: https://github.com/SVProgressHUD/SVProgressHUD

## Nuget

* `Install-Package SVProgressHUD`
* <https://www.nuget.org/packages/SVProgressHUD>

## Build

* `make`
* Output: `build/SVProgressHUD.dll`

## Publish new version to Nuget

* Edit file `Makefile` -> `NATIVE_RELEASE` to the latest version of native ObjC library
* Update file `SVProgressHUD.nuspec` -> `version` to new version (Nuget version), usually the same as native version
* `make` : Load the ObjC source code and build the dll of binding library
* `make nuget` : Run nuget commandline to push new version
* `make clean-all` : Clean all build files

## Sample Code

```csharp
using System;
using SVProgressHUDBinding;
using UIKit;

namespace DemoHUD
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		partial void BtnToggle_TouchUpInside(UIButton sender)
		{
			if (!SVProgressHUD.IsVisible)
			{
				//Show loading indicator
				SVProgressHUD.Show();
			}	else
			{
				//Hide loading indicator
				SVProgressHUD.Dismiss();
			}
		}
	}
}
```

* Docs: <https://github.com/SVProgressHUD/SVProgressHUD>
