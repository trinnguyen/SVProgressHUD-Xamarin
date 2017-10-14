using ObjCRuntime;

[assembly: LinkWith ("libSVProgressHUD.a", SmartLink = true, Frameworks="QuartzCore", ForceLoad = true)]