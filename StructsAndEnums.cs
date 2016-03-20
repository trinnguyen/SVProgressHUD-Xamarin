using System;
using ObjCRuntime;

namespace SVProgressHUDBinding
{
	[Native]
	public enum SVProgressHUDStyle : long
	{
		Light,
		Dark,
		Custom
	}

	[Native]
	public enum SVProgressHUDMaskType : ulong
	{
		None = 1,
		Clear,
		Black,
		Gradient
	}

	[Native]
	public enum SVProgressHUDAnimationType : ulong
	{
		Flat,
		Native
	}
}
