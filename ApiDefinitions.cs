using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
//using SVProgressHUD;
using UIKit;

namespace SVProgressHUDBinding
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const SVProgressHUDDidReceiveTouchEventNotification;
		[Field ("SVProgressHUDDidReceiveTouchEventNotification", "__Internal")]
		NSString SVProgressHUDDidReceiveTouchEventNotification { get; }

		// extern NSString *const SVProgressHUDDidTouchDownInsideNotification;
		[Field ("SVProgressHUDDidTouchDownInsideNotification", "__Internal")]
		NSString SVProgressHUDDidTouchDownInsideNotification { get; }

		// extern NSString *const SVProgressHUDWillDisappearNotification;
		[Field ("SVProgressHUDWillDisappearNotification", "__Internal")]
		NSString SVProgressHUDWillDisappearNotification { get; }

		// extern NSString *const SVProgressHUDDidDisappearNotification;
		[Field ("SVProgressHUDDidDisappearNotification", "__Internal")]
		NSString SVProgressHUDDidDisappearNotification { get; }

		// extern NSString *const SVProgressHUDWillAppearNotification;
		[Field ("SVProgressHUDWillAppearNotification", "__Internal")]
		NSString SVProgressHUDWillAppearNotification { get; }

		// extern NSString *const SVProgressHUDDidAppearNotification;
		[Field ("SVProgressHUDDidAppearNotification", "__Internal")]
		NSString SVProgressHUDDidAppearNotification { get; }

		// extern NSString *const SVProgressHUDStatusUserInfoKey;
		[Field ("SVProgressHUDStatusUserInfoKey", "__Internal")]
		NSString SVProgressHUDStatusUserInfoKey { get; }
	}

	// @interface SVProgressHUD : UIView
	[BaseType (typeof(UIView))]
	interface SVProgressHUD
	{
		// @property (assign, nonatomic) SVProgressHUDStyle defaultStyle __attribute__((annotate("ui_appearance_selector")));
		[Export ("defaultStyle", ArgumentSemantic.Assign)]
		SVProgressHUDStyle DefaultStyle { get; set; }

		// @property (assign, nonatomic) SVProgressHUDMaskType defaultMaskType __attribute__((annotate("ui_appearance_selector")));
		[Export ("defaultMaskType", ArgumentSemantic.Assign)]
		SVProgressHUDMaskType DefaultMaskType { get; set; }

		// @property (assign, nonatomic) SVProgressHUDAnimationType defaultAnimationType __attribute__((annotate("ui_appearance_selector")));
		[Export ("defaultAnimationType", ArgumentSemantic.Assign)]
		SVProgressHUDAnimationType DefaultAnimationType { get; set; }

		// @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
		[Export ("minimumSize", ArgumentSemantic.Assign)]
		CGSize MinimumSize { get; set; }

		// @property (assign, nonatomic) CGFloat ringThickness __attribute__((annotate("ui_appearance_selector")));
		[Export ("ringThickness")]
		nfloat RingThickness { get; set; }

		// @property (assign, nonatomic) CGFloat ringRadius __attribute__((annotate("ui_appearance_selector")));
		[Export ("ringRadius")]
		nfloat RingRadius { get; set; }

		// @property (assign, nonatomic) CGFloat ringNoTextRadius __attribute__((annotate("ui_appearance_selector")));
		[Export ("ringNoTextRadius")]
		nfloat RingNoTextRadius { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic, strong) UIFont * font __attribute__((annotate("ui_appearance_selector")));
		[Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * backgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * foregroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("foregroundColor", ArgumentSemantic.Strong)]
		UIColor ForegroundColor { get; set; }

		// @property (nonatomic, strong) UIImage * infoImage __attribute__((annotate("ui_appearance_selector")));
		[Export ("infoImage", ArgumentSemantic.Strong)]
		UIImage InfoImage { get; set; }

		// @property (nonatomic, strong) UIImage * successImage __attribute__((annotate("ui_appearance_selector")));
		[Export ("successImage", ArgumentSemantic.Strong)]
		UIImage SuccessImage { get; set; }

		// @property (nonatomic, strong) UIImage * errorImage __attribute__((annotate("ui_appearance_selector")));
		[Export ("errorImage", ArgumentSemantic.Strong)]
		UIImage ErrorImage { get; set; }

		// @property (nonatomic, strong) UIView * viewForExtension __attribute__((annotate("ui_appearance_selector")));
		[Export ("viewForExtension", ArgumentSemantic.Strong)]
		UIView ViewForExtension { get; set; }

		// @property (assign, nonatomic) NSTimeInterval minimumDismissTimeInterval;
		[Export ("minimumDismissTimeInterval")]
		double MinimumDismissTimeInterval { get; set; }

		// @property (assign, nonatomic) UIOffset offsetFromCenter __attribute__((annotate("ui_appearance_selector")));
		[Export ("offsetFromCenter", ArgumentSemantic.Assign)]
		UIOffset OffsetFromCenter { get; set; }

		// +(void)setDefaultStyle:(SVProgressHUDStyle)style;
		[Static]
		[Export ("setDefaultStyle:")]
		void SetDefaultStyle (SVProgressHUDStyle style);

		// +(void)setDefaultMaskType:(SVProgressHUDMaskType)maskType;
		[Static]
		[Export ("setDefaultMaskType:")]
		void SetDefaultMaskType (SVProgressHUDMaskType maskType);

		// +(void)setDefaultAnimationType:(SVProgressHUDAnimationType)type;
		[Static]
		[Export ("setDefaultAnimationType:")]
		void SetDefaultAnimationType (SVProgressHUDAnimationType type);

		// +(void)setMinimumSize:(CGSize)minimumSize;
		[Static]
		[Export ("setMinimumSize:")]
		void SetMinimumSize (CGSize minimumSize);

		// +(void)setRingThickness:(CGFloat)ringThickness;
		[Static]
		[Export ("setRingThickness:")]
		void SetRingThickness (nfloat ringThickness);

		// +(void)setRingRadius:(CGFloat)radius;
		[Static]
		[Export ("setRingRadius:")]
		void SetRingRadius (nfloat radius);

		// +(void)setRingNoTextRadius:(CGFloat)radius;
		[Static]
		[Export ("setRingNoTextRadius:")]
		void SetRingNoTextRadius (nfloat radius);

		// +(void)setCornerRadius:(CGFloat)cornerRadius;
		[Static]
		[Export ("setCornerRadius:")]
		void SetCornerRadius (nfloat cornerRadius);

		// +(void)setFont:(UIFont *)font;
		[Static]
		[Export ("setFont:")]
		void SetFont (UIFont font);

		// +(void)setForegroundColor:(UIColor *)color;
		[Static]
		[Export ("setForegroundColor:")]
		void SetForegroundColor (UIColor color);

		// +(void)setBackgroundColor:(UIColor *)color;
		[Static]
		[Export ("setBackgroundColor:")]
		void SetBackgroundColor (UIColor color);

		// +(void)setInfoImage:(UIImage *)image;
		[Static]
		[Export ("setInfoImage:")]
		void SetInfoImage (UIImage image);

		// +(void)setSuccessImage:(UIImage *)image;
		[Static]
		[Export ("setSuccessImage:")]
		void SetSuccessImage (UIImage image);

		// +(void)setErrorImage:(UIImage *)image;
		[Static]
		[Export ("setErrorImage:")]
		void SetErrorImage (UIImage image);

		// +(void)setViewForExtension:(UIView *)view;
		[Static]
		[Export ("setViewForExtension:")]
		void SetViewForExtension (UIView view);

		// +(void)setMinimumDismissTimeInterval:(NSTimeInterval)interval;
		[Static]
		[Export ("setMinimumDismissTimeInterval:")]
		void SetMinimumDismissTimeInterval (double interval);

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)showWithMaskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use show and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showWithMaskType:")]
		void ShowWithMaskType (SVProgressHUDMaskType maskType);

		// +(void)showWithStatus:(NSString *)status;
		[Static]
		[Export ("showWithStatus:")]
		void ShowWithStatus (string status);

		// +(void)showWithStatus:(NSString *)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showWithStatus: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showWithStatus:maskType:")]
		void ShowWithStatus (string status, SVProgressHUDMaskType maskType);

		// +(void)showProgress:(float)progress;
		[Static]
		[Export ("showProgress:")]
		void ShowProgress (float progress);

		// +(void)showProgress:(float)progress maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showProgress: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showProgress:maskType:")]
		void ShowProgress (float progress, SVProgressHUDMaskType maskType);

		// +(void)showProgress:(float)progress status:(NSString *)status;
		[Static]
		[Export ("showProgress:status:")]
		void ShowProgress (float progress, string status);

		// +(void)showProgress:(float)progress status:(NSString *)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showProgress: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showProgress:status:maskType:")]
		void ShowProgress (float progress, string status, SVProgressHUDMaskType maskType);

		// +(void)setStatus:(NSString *)status;
		[Static]
		[Export ("setStatus:")]
		void SetStatus (string status);

		// +(void)showInfoWithStatus:(NSString *)status;
		[Static]
		[Export ("showInfoWithStatus:")]
		void ShowInfoWithStatus (string status);

		// +(void)showInfoWithStatus:(NSString *)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showInfoWithStatus: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showInfoWithStatus:maskType:")]
		void ShowInfoWithStatus (string status, SVProgressHUDMaskType maskType);

		// +(void)showSuccessWithStatus:(NSString *)status;
		[Static]
		[Export ("showSuccessWithStatus:")]
		void ShowSuccessWithStatus (string status);

		// +(void)showSuccessWithStatus:(NSString *)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showSuccessWithStatus: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showSuccessWithStatus:maskType:")]
		void ShowSuccessWithStatus (string status, SVProgressHUDMaskType maskType);

		// +(void)showErrorWithStatus:(NSString *)status;
		[Static]
		[Export ("showErrorWithStatus:")]
		void ShowErrorWithStatus (string status);

		// +(void)showErrorWithStatus:(NSString *)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showErrorWithStatus: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showErrorWithStatus:maskType:")]
		void ShowErrorWithStatus (string status, SVProgressHUDMaskType maskType);

		// +(void)showImage:(UIImage *)image status:(NSString *)status;
		[Static]
		[Export ("showImage:status:")]
		void ShowImage (UIImage image, string status);

		// +(void)showImage:(UIImage *)image status:(NSString *)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showImage: and setDefaultMaskType: instead.")));
		[Static]
		[Export ("showImage:status:maskType:")]
		void ShowImage (UIImage image, string status, SVProgressHUDMaskType maskType);

		// +(void)setOffsetFromCenter:(UIOffset)offset;
		[Static]
		[Export ("setOffsetFromCenter:")]
		void SetOffsetFromCenter (UIOffset offset);

		// +(void)resetOffsetFromCenter;
		[Static]
		[Export ("resetOffsetFromCenter")]
		void ResetOffsetFromCenter ();

		// +(void)popActivity;
		[Static]
		[Export ("popActivity")]
		void PopActivity ();

		// +(void)dismiss;
		[Static]
		[Export ("dismiss")]
		void Dismiss ();

		// +(void)dismissWithDelay:(NSTimeInterval)delay;
		[Static]
		[Export ("dismissWithDelay:")]
		void DismissWithDelay (double delay);

		// +(void)dismissWithDuration:(NSTimeInterval)duration delay:(NSTimeInterval)delay;
		[Static]
		[Export ("dismissWithDuration:delay:")]
		void DismissWithDuration (double duration, double delay);

		// +(BOOL)isVisible;
		[Static]
		[Export ("isVisible")]
		//[Verify (MethodToProperty)]
		bool IsVisible { get; }

		// +(NSTimeInterval)displayDurationForString:(NSString *)string;
		[Static]
		[Export ("displayDurationForString:")]
		double DisplayDurationForString (string @string);
	}
}