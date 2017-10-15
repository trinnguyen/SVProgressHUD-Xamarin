# SVProgressHUD for Xamarin.iOS

[![NuGet version](https://badge.fury.io/nu/SVProgressHUD.svg)](https://badge.fury.io/nu/SVProgressHUD)

> [SVProgressHUD](https://github.com/SVProgressHUD/SVProgressHUD) is a clean and easy-to-use HUD meant to display the progress of an ongoing task on iOS and tvOS. 

This binding is for getting it worked on Xamarin.iOS with fully access to all methods.

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
