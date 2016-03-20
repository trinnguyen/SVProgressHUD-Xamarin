using ObjCRuntime;

[assembly: LinkWith ("libSVProgressHUD.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64, SmartLink = true, Frameworks="QuartzCore", ForceLoad = true)]