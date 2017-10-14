using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SVProgressHUDBinding
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SVProgressHUDDidReceiveTouchEventNotification;
        [Field("SVProgressHUDDidReceiveTouchEventNotification", "__Internal")]
        NSString SVProgressHUDDidReceiveTouchEventNotification { get; }

        // extern NSString *const _Nonnull SVProgressHUDDidTouchDownInsideNotification;
        [Field("SVProgressHUDDidTouchDownInsideNotification", "__Internal")]
        NSString SVProgressHUDDidTouchDownInsideNotification { get; }

        // extern NSString *const _Nonnull SVProgressHUDWillDisappearNotification;
        [Field("SVProgressHUDWillDisappearNotification", "__Internal")]
        NSString SVProgressHUDWillDisappearNotification { get; }

        // extern NSString *const _Nonnull SVProgressHUDDidDisappearNotification;
        [Field("SVProgressHUDDidDisappearNotification", "__Internal")]
        NSString SVProgressHUDDidDisappearNotification { get; }

        // extern NSString *const _Nonnull SVProgressHUDWillAppearNotification;
        [Field("SVProgressHUDWillAppearNotification", "__Internal")]
        NSString SVProgressHUDWillAppearNotification { get; }

        // extern NSString *const _Nonnull SVProgressHUDDidAppearNotification;
        [Field("SVProgressHUDDidAppearNotification", "__Internal")]
        NSString SVProgressHUDDidAppearNotification { get; }

        // extern NSString *const _Nonnull SVProgressHUDStatusUserInfoKey;
        [Field("SVProgressHUDStatusUserInfoKey", "__Internal")]
        NSString SVProgressHUDStatusUserInfoKey { get; }
    }

    // typedef void (^SVProgressHUDShowCompletion)();
    delegate void SVProgressHUDShowCompletion();

    // typedef void (^SVProgressHUDDismissCompletion)();
    delegate void SVProgressHUDDismissCompletion();

    // @interface SVProgressHUD : UIView
    [BaseType(typeof(UIView))]
    interface SVProgressHUD
    {
        // @property (assign, nonatomic) SVProgressHUDStyle defaultStyle __attribute__((annotate("ui_appearance_selector")));
        [Export("defaultStyle", ArgumentSemantic.Assign)]
        SVProgressHUDStyle DefaultStyle { get; set; }

        // @property (assign, nonatomic) SVProgressHUDMaskType defaultMaskType __attribute__((annotate("ui_appearance_selector")));
        [Export("defaultMaskType", ArgumentSemantic.Assign)]
        SVProgressHUDMaskType DefaultMaskType { get; set; }

        // @property (assign, nonatomic) SVProgressHUDAnimationType defaultAnimationType __attribute__((annotate("ui_appearance_selector")));
        [Export("defaultAnimationType", ArgumentSemantic.Assign)]
        SVProgressHUDAnimationType DefaultAnimationType { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable containerView;
        [NullAllowed, Export("containerView", ArgumentSemantic.Strong)]
        UIView ContainerView { get; set; }

        // @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumSize", ArgumentSemantic.Assign)]
        CGSize MinimumSize { get; set; }

        // @property (assign, nonatomic) CGFloat ringThickness __attribute__((annotate("ui_appearance_selector")));
        [Export("ringThickness")]
        nfloat RingThickness { get; set; }

        // @property (assign, nonatomic) CGFloat ringRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("ringRadius")]
        nfloat RingRadius { get; set; }

        // @property (assign, nonatomic) CGFloat ringNoTextRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("ringNoTextRadius")]
        nfloat RingNoTextRadius { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull font __attribute__((annotate("ui_appearance_selector")));
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor __attribute__((annotate("ui_appearance_selector")));
        //[Export("backgroundColor", ArgumentSemantic.Strong)]
        //UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull foregroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("foregroundColor", ArgumentSemantic.Strong)]
        UIColor ForegroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundLayerColor __attribute__((annotate("ui_appearance_selector")));
        [Export("backgroundLayerColor", ArgumentSemantic.Strong)]
        UIColor BackgroundLayerColor { get; set; }

        // @property (assign, nonatomic) CGSize imageViewSize __attribute__((annotate("ui_appearance_selector")));
        [Export("imageViewSize", ArgumentSemantic.Assign)]
        CGSize ImageViewSize { get; set; }

        // @property (nonatomic, strong) UIImage * _Nonnull infoImage __attribute__((annotate("ui_appearance_selector")));
        [Export("infoImage", ArgumentSemantic.Strong)]
        UIImage InfoImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nonnull successImage __attribute__((annotate("ui_appearance_selector")));
        [Export("successImage", ArgumentSemantic.Strong)]
        UIImage SuccessImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nonnull errorImage __attribute__((annotate("ui_appearance_selector")));
        [Export("errorImage", ArgumentSemantic.Strong)]
        UIImage ErrorImage { get; set; }

        // @property (nonatomic, strong) UIView * _Nonnull viewForExtension __attribute__((annotate("ui_appearance_selector")));
        [Export("viewForExtension", ArgumentSemantic.Strong)]
        UIView ViewForExtension { get; set; }

        // @property (assign, nonatomic) NSTimeInterval graceTimeInterval;
        [Export("graceTimeInterval")]
        double GraceTimeInterval { get; set; }

        // @property (assign, nonatomic) NSTimeInterval minimumDismissTimeInterval;
        [Export("minimumDismissTimeInterval")]
        double MinimumDismissTimeInterval { get; set; }

        // @property (assign, nonatomic) NSTimeInterval maximumDismissTimeInterval;
        [Export("maximumDismissTimeInterval")]
        double MaximumDismissTimeInterval { get; set; }

        // @property (assign, nonatomic) UIOffset offsetFromCenter __attribute__((annotate("ui_appearance_selector")));
        [Export("offsetFromCenter", ArgumentSemantic.Assign)]
        UIOffset OffsetFromCenter { get; set; }

        // @property (assign, nonatomic) NSTimeInterval fadeInAnimationDuration __attribute__((annotate("ui_appearance_selector")));
        [Export("fadeInAnimationDuration")]
        double FadeInAnimationDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval fadeOutAnimationDuration __attribute__((annotate("ui_appearance_selector")));
        [Export("fadeOutAnimationDuration")]
        double FadeOutAnimationDuration { get; set; }

        // @property (assign, nonatomic) UIWindowLevel maxSupportedWindowLevel;
        [Export("maxSupportedWindowLevel")]
        double MaxSupportedWindowLevel { get; set; }

        // @property (assign, nonatomic) BOOL hapticsEnabled;
        [Export("hapticsEnabled")]
        bool HapticsEnabled { get; set; }

        // +(void)setDefaultStyle:(SVProgressHUDStyle)style;
        [Static]
        [Export("setDefaultStyle:")]
        void SetDefaultStyle(SVProgressHUDStyle style);

        // +(void)setDefaultMaskType:(SVProgressHUDMaskType)maskType;
        [Static]
        [Export("setDefaultMaskType:")]
        void SetDefaultMaskType(SVProgressHUDMaskType maskType);

        // +(void)setDefaultAnimationType:(SVProgressHUDAnimationType)type;
        [Static]
        [Export("setDefaultAnimationType:")]
        void SetDefaultAnimationType(SVProgressHUDAnimationType type);

        // +(void)setContainerView:(UIView * _Nullable)containerView;
        [Static]
        [Export("setContainerView:")]
        void SetContainerView([NullAllowed] UIView containerView);

        // +(void)setMinimumSize:(CGSize)minimumSize;
        [Static]
        [Export("setMinimumSize:")]
        void SetMinimumSize(CGSize minimumSize);

        // +(void)setRingThickness:(CGFloat)ringThickness;
        [Static]
        [Export("setRingThickness:")]
        void SetRingThickness(nfloat ringThickness);

        // +(void)setRingRadius:(CGFloat)radius;
        [Static]
        [Export("setRingRadius:")]
        void SetRingRadius(nfloat radius);

        // +(void)setRingNoTextRadius:(CGFloat)radius;
        [Static]
        [Export("setRingNoTextRadius:")]
        void SetRingNoTextRadius(nfloat radius);

        // +(void)setCornerRadius:(CGFloat)cornerRadius;
        [Static]
        [Export("setCornerRadius:")]
        void SetCornerRadius(nfloat cornerRadius);

        // +(void)setBorderColor:(UIColor * _Nonnull)color;
        [Static]
        [Export("setBorderColor:")]
        void SetBorderColor(UIColor color);

        // +(void)setBorderWidth:(CGFloat)width;
        [Static]
        [Export("setBorderWidth:")]
        void SetBorderWidth(nfloat width);

        // +(void)setFont:(UIFont * _Nonnull)font;
        [Static]
        [Export("setFont:")]
        void SetFont(UIFont font);

        // +(void)setForegroundColor:(UIColor * _Nonnull)color;
        [Static]
        [Export("setForegroundColor:")]
        void SetForegroundColor(UIColor color);

        // +(void)setBackgroundColor:(UIColor * _Nonnull)color;
        [Static]
        [Export("setBackgroundColor:")]
        void SetBackgroundColor(UIColor color);

        // +(void)setBackgroundLayerColor:(UIColor * _Nonnull)color;
        [Static]
        [Export("setBackgroundLayerColor:")]
        void SetBackgroundLayerColor(UIColor color);

        // +(void)setImageViewSize:(CGSize)size;
        [Static]
        [Export("setImageViewSize:")]
        void SetImageViewSize(CGSize size);

        // +(void)setInfoImage:(UIImage * _Nonnull)image;
        [Static]
        [Export("setInfoImage:")]
        void SetInfoImage(UIImage image);

        // +(void)setSuccessImage:(UIImage * _Nonnull)image;
        [Static]
        [Export("setSuccessImage:")]
        void SetSuccessImage(UIImage image);

        // +(void)setErrorImage:(UIImage * _Nonnull)image;
        [Static]
        [Export("setErrorImage:")]
        void SetErrorImage(UIImage image);

        // +(void)setViewForExtension:(UIView * _Nonnull)view;
        [Static]
        [Export("setViewForExtension:")]
        void SetViewForExtension(UIView view);

        // +(void)setGraceTimeInterval:(NSTimeInterval)interval;
        [Static]
        [Export("setGraceTimeInterval:")]
        void SetGraceTimeInterval(double interval);

        // +(void)setMinimumDismissTimeInterval:(NSTimeInterval)interval;
        [Static]
        [Export("setMinimumDismissTimeInterval:")]
        void SetMinimumDismissTimeInterval(double interval);

        // +(void)setMaximumDismissTimeInterval:(NSTimeInterval)interval;
        [Static]
        [Export("setMaximumDismissTimeInterval:")]
        void SetMaximumDismissTimeInterval(double interval);

        // +(void)setFadeInAnimationDuration:(NSTimeInterval)duration;
        [Static]
        [Export("setFadeInAnimationDuration:")]
        void SetFadeInAnimationDuration(double duration);

        // +(void)setFadeOutAnimationDuration:(NSTimeInterval)duration;
        [Static]
        [Export("setFadeOutAnimationDuration:")]
        void SetFadeOutAnimationDuration(double duration);

        // +(void)setMaxSupportedWindowLevel:(UIWindowLevel)windowLevel;
        [Static]
        [Export("setMaxSupportedWindowLevel:")]
        void SetMaxSupportedWindowLevel(double windowLevel);

        // +(void)setHapticsEnabled:(BOOL)hapticsEnabled;
        [Static]
        [Export("setHapticsEnabled:")]
        void SetHapticsEnabled(bool hapticsEnabled);

        // +(void)show;
        [Static]
        [Export("show")]
        void Show();

        // +(void)showWithMaskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use show and setDefaultMaskType: instead.")));
        [Static]
        [Export("showWithMaskType:")]
        void ShowWithMaskType(SVProgressHUDMaskType maskType);

        // +(void)showWithStatus:(NSString * _Nullable)status;
        [Static]
        [Export("showWithStatus:")]
        void ShowWithStatus([NullAllowed] string status);

        // +(void)showWithStatus:(NSString * _Nullable)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showWithStatus: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showWithStatus:maskType:")]
        void ShowWithStatus([NullAllowed] string status, SVProgressHUDMaskType maskType);

        // +(void)showProgress:(float)progress;
        [Static]
        [Export("showProgress:")]
        void ShowProgress(float progress);

        // +(void)showProgress:(float)progress maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showProgress: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showProgress:maskType:")]
        void ShowProgress(float progress, SVProgressHUDMaskType maskType);

        // +(void)showProgress:(float)progress status:(NSString * _Nullable)status;
        [Static]
        [Export("showProgress:status:")]
        void ShowProgress(float progress, [NullAllowed] string status);

        // +(void)showProgress:(float)progress status:(NSString * _Nullable)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showProgress:status: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showProgress:status:maskType:")]
        void ShowProgress(float progress, [NullAllowed] string status, SVProgressHUDMaskType maskType);

        // +(void)setStatus:(NSString * _Nullable)status;
        [Static]
        [Export("setStatus:")]
        void SetStatus([NullAllowed] string status);

        // +(void)showInfoWithStatus:(NSString * _Nullable)status;
        [Static]
        [Export("showInfoWithStatus:")]
        void ShowInfoWithStatus([NullAllowed] string status);

        // +(void)showInfoWithStatus:(NSString * _Nullable)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showInfoWithStatus: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showInfoWithStatus:maskType:")]
        void ShowInfoWithStatus([NullAllowed] string status, SVProgressHUDMaskType maskType);

        // +(void)showSuccessWithStatus:(NSString * _Nullable)status;
        [Static]
        [Export("showSuccessWithStatus:")]
        void ShowSuccessWithStatus([NullAllowed] string status);

        // +(void)showSuccessWithStatus:(NSString * _Nullable)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showSuccessWithStatus: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showSuccessWithStatus:maskType:")]
        void ShowSuccessWithStatus([NullAllowed] string status, SVProgressHUDMaskType maskType);

        // +(void)showErrorWithStatus:(NSString * _Nullable)status;
        [Static]
        [Export("showErrorWithStatus:")]
        void ShowErrorWithStatus([NullAllowed] string status);

        // +(void)showErrorWithStatus:(NSString * _Nullable)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showErrorWithStatus: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showErrorWithStatus:maskType:")]
        void ShowErrorWithStatus([NullAllowed] string status, SVProgressHUDMaskType maskType);

        // +(void)showImage:(UIImage * _Nonnull)image status:(NSString * _Nullable)status;
        [Static]
        [Export("showImage:status:")]
        void ShowImage(UIImage image, [NullAllowed] string status);

        // +(void)showImage:(UIImage * _Nonnull)image status:(NSString * _Nullable)status maskType:(SVProgressHUDMaskType)maskType __attribute__((deprecated("Use showImage:status: and setDefaultMaskType: instead.")));
        [Static]
        [Export("showImage:status:maskType:")]
        void ShowImage(UIImage image, [NullAllowed] string status, SVProgressHUDMaskType maskType);

        // +(void)setOffsetFromCenter:(UIOffset)offset;
        [Static]
        [Export("setOffsetFromCenter:")]
        void SetOffsetFromCenter(UIOffset offset);

        // +(void)resetOffsetFromCenter;
        [Static]
        [Export("resetOffsetFromCenter")]
        void ResetOffsetFromCenter();

        // +(void)dismiss;
        [Static]
        [Export("dismiss")]
        void Dismiss();

        // +(void)dismissWithCompletion:(SVProgressHUDDismissCompletion _Nullable)completion;
        [Static]
        [Export("dismissWithCompletion:")]
        void DismissWithCompletion([NullAllowed] SVProgressHUDDismissCompletion completion);

        // +(void)dismissWithDelay:(NSTimeInterval)delay;
        [Static]
        [Export("dismissWithDelay:")]
        void DismissWithDelay(double delay);

        // +(void)dismissWithDelay:(NSTimeInterval)delay completion:(SVProgressHUDDismissCompletion _Nullable)completion;
        [Static]
        [Export("dismissWithDelay:completion:")]
        void DismissWithDelay(double delay, [NullAllowed] SVProgressHUDDismissCompletion completion);

        // +(BOOL)isVisible;
        [Static]
        [Export("isVisible")]
        //[Verify(MethodToProperty)]
        bool IsVisible { get; }

        // +(NSTimeInterval)displayDurationForString:(NSString * _Nullable)string;
        [Static]
        [Export("displayDurationForString:")]
        double DisplayDurationForString([NullAllowed] string @string);
    }
}
