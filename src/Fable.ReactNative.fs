namespace Fable.ReactNative

open System
open Fable
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.ReactNative.Types

type RN = ReactNative.Types.Globals

type Ref<'t> = ('t -> unit)

module Props =
  
    type ShadowOffset =
      { width: float
        height: float }

    [<StringEnum; RequireQualifiedAccess>]
    type ToolbarActionShowStatus =
    | IfRoom
    | Always
    | Never

    [<StringEnum; RequireQualifiedAccess>]
    type Alignment =
    | Auto
    | [<CompiledName("flex-start")>] FlexStart
    | Center
    | [<CompiledName("flex-end")>] FlexEnd
    | Stretch
    | Baseline

    [<StringEnum; RequireQualifiedAccess>]
    type ContentAlignment =
    | [<CompiledName("flex-start")>] FlexStart
    | Center
    | [<CompiledName("flex-end")>] FlexEnd
    | Stretch
    | [<CompiledName("space-between")>] SpaceBetween
    | [<CompiledName("space-around")>] SpaceAround

    [<StringEnum; RequireQualifiedAccess>]
    type Display =
    | None
    | Flex

    [<StringEnum; RequireQualifiedAccess>]
    type ItemAlignment =
    | [<CompiledName("flex-start")>] FlexStart
    | Center
    | [<CompiledName("flex-end")>] FlexEnd
    | Stretch
    | Baseline

    [<StringEnum; RequireQualifiedAccess>]
    type TextAlignment =
    | Auto
    | Default
    | Left
    | Center
    | Right
    | Justify

    [<StringEnum; RequireQualifiedAccess>]
    type TextAlignVertical =
    | Auto
    | Top
    | Bottom
    | Center

    [<StringEnum; RequireQualifiedAccess>]
    type JustifyContent =
    | [<CompiledName("flex-start")>] FlexStart
    | Center
    | [<CompiledName("flex-end")>] FlexEnd
    | [<CompiledName("space-between")>] SpaceBetween
    | [<CompiledName("space-around")>] SpaceAround
    | [<CompiledName("space-evenly")>] SpaceEvenly

    [<StringEnum; RequireQualifiedAccess>]
    type FlexDirection =
    | Row
    | [<CompiledName("row-reverse")>] RowReverse
    | Column
    | [<CompiledName("column-reverse")>] ColumnReverse

    [<StringEnum; RequireQualifiedAccess>]
    type FlexWrap =
    | Wrap
    | [<CompiledName("nowrap")>] NoWrap

    [<StringEnum; RequireQualifiedAccess>]
    type KeyboardType =
    | Default
    | [<CompiledName("email-address")>] EmailAddress
    | Numeric
    | [<CompiledName("phone-pad")>] PhonePad
    /// only iOS
    | [<CompiledName("ascii-capable")>] AsciiCapable
    | [<CompiledName("numbers-and-punctuation")>] NumbersAndPunctuation
    | [<CompiledName("url")>] Url
    | [<CompiledName("number-pad")>] NumberPad
    | [<CompiledName("name-phone-pad")>] NamePhonePad
    | [<CompiledName("decimal-pad")>] DecimalPad
    | Twitter
    | [<CompiledName("web-search")>] WebSearch

    [<StringEnum; RequireQualifiedAccess>]
    type Overflow =
    | Visible
    | Hidden
    | Scroll

    [<StringEnum; RequireQualifiedAccess>]
    type Position =
    | Absolute
    | Relative

    [<StringEnum; RequireQualifiedAccess>]
    type ResizeMode =
    | Contain
    | Cover
    | Stretch
    | Center
    | Repeat

    [<StringEnum; RequireQualifiedAccess>]
    type ReturnKeyType =
    | Done
    | Go
    | Next
    | Search
    | Send
    | None
    | Previous
    | Default
    | [<CompiledName("emergency-call")>] EmergencyCall
    | Google
    | Join
    | Route
    | Yahoo

    [<StringEnum; RequireQualifiedAccess>]
    type AutoCapitalizeType =
    | None
    | Sentences
    | Words
    | Characters

    [<StringEnum; RequireQualifiedAccess>]
    type KeyboardDismissMode  =
    | None
    | [<CompiledName("on-drag")>] OnDrag

    [<StringEnum; RequireQualifiedAccess>]
    type DrawerLockMode =
    | Unlocked
    | [<CompiledName("locked-closed")>] LockedClosed
    | [<CompiledName("locked-open")>] LockedOpen

    [<StringEnum; RequireQualifiedAccess>]
    type TextDecorationStyle =
        | Solid | Double | Dotted | Dashed

    [<StringEnum; RequireQualifiedAccess>]
    type FontStyle =
        | Normal | Italic

    [<StringEnum; RequireQualifiedAccess>]
    type WritingDirection =
        | Auto | Ltr | Rtl

    [<StringEnum; RequireQualifiedAccess>]
    type ScrollState =
        Idle | Dragging | Settling

    [<StringEnum; RequireQualifiedAccess>]
    type FontWeight =
        | Normal
        | Bold
        | [<CompiledName("100")>] F100
        | [<CompiledName("200")>] F200
        | [<CompiledName("300")>] F300
        | [<CompiledName("400")>] F400
        | [<CompiledName("500")>] F500
        | [<CompiledName("600")>] F600
        | [<CompiledName("700")>] F700
        | [<CompiledName("800")>] F800
        | [<CompiledName("900")>] F900

    [<StringEnum; RequireQualifiedAccess>]
    type TextDecorationLine =
        | None
        | Underline
        | [<CompiledName("line-through")>] LineThrough
        | [<CompiledName("underline line-through")>] UnderlineLineThrough

    [<StringEnum; RequireQualifiedAccess>]
    type LineBreakMode =
        | Head | Middle | Tail | Clip

    [<StringEnum; RequireQualifiedAccess>]
    type AutoCapitalize =
        | None | Sentences | Words | Characters

    [<StringEnum; RequireQualifiedAccess>]
    type BackfaceVisibility =
        | Visible | Hidden

    [<StringEnum; RequireQualifiedAccess>]
    type BorderStyle =
        | Solid | Dotted | Dashed

    [<StringEnum; RequireQualifiedAccess>]
    type ImageOverflow =
        | Visible | Hidden

    [<StringEnum; RequireQualifiedAccess>]
    type ImageURISourceCache =
        | Default
        | Reload
        | [<CompiledName("force-cache")>] ForceCache
        | [<CompiledName("only-if-cached")>] OnlyIfCached

    [<StringEnum; RequireQualifiedAccess>]
    type Behavior =
        | Height | Position | Padding

    [<StringEnum; RequireQualifiedAccess>]
    type NavigationType =
        | Other | Click

    [<StringEnum; RequireQualifiedAccess>]
    type Size =
        | Small | Large

    [<StringEnum; RequireQualifiedAccess>]
    type Mode =
        | Date | Time | Datetime

    [<StringEnum; RequireQualifiedAccess>]
    type DatePickerIOSMode =
        | Dialog | Dropdown

    [<StringEnum; RequireQualifiedAccess>]
    type StyleAttr =
        | Horizontal | Normal | Small | Large | Inverse | SmallInverse | LargeInverse

    [<StringEnum; RequireQualifiedAccess>]
    type ProgressViewStyle =
        | Default | Bar

    [<StringEnum; RequireQualifiedAccess>]
    type AnimationType =
        | None | Slide | Fade

    [<StringEnum; RequireQualifiedAccess>]
    type SystemIcon =
        | Bookmarks
        | Contacts
        | Downloads
        | Favorites
        | Featured
        | History
        | More
        | [<CompiledName("most-recent")>] MostRecent
        | [<CompiledName("most-viewed")>] MostViewed
        | Recents
        | Search
        | [<CompiledName("top-rated")>] TopRated

    [<StringEnum; RequireQualifiedAccess>]
    type Dim =
        | Window | Screen

    [<StringEnum; RequireQualifiedAccess>]
    type IndicatorStyle =
        | Default | Black | White

    [<StringEnum; RequireQualifiedAccess>]
    type DecelerationRate =
        | Fast | Normal

    [<StringEnum; RequireQualifiedAccess>]
    type AlertButtonStyle =
        | Default | Cancel | Destructive

    [<StringEnum; RequireQualifiedAccess>]
    type GroupTypes =
        | Album | All | Event | Faces | Library | PhotoStream | SavedPhotos

    [<StringEnum; RequireQualifiedAccess>]
    type AssetType =
        | All | Videos | Photos

    [<StringEnum; RequireQualifiedAccess>]
    type ShowHideTransition =
        | Fade | Slide

    [<StringEnum; RequireQualifiedAccess>]
    type Direction =
        | Horizontal | Vertical

    type [<StringEnum; RequireQualifiedAccess>] ResizeMethod =
        | Auto | Resize | Scale

    type IImageSource =
        interface end

    type ISizeUnit =
        interface end

    type IAngle =
        interface end

    type IPickerItem<'a> =
        inherit ReactElement

    type IStyle =
        interface end

    type ITextStyle =
        inherit IStyle

    type ITextStyleIOS =
        inherit IStyle

    type ITextStyleAndroid =
        inherit IStyle

    type IImageStyle =
        inherit IStyle

    type ITransformsStyle =
        inherit IStyle

    type IViewStyle =
        inherit IStyle

    type IFlexStyle =
        inherit IStyle

    type IGestureResponderHandlers =
        interface end

    type IToolbarAndroidProperties =
        interface end

    type ISegmentedControlIOSProperties =
        interface end

    type IWebViewProperties =
        interface end

    type IWebViewPropertiesAndroid =
        inherit IWebViewProperties

    type IWebViewPropertiesIOS =
        inherit IWebViewProperties

    type IDatePickerIOSProperties =
        interface end

    type IDrawerLayoutAndroidProperties =
        interface end

    type IPickerProperties<'a> =
        interface end

    type IProgressBarAndroidProperties =
        interface end

    type IProgressViewIOSProperties =
        interface end

    type IRefreshControlProperties =
        interface end

    type ISliderProperties =
        interface end

    type ITabBarItemProperties =
        interface end

    type ITabBarIOSProperties =
        interface end

    type IListViewProperties =
        interface end

    type IFlatListProperties<'a> =
        interface end

    type ISectionListProperties<'a> =
        interface end

    type IScrollViewProperties =
        inherit IListViewProperties

    type IAnimatedScrollViewProperties =
        inherit IScrollViewProperties

    type IStatusBarProperties =
        interface end

    type ISwitchProperties =
        interface end

    type IKeyboardAvoidingViewProps =
        interface end

    type IActivityIndicatorProperties =
        interface end

    type IActivityIndicatorIOSProperties =
        interface end

    type IMapViewProperties  =
        interface end

    type IMapViewPropertiesAndroid  =
        inherit IMapViewProperties

    type IViewPropertiesIOS =
        interface end

    type IViewPropertiesAndroid =
        interface end

    type IButtonProperties =
        interface end

    type IImageProperties =
        interface end

    type IAnimatedImageProperties =
        inherit IImageProperties

    type ITouchableHighlightProperties =
        interface end

    type ITouchableOpacityProperties =
        interface end

    type ITouchableNativeFeedbackProperties =
        interface end

    type ITouchableWithoutFeedbackIOSProperties =
        interface end

    type ITouchableWithoutFeedbackAndroidProperties =
        interface end

    type ITouchableWithoutFeedbackProperties =
        inherit ITouchableWithoutFeedbackAndroidProperties
        inherit ITouchableWithoutFeedbackIOSProperties
        inherit ITouchableNativeFeedbackProperties
        inherit ITouchableOpacityProperties
        inherit ITouchableHighlightProperties

    type ITextProperties =
        interface end

    type IAnimatedTextProperties =
        inherit ITextProperties

    type ITextInputProperties =
        interface end

    type IViewProperties =
        inherit IViewPropertiesAndroid
        inherit IViewPropertiesIOS
        inherit IToolbarAndroidProperties
        inherit IGestureResponderHandlers
        inherit IKeyboardAvoidingViewProps
        inherit IWebViewProperties
        inherit ISegmentedControlIOSProperties
        inherit IActivityIndicatorProperties
        inherit IActivityIndicatorIOSProperties
        inherit IDatePickerIOSProperties
        inherit IDrawerLayoutAndroidProperties
        inherit IProgressBarAndroidProperties
        inherit IProgressViewIOSProperties
        inherit IRefreshControlProperties
        inherit ISliderProperties
        inherit ITabBarItemProperties
        inherit ITabBarIOSProperties
        inherit IScrollViewProperties
        inherit IStatusBarProperties
        inherit ISwitchProperties
        inherit IMapViewProperties

    type IAnimatedViewProperties =
        inherit IViewProperties

    type WebViewPropertiesAndroid =
        | JavaScriptEnabled of bool
        | DomStorageEnabled of bool
        interface IWebViewPropertiesAndroid

    type WebViewPropertiesIOS =
        | AllowsInlineMediaPlayback of bool
        | Bounces of bool
        | DecelerationRate of DecelerationRate
        | OnShouldStartLoadWithRequest of (WebViewIOSLoadRequestEvent -> bool)
        | ScrollEnabled of bool
        interface IWebViewPropertiesIOS

    type WebViewBundleSource =
        | Uri of string
        | Method of string
        | Headers of obj
        | Cache of Image
        | Body of string

    type WebViewHtmlSource =
        | Html of string // REQUIRED!
        | BaseUrl of string

    type WebViewProperties =
        | AutomaticallyAdjustContentInsets of bool
        | Bounces of bool
        | ContentInset of Insets
        | Html of string
        | InjectedJavaScript of string
        | OnError of (NavState -> unit)
        | OnLoad of (NavState -> unit)
        | OnLoadEnd of (NavState -> unit)
        | OnLoadStart of (NavState -> unit)
        | OnNavigationStateChange of (NavState -> unit)
        | OnShouldStartLoadWithRequest of (obj -> bool)
        | RenderError of (unit -> ReactElement)
        | RenderLoading of (unit -> ReactElement)
        | ScrollEnabled of bool
        | StartInLoadingState of bool
        | Url of string
        | Source of U3<WebViewUriSource, WebViewHtmlSource, float>
        | MediaPlaybackRequiresUserAction of bool
        | ScalesPageToFit of bool
        | Ref of Ref<WebView>
        interface IWebViewProperties
        static member Style (style: IStyle list) : IWebViewProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type ImageURISourceProperties =
        | Uri of string
        | Bundle of string
        | Method of string
        | Headers of obj
        | Body of string
        | Cache of ImageURISourceCache
        | Width of float
        | Height of float
        | Scale of float

    type ITouchable =
        inherit IScrollViewProperties
        inherit IMapViewProperties
        inherit IViewProperties

    type ITransform =
      interface end

    type PerpectiveTransform =
        { perspective: float }
        interface ITransform

    type RotateTransform =
        { rotate: IAngle }
        interface ITransform

    type RotateXTransform =
        { rotateX: IAngle }
        interface ITransform

    type RotateYTransform =
        { rotateY: IAngle }
        interface ITransform

    type RotateZTransform =
        { rotateZ: IAngle }
        interface ITransform

    type ScaleTransform =
        { scale: float }
        interface ITransform

    type ScaleXTransform =
        { scaleX: float }
        interface ITransform

    type ScaleYTransform =
        { scaleY: float }
        interface ITransform

    type TranslateXTransform =
        { translateX: float }
        interface ITransform

    type TranslateYTransform =
        { translateY: float }
        interface ITransform

    type SkewXTransform =
        { skewX: IAngle }
        interface ITransform

    type SkewYTransform =
        { skewY: IAngle }
        interface ITransform

    type TransformsStyle =
        | Transform of ITransform array
        | TransformMatrix of ResizeArray<float>
        | Rotation of float
        | ScaleX of float
        | ScaleY of float
        | TranslateX of float
        | TranslateY of float
        interface ITransformsStyle

    type FlexStyle =
        | AlignContent of ContentAlignment
        | AlignItems of ItemAlignment
        | AlignSelf of Alignment
        | AspectRatio of float
        | BorderBottomWidth of float
        | BorderEndWidth of float
        | BorderLeftWidth of float
        | BorderRightWidth of float
        | BorderStartWidth of float
        | BorderTopWidth of float
        | BorderWidth of float
        | Bottom of ISizeUnit
        | Display of Display
        | End of ISizeUnit
        | Flex of float
        | FlexBasis of ISizeUnit
        | FlexDirection of FlexDirection
        | FlexGrow of float
        | FlexShrink of float
        | FlexWrap of FlexWrap
        | Height of ISizeUnit
        | JustifyContent of JustifyContent
        | Left of ISizeUnit
        | Margin of ISizeUnit
        | MarginBottom of ISizeUnit
        | MarginEnd of ISizeUnit
        | MarginHorizontal of ISizeUnit
        | MarginLeft of ISizeUnit
        | MarginRight of ISizeUnit
        | MarginStart of ISizeUnit
        | MarginTop of ISizeUnit
        | MarginVertical of ISizeUnit
        | MaxHeight of ISizeUnit
        | MaxWidth of ISizeUnit
        | MinHeight of ISizeUnit
        | MinWidth of ISizeUnit
        | Overflow of Overflow
        | Padding of ISizeUnit
        | PaddingBottom of ISizeUnit
        | PaddingEnd of ISizeUnit
        | PaddingHorizontal of ISizeUnit
        | PaddingLeft of ISizeUnit
        | PaddingRight of ISizeUnit
        | PaddingStart of ISizeUnit
        | PaddingTop of ISizeUnit
        | PaddingVertical of ISizeUnit
        | Position of Position
        | Right of ISizeUnit
        | Start of ISizeUnit
        | Top of ISizeUnit
        | Width of ISizeUnit
        | ZIndex of float
        interface IFlexStyle


    type ViewStyle =
        | BackfaceVisibility of BackfaceVisibility
        | BackgroundColor of string
        | BorderBottomColor of string
        | BorderBottomEndRadius of float
        | BorderBottomLeftRadius of float
        | BorderBottomRightRadius of float
        | BorderBottomStartRadius of float
        | BorderBottomWidth of float
        | BorderColor of string
        | BorderEndColor of string
        | BorderLeftColor of string
        | BorderLeftWidth of float
        | BorderRadius of float
        | BorderRightColor of string
        | BorderRightWidth of float
        | BorderStartColor of string
        | BorderStyle of BorderStyle
        | BorderTopColor of string
        | BorderTopEndRadius of float
        | BorderTopLeftRadius of float
        | BorderTopRightRadius of float
        | BorderTopStartRadius of float
        | BorderTopWidth of float
        | BorderWidth of float
        | Opacity of float
        | ShadowColor of string
        | ShadowOffset of ShadowOffset
        | ShadowOpacity of float
        | ShadowRadius of float
        | Elevation of float
        | TestID of string
        interface IViewStyle

    type Insets =
        | Top of float
        | Left of float
        | Bottom of float
        | Right of float

    type Touchable =
        | OnTouchStart of (GestureResponderEvent -> unit)
        | OnTouchMove of (GestureResponderEvent -> unit)
        | OnTouchEnd of (GestureResponderEvent -> unit)
        | OnTouchCancel of (GestureResponderEvent -> unit)
        | OnTouchEndCapture of (GestureResponderEvent -> unit)
        interface ITouchable

    type LayoutAnimationAnim =
        | Duration of float
        | Delay of float
        | SpringDamping of float
        | InitialVelocity of float
        | Type of string
        | Property of string

    type LayoutAnimationConfig =
        | Delay of float //REQUIRED!
        | Create of LayoutAnimationAnim
        | Update of LayoutAnimationAnim
        | Delete of LayoutAnimationAnim

    type TextStyleIOS =
        | LetterSpacing of float
        | TextDecorationColor of string
        | TextDecorationStyle of TextDecorationStyle
        | WritingDirection of WritingDirection
        interface ITextStyleIOS

    type TextStyleAndroid =
        | TextAlignVertical of TextAlignVertical
        interface ITextStyleAndroid

    type TextStyle =
        | Color of string
        | FontFamily of string
        | FontSize of float
        | FontStyle of FontStyle
        | FontWeight of FontWeight
        | LetterSpacing of float
        | LineHeight of float
        | TextAlign of TextAlignment
        | TextDecorationLine of TextDecorationLine
        | TextDecorationStyle of TextDecorationStyle
        | TextDecorationColor of string
        | TextShadowColor of string
        | TextShadowOffset of obj
        | TextShadowRadius of float
        | TestID of string
        interface ITextStyle

    type TextPropertiesIOS =
        | AllowFontScaling of bool // REQUIRED!
        | SuppressHighlighting of bool
        interface ITextProperties
        interface IAnimatedTextProperties

    type TextProperties =
        | AllowFontScaling of bool
        | LineBreakMode of LineBreakMode
        | NumberOfLines of float
        | OnLayout of (LayoutChangeEvent -> unit)
        | OnPress of (unit -> unit)
        | TestID of string
        | Ref of Ref<Text>
        interface ITextProperties
        interface IAnimatedTextProperties
        static member Style (style: IStyle list) : ITextProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    module TextInput =
        type TextInputIOSProperties =
            | ClearButtonMode of string
            | ClearTextOnFocus of bool
            | EnablesReturnKeyAutomatically of bool
            | OnKeyPress of (unit -> unit)
            | SelectionState of obj
            interface ITextInputProperties

        type TextInputAndroidProperties =
            | NumberOfLines of float
            | ReturnKeyLabel of string
            | TextAlign of string
            | TextAlignVertical of string
            | UnderlineColorAndroid of string
            interface ITextInputProperties

        type TextInputProperties =
            | AutoCapitalize of AutoCapitalize
            | AutoCorrect of bool
            | AutoFocus of bool
            | BlurOnSubmit of bool
            | DefaultValue of string
            | Editable of bool
            | KeyboardType of KeyboardType
            | MaxLength of float
            | Multiline of bool
            | OnBlur of (unit -> unit)
            | OnChange of (obj -> unit)
            | OnChangeText of (string -> unit)
            | OnEndEditing of (obj -> unit)
            | OnFocus of (unit -> unit)
            | OnLayout of (obj -> unit)
            | OnSelectionChange of (unit -> unit)
            | OnSubmitEditing of (obj -> unit)
            | Password of bool
            | Placeholder of string
            | PlaceholderTextColor of string
            | ReturnKeyType of ReturnKeyType
            | SecureTextEntry of bool
            | SelectTextOnFocus of bool
            | SelectionColor of string
            | TestID of string
            | Value of string
            | Ref of Ref<TextInput>
            interface ITextInputProperties
            static member Style (style: IStyle list) : ITextInputProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    module Toolbar =
        type ToolbarAndroidProperties =
            | Actions of ToolbarAndroidAction []
            | ContentInsetEnd of float
            | ContentInsetStart of float
            | Logo of IImageSource
            | OnActionSelected of (int -> unit)
            | NavIcon of IImageSource
            | OnIconClicked of (unit -> unit)
            | OverflowIcon of IImageSource
            | Rtl of bool
            | Subtitle of string
            | SubtitleColor of string
            | TestID of string
            | Title of string
            | TitleColor of string
            | Ref of Ref<ToolbarAndroid>
            interface IToolbarAndroidProperties
            static member Style (style: IStyle list) : IToolbarAndroidProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type GestureResponderHandlers =
        | OnStartShouldSetResponder of (GestureResponderEvent -> bool)
        | OnMoveShouldSetResponder of (GestureResponderEvent -> bool)
        | OnResponderGrant of (GestureResponderEvent -> unit)
        | OnResponderReject of (GestureResponderEvent -> unit)
        | OnResponderMove of (GestureResponderEvent -> unit)
        | OnResponderRelease of (GestureResponderEvent -> unit)
        | OnResponderTerminationRequest of (GestureResponderEvent -> bool)
        | OnResponderTerminate of (GestureResponderEvent -> unit)
        | OnStartShouldSetResponderCapture of (GestureResponderEvent -> bool)
        | OnMoveShouldSetResponderCapture of (GestureResponderEvent -> unit)
        interface IGestureResponderHandlers

    type ViewPropertiesIOS =
        | AccessibilityTraits of U2<string, ResizeArray<string>>
        | ShouldRasterizeIOS of bool
        interface IViewPropertiesIOS

    type ViewPropertiesAndroid =
        | AccessibilityComponentType of string
        | AccessibilityLiveRegion of string
        | Collapsable of bool
        | ImportantForAccessibility of string
        | NeedsOffscreenAlphaCompositing of bool
        | RenderToHardwareTextureAndroid of bool
        interface IViewPropertiesAndroid

    type ViewProperties =
        | AccessibilityLabel of string
        | Accessible of bool
        | HitSlop of obj
        | OnAcccessibilityTap of (unit -> unit)
        | OnLayout of (LayoutChangeEvent -> unit)
        | OnMagicTap of (unit -> unit)
        | PointerEvents of PointerEvents
        | RemoveClippedSubviews of bool
        | TestID of string
        | Ref of Ref<View>
        interface IViewProperties
        static member Style (style: IStyle list) : IViewProperties = !!("style", keyValueList CaseRules.LowerFirst style)


    type KeyboardAvoidingViewProps =
        | Behavior of Behavior
        | KeyboardVerticalOffset of float // REQUIRED!
        | Ref of Ref<KeyboardAvoidingView>
        interface IKeyboardAvoidingViewProps

    type SegmentedControlIOSProperties =
        | Enabled of bool
        | Momentary of bool
        | OnChange of (NativeSyntheticEvent<NativeSegmentedControlIOSChangeEvent> -> unit)
        | OnValueChange of (string -> unit)
        | SelectedIndex of int
        | TintColor of string
        | Values of ResizeArray<string>
        | Ref of Ref<SegmentedControlIOS>
        interface ISegmentedControlIOSProperties

    type NavigatorIOSProperties =
        | BarTintColor of string
        | InitialRoute of Route
        | ItemWrapperStyle of ViewStyle list
        | NavigationBarHidden of bool
        | ShadowHidden of bool
        | TintColor of string
        | TitleTextColor of string
        | Translucent of bool
        | Ref of Ref<NavigatorIOS>
        static member Style (style: IStyle list) : NavigatorIOSProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    module ActivityIndicator =
        type ActivityIndicatorProperties =
            | Animating of bool
            | Color of string
            | HidesWhenStopped of bool
            | Size of Size
            | Ref of Ref<ActivityIndicator>
            interface IViewProperties
            static member Style (style: IStyle list) : ActivityIndicatorProperties = !!("style", keyValueList CaseRules.LowerFirst style)


        type ActivityIndicatorIOSProperties =
            | Animating of bool
            | Color of string
            | HidesWhenStopped of bool
            | OnLayout of (obj -> unit)
            | Size of Size
            | Ref of Ref<ActivityIndicatorIOS>
            interface IViewProperties
            static member Style (style: IStyle list) : ActivityIndicatorIOSProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type DatePickerIOSProperties =
        | Date of DateTime
        | MaximumDate of DateTime
        | MinimumDate of DateTime
        | MinuteInterval of float
        | Mode of DatePickerIOSMode
        | OnDateChange of (DateTime -> unit)
        | TimeZoneOffsetInMinutes of float
        | Ref of Ref<DatePickerIOS>
        interface IDatePickerIOSProperties

    type DrawerLayoutAndroidProperties =
        | DrawerBackgroundColor of string
        | DrawerLockMode of DrawerLockMode
        | DrawerPosition of DrawerLayoutAndroidPosition
        | DrawerWidth of float
        | KeyboardDismissMode of KeyboardDismissMode
        | OnDrawerClose of (unit -> unit)
        | OnDrawerOpen of (unit -> unit)
        | OnDrawerSlide of (DrawerSlideEvent -> unit)
        | OnDrawerStateChanged of (ScrollState -> unit)
        | RenderNavigationView of (unit -> obj)
        | StatusBarBackgroundColor of obj
        | Ref of Ref<DrawerLayoutAndroid>
        interface IDrawerLayoutAndroidProperties

    module Picker =
        type PickerIOSItemProperties =
            | Value of U2<string, int>
            | Label of string

        type PickerItemProperties<'a> =
            | Label of string // REQUIRED!
            | Value of 'a
            | Key of string
            | Color of string
            | TestID of string

        type PickerPropertiesIOS<'a> =
            interface IPickerProperties<'a>
            static member Style (style: IStyle list) : IPickerProperties<'a> = !!("style", keyValueList CaseRules.LowerFirst style)

        type PickerPropertiesAndroid<'a> =
            | Enabled of bool
            | Mode of Mode
            | Prompt of string
            interface IPickerProperties<'a>

        type PickerProperties<'a> =
            | OnValueChange of ('a -> int -> unit)
            | SelectedValue of 'a
            | TestId of string
            | Ref of Ref<Picker>
            interface IPickerProperties<'a>
            static member Style (style: IStyle list) : IPickerProperties<'a> = !!("style", keyValueList CaseRules.LowerFirst style)

        type PickerIOSProperties<'a> =
            | ItemStyle of ViewStyle list
            | Ref of Ref<PickerIOS>
            interface IPickerProperties<'a>

    module ProgressBar =
        type ProgressBarAndroidProperties =
            | StyleAttr of StyleAttr
            | Indeterminate of bool
            | Progress of float
            | Color of string
            | TestID of string
            | Ref of Ref<ProgressBarAndroid>
            interface IProgressBarAndroidProperties
            static member Style (style: IStyle list) : IProgressBarAndroidProperties = !!("style", keyValueList CaseRules.LowerFirst style)

        type ProgressViewIOSProperties =
            | ProgressViewStyle of ProgressViewStyle
            | Progress of float
            | ProgressTintColor of string
            | TrackTintColor of string
            | ProgressImage of IImageSource
            | TrackImage of IImageSource
            | Ref of Ref<ProgressViewIOS>
            interface IProgressViewIOSProperties
            static member Style (style: IStyle list) : IProgressBarAndroidProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type RefreshControlPropertiesIOS =
        | TintColor of string
        | Title of string
        | TitleColor of string
        interface IRefreshControlProperties


    type RefreshControlPropertiesAndroid =
        | Colors of ResizeArray<string>
        | Enabled of bool
        | ProgressBackgroundColor of string
        | Size of float
        | ProgressViewOffset of float
        interface IRefreshControlProperties

    type RefreshControlProperties =
        | OnRefresh of (unit -> unit)
        | Refreshing of bool
        | Ref of Ref<RefreshControl>
        interface IRefreshControlProperties

    type SliderIOSProperties =
        | TrackImage of IImageSource
        | MinimumTrackImage of IImageSource
        | MaximumTrackImage of IImageSource
        | ThumbImage of IImageSource
        interface ISliderProperties

    type SliderAndroidProperties =
        | ThumbTintColor of string
        interface ISliderProperties

    type SliderProperties =
        | Disabled of bool
        | MaximumTrackTintColor of string
        | MaximumValue of float
        | MinimumTrackTintColor of string
        | MinimumValue of float
        | OnSlidingComplete of (float -> unit)
        | OnValueChange of (float -> unit)
        | Step of float
        | TestID of string
        | Value of float
        | Ref of Ref<Slider>
        interface ISliderProperties
        static member Style (style: IStyle list) : ISliderProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type SwitchProperties =
        | Disabled of bool
        | OnTintColor of string
        | OnValueChange of (bool -> unit)
        | ThumbTintColor of string
        | TintColor of string
        | Value of bool
        | TestID of string
        | Ref of Ref<Switch>
        interface ISwitchProperties

    type ImageStyle =
        | ResizeMode of string
        | BackfaceVisibility of BackfaceVisibility
        | BorderBottomLeftRadius of float
        | BorderBottomRightRadius of float
        | BackgroundColor of string
        | BorderColor of string
        | BorderWidth of float
        | BorderRadius of float
        | BorderTopLeftRadius of float
        | BorderTopRightRadius of float
        | Overflow of ImageOverflow
        | OverlayColor of string
        | TintColor of string
        | Opacity of float
        interface IImageStyle

    type ImagePropertiesIOS =
        | AccessibilityLabel of string
        | Accessible of bool
        | CapInsets of Insets
        | DefaultSource of IImageSource
        | OnPartialLoad of (unit -> unit)
        | OnProgress of (ImageProgressChangeEvent -> unit)
        interface IImageProperties
        interface IAnimatedImageProperties

    type ImagePropertiesAndroid =
        | ResizeMethod of ResizeMethod
        | FadeDuration of float
        interface IImageProperties
        interface IAnimatedImageProperties

    type ImageProperties =
        | BlurRadius of float
        | LoadingIndicatorSource of IImageSource
        | OnLayout of (LayoutChangeEvent -> unit)
        | OnLoad of (unit -> unit)
        | OnLoadEnd of (unit -> unit)
        | OnLoadStart of (unit -> unit)
        | OnError of (ImageErrorEvent -> unit)
        | ResizeMode of ResizeMode
        | Source of IImageSource
        | TestID of string
        | Ref of Ref<Image>
        interface IImageProperties
        interface IAnimatedImageProperties
        static member Style (style: IStyle list) : IImageProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type MapViewAnnotation =
        | Latitude of float
        | Longitude of float
        | AnimateDrop of bool
        | Title of string
        | Subtitle of string
        | HasLeftCallout of bool
        | HasRightCallout of bool
        | OnLeftCalloutPress of (unit -> unit)
        | OnRightCalloutPress of (unit -> unit)
        | Id of string

    type MapViewRegion =
        | Latitude of float
        | Longitude of float
        | LatitudeDelta of float
        | LongitudeDelta of float

    type MapViewOverlay =
        | Coordinates of ResizeArray<obj>
        | LineWidth of float
        | StrokeColor of obj
        | FillColor of obj
        | Id of string

    type MapViewPropertiesIOS =
        | ShowsPointsOfInterest of bool
        | Annotations of ResizeArray<MapViewAnnotation>
        | FollowUserLocation of bool
        | LegalLabelInsets of Insets
        | MapType of string
        | MaxDelta of float
        | MinDelta of float
        | Overlays of ResizeArray<MapViewOverlay>
        | ShowsCompass of bool

    type MapViewPropertiesAndroid =
        | Active of bool
        interface IMapViewPropertiesAndroid

    type MapViewProperties =
        | OnAnnotationPress of (unit -> unit)
        | OnRegionChange of (MapViewRegion -> unit)
        | OnRegionChangeComplete of (MapViewRegion -> unit)
        | PitchEnabled of bool
        | Region of MapViewRegion
        | RotateEnabled of bool
        | ScrollEnabled of bool
        | ShowsUserLocation of bool
        | ZoomEnabled of bool
        | Ref of Ref<MapView>
        interface IMapViewProperties
        static member Style (style: IStyle list) : IMapViewProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type ModalProperties =
        | Animated of bool
        | AnimationType of AnimationType
        | Transparent of bool
        | Visible of bool
        | OnRequestClose of (unit -> unit)
        | OnShow of (NativeSyntheticEvent<obj> -> unit)
        | Ref of Ref<Modal>

    type ButtonProperties =
        | Title of string
        | OnPress of (unit -> unit)
        | Disabled of bool
        | Color of string
        | TestID of string
        | HasTVPreferredFocus of bool
        | Ref of Ref<Button>
        interface IButtonProperties

    type TouchableWithoutFeedbackAndroidProperties =
        | AccessibilityComponentType of string
        interface ITouchableWithoutFeedbackAndroidProperties

    type TouchableWithoutFeedbackIOSProperties =
        | AccessibilityTraits of U2<string, ResizeArray<string>>
        interface ITouchableWithoutFeedbackIOSProperties

    type TouchableWithoutFeedbackProperties =
        | Accessible of bool
        | DelayLongPress of float
        | DelayPressIn of float
        | DelayPressOut of float
        | Disabled of bool
        | HitSlop of obj
        | OnLayout of (LayoutChangeEvent -> unit)
        | OnLongPress of (unit -> unit)
        | OnPress of (unit -> unit)
        | OnPressIn of (unit -> unit)
        | OnPressOut of (unit -> unit)
        | PressRetentionOffset of obj
        | Ref of Ref<TouchableWithoutFeedback>
        interface ITouchableWithoutFeedbackProperties
        static member Style (style: IStyle list) : ITouchableWithoutFeedbackProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type TouchableHighlightProperties =
        | TestID of string
        | ActiveOpacity of float
        | OnHideUnderlay of (unit -> unit)
        | OnShowUnderlay of (unit -> unit)
        | UnderlayColor of string
        | Ref of Ref<TouchableHighlight>
        interface ITouchableHighlightProperties
        static member Style (style: IStyle list) : TouchableHighlightProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type TouchableOpacityProperties =
        | ActiveOpacity of float
        | Ref of Ref<TouchableOpacity>
        interface ITouchableOpacityProperties

    type TouchableNativeFeedbackProperties =
        | Background of obj
        | Ref of Ref<TouchableNativeFeedback>
        interface ITouchableNativeFeedbackProperties

    type NavigationBarRouteMapper =
        | Title of (Route -> Navigator -> float -> NavState -> ReactElement)
        | LeftButton of (Route -> Navigator -> float -> NavState -> ReactElement)
        | RightButton of (Route -> Navigator -> float -> NavState -> ReactElement)

    type NavigationBarProperties =
        | Navigator of Navigator
        | RouteMapper of NavigationBarRouteMapper
        | NavState of NavState
        static member Style (style: IStyle list) : NavigationBarProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type INavigatorProperties =
        interface end

    type NavigatorProperties =
        | ConfigureScene of (Route -> ResizeArray<Route> -> SceneConfig)
        | InitialRoute of Route
        | InitialRouteStack of ResizeArray<Route>
        | NavigationBar of ReactElement // ReactElement option
        | Navigator of Navigator
        | OnDidFocus of (unit -> unit)
        | OnWillFocus of (unit -> unit)
        | RenderScene of (Route -> Navigator -> ReactElement)
        | SceneStyle of ViewStyle list
        | DebugOverlay of bool
        interface INavigatorProperties

    module ToolBar =
        type TabBarItemProperties =
            | Badge of U2<string, float>
            | Icon of U2<obj, string>
            | OnPress of (unit -> unit)
            | Selected of bool
            | SelectedIcon of U2<obj, string>
            | SystemIcon of SystemIcon
            | Title of string
            | Ref of Ref<TabBarItemStatic>
            interface IViewProperties
            static member Style (style: IStyle list) : TabBarItemProperties = !!("style", keyValueList CaseRules.LowerFirst style)

        type TabBarIOSProperties =
            | BarTintColor of string
            | TintColor of string
            | Translucent of bool
            | UnselectedTintColor of string
            | Ref of Ref<TabBarIOS>
            interface IViewProperties
            static member Style (style: IStyle list) : TabBarIOSProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type IScrollViewPropertiesIOS =
        inherit IScrollViewProperties

    type ScrollViewPropertiesIOS =
        | AlwaysBounceHorizontal of bool
        | AlwaysBounceVertical of bool
        | AutomaticallyAdjustContentInsets of bool
        | Bounces of bool
        | BouncesZoom of bool
        | CanCancelContentTouches of bool
        | CenterContent of bool
        | ContentInset of Insets
        | ContentOffset of PointProperties
        | DecelerationRate of DecelerationRate
        | DirectionalLockEnabled of bool
        | IndicatorStyle of IndicatorStyle
        | MaximumZoomScale of float
        | MinimumZoomScale of float
        | OnRefreshStart of (unit -> unit)
        | OnScrollAnimationEnd of (unit -> unit)
        | ScrollEnabled of bool
        | ScrollEventThrottle of float
        | ScrollIndicatorInsets of Insets
        | ScrollsToTop of bool
        | SnapToAlignment of string
        | SnapToInterval of float
        | StickyHeaderIndices of ResizeArray<float>
        | ZoomScale of float
        interface IScrollViewPropertiesIOS

    type IScrollViewPropertiesAndroid =
        inherit IScrollViewProperties

    type ScrollViewPropertiesAndroid =
        | EndFillColor of string
        | ScrollPerfTag of string
        interface IScrollViewPropertiesAndroid

    [<RequireQualifiedAccess; StringEnum>]
    type KeyboardShouldPersistTapsProperties =
    | Never
    | Always
    | Handled

    type ScrollViewProperties<'a> =
        | ContentContainerStyle of IStyle list
        | Horizontal of bool
        | KeyboardDismissMode of string
        | KeyboardShouldPersistTaps of KeyboardShouldPersistTapsProperties
        | OnScroll of (obj -> unit)
        | OnScrollBeginDrag of (obj -> unit)
        | OnScrollEndDrag of (obj -> unit)
        | OnMomentumScrollBegin of (obj -> unit)
        | OnMomentumScrollEnd of (obj -> unit)
        | PagingEnabled of bool
        | RemoveClippedSubviews of bool
        | ShowsHorizontalScrollIndicator of bool
        | ShowsVerticalScrollIndicator of bool
        | ScrollEnabled of bool
        | RefreshControl of ReactElement
        | Ref of Ref<ScrollView>
        interface IScrollViewProperties
        interface IAnimatedScrollViewProperties
        interface IFlatListProperties<'a>
        interface ISectionListProperties<'a>
        static member Style (style: IStyle list) : IScrollViewProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type ListViewProperties<'a> =
        | DataSource of ListViewDataSource<'a>
        | EnableEmptySections of bool
        | InitialListSize of float
        | OnChangeVisibleRows of (ResizeArray<obj> -> ResizeArray<obj> -> unit)
        | OnEndReached of (unit -> unit)
        | OnEndReachedThreshold of float
        | PageSize of float
        | RemoveClippedSubviews of bool
        | RenderFooter of (unit -> ReactElement)
        | RenderHeader of (unit -> ReactElement)
        | RenderRow of ('a -> U2<string, float> -> U2<string, float> -> bool -> ReactElement)
        | RenderScrollComponent of (ScrollViewProperties -> ReactElement)
        | RenderSectionHeader of (obj -> U2<string, float> -> ReactElement)
        | RenderSeparator of (U2<string, float> -> U2<string, float> -> bool -> ReactElement)
        | ScrollRenderAheadDistance of float
        | Ref of Ref<ListView<'a>>
        interface IListViewProperties

    type FlatListRenderItemSeparator = { highlight : (unit -> unit); unhighlight : (unit -> unit) }
    type FlatListRenderItemInfo<'a> = { item : 'a; index : float; separators : FlatListRenderItemSeparator }

    type GetItemLayoutResult = { length : float; offset : float; index : float }

    type ViewToken<'a> = { item : 'a; key : string; index : float; isViewable : bool; section : obj }
    type OnViewableItemsChangedInfo<'a> = { viewableItems : ViewToken<'a> []; changed : ViewToken<'a> [] }

    type ViewabilityConfig = { minimumViewTime : float; viewAreaCoveragePercentThreshold : float; itemVisiblePercentThreshold : float; waitForInteraction : bool }

    type DistanceFromEnd = { distanceFromEnd: float }

    type SectionListRenderItemInfo<'a> =
        { item : 'a
          index : float
          separators : FlatListRenderItemSeparator
          section : SectionListData<'a> }

    type SectionListRenderInfo<'a> = { section : SectionListData<'a> }

    type SectionListDataProps<'a> =
        | Key of string
        | RenderItem of (SectionListRenderItemInfo<'a> -> ReactElement)
        | ItemSeparatorComponent of (unit -> ReactElement)
        | KeyExtractor of ('a -> float -> string)

    type SectionListProperties<'a> =
        | ItemSeparatorComponent of (unit -> ReactElement)
        | ListEmptyComponent of (unit -> ReactElement)
        | ListFooterComponent of (unit -> ReactElement)
        | ListHeaderComponent of (unit -> ReactElement)
        | SectionSeparatorComponent of (unit -> ReactElement)
        | ExtraData of obj
        | GetItemLayout of (ResizeArray<SectionListData<'a>> -> float -> GetItemLayoutResult)
        | InitialNumToRender of int
        | Inverted of bool
        | KeyExtractor of ('a -> int -> string)
        | LegacyImplementation of bool
        | OnEndReached of (DistanceFromEnd -> unit)
        | OnEndReachedThreshold of float
        | OnRefresh of (unit -> unit)
        | OnViewableItemsChanged of (OnViewableItemsChangedInfo<'a> -> unit)
        | Refreshing of bool
        | RemoveClippedSubviews of bool
        | RenderItem of (SectionListRenderItemInfo<'a> -> ReactElement)
        | StickySectionHeadersEnabled of bool
        | RenderSectionHeader of (SectionListRenderInfo<'a> -> ReactElement)
        | RenderSectionFooter of (SectionListRenderInfo<'a> -> ReactElement)
        | RenderScrollComponent of (ScrollViewProperties -> ReactElement)
        | Ref of Ref<SectionList<'a>>
        interface ISectionListProperties<'a>

    type FlatListProperties<'a> =
        | ItemSeparatorComponent of (unit -> ReactElement)
        | ListEmptyComponent of (unit -> ReactElement)
        | ListFooterComponent of (unit -> ReactElement)
        | ListHeaderComponent of (unit -> ReactElement)
        | ColumnWrapperStyle of IStyle list
        | ExtraData of obj
        | GetItemLayout of (ResizeArray<'a> -> GetItemLayoutResult)
        | Horizontal of bool
        | InitialNumToRender of int
        | InitialScrollIndex of float
        | KeyExtractor of ('a -> int -> string)
        | LegacyImplementation of bool
        | NumColumns of int
        | OnEndReached of (DistanceFromEnd -> unit)
        | OnEndReachedThreshold of float
        | OnRefresh of (unit -> unit)
        | OnViewableItemsChanged of (OnViewableItemsChangedInfo<'a> -> unit)
        | Refreshing of bool
        | RemoveClippedSubviews of bool
        | RenderItem of (FlatListRenderItemInfo<'a> -> ReactElement)
        | ViewabilityConfig of ViewabilityConfig
        | Ref of Ref<FlatList<'a>>
        interface IFlatListProperties<'a>

    type SwipeableListViewProps<'a> =
        | DataSource of SwipeableListViewDataSource<'a> // REQUIRED!
        | MaxSwipeDistance of float
        | RenderRow of ('a -> U2<string, float> -> U2<string, float> -> bool -> ReactElement) // REQUIRED!
        | RenderQuickActions of ('a -> string -> string -> ReactElement) // REQUIRED!

    type ActionSheetIOSOptions =
        | Title of string
        | Options of ResizeArray<string>
        | CancelButtonIndex of float
        | DestructiveButtonIndex of float
        | Message of string

    type ShareActionSheetIOSOptions =
        | Message of string
        | Url of string


    type DatePickerAndroidOpenOption =
        | Date of U2<DateTime, float>
        | MinDate of U2<DateTime, float>
        | MaxDate of U2<DateTime, float>

    type PanResponderCallbacks =
        | OnMoveShouldSetPanResponder of (GestureResponderEvent -> PanResponderGestureState -> bool)
        | OnStartShouldSetPanResponder of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderGrant of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderMove of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderRelease of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderTerminate of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnMoveShouldSetPanResponderCapture of (GestureResponderEvent -> PanResponderGestureState -> bool)
        | OnStartShouldSetPanResponderCapture of (GestureResponderEvent -> PanResponderGestureState -> bool)
        | OnPanResponderReject of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderStart of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderEnd of (GestureResponderEvent -> PanResponderGestureState -> unit)
        | OnPanResponderTerminationRequest of (GestureResponderEvent -> PanResponderGestureState -> bool)

    module StatusBar =
        type StatusBarPropertiesIOS =
            | BarStyle of StatusBarStyle list
            | NetworkActivityIndicatorVisible of bool
            | ShowHideTransition of ShowHideTransition
            interface IStatusBarProperties

        type StatusBarPropertiesAndroid =
            | BackgroundColor of obj
            | Translucent of bool
            interface IStatusBarProperties

    type StatusBarProperties =
        | Animated of bool
        | Hidden of bool
        interface IStatusBarProperties

    type NavigationAnimatedViewProps =
        | Route of obj
        | RenderOverlay of (obj -> ReactElement)
        | ApplyAnimation of (obj * obj -> unit)
        | RenderScene of (obj -> ReactElement)
        static member Style (style: IStyle list) : NavigationAnimatedViewProps = !!("style", keyValueList CaseRules.LowerFirst style)


    type INavigationHeaderProps =
        interface end

    type NavigationHeaderProps =
        | RenderTitleComponent of (NavigationTransitionProps -> ReactElement)
        | RenderLeftComponent of (NavigationTransitionProps -> ReactElement)
        | RenderRightComponent of (NavigationTransitionProps -> ReactElement)
        | StatusBarHeight of U2<float,Animated.Value>
        | OnNavigateBack of (unit -> unit)
        interface INavigationHeaderProps

    type INavigationCardStackProps =
        interface end

    type NavigationCardStackProps =
        | Direction of Direction
        | EnableGestures of bool
        | GestureResponseDistance of float
        | CardStyle of IStyle list
        | RenderHeader of (NavigationTransitionProps -> ReactElement)
        | OnNavigateBack of (unit -> unit)
        interface INavigationCardStackProps
        static member Style (style: IStyle list) : NavigationCardStackProps = !!("style", keyValueList CaseRules.LowerFirst style)

    type IBreadcrumbNavigationBarProperties =
        interface end

    type BreadcrumbNavigationBarProperties =
        | Navigator of Navigator
        | RouteMapper of NavigatorStatic.BreadcrumbNavigationBarRouteMapper
        | NavState of NavState
        interface IBreadcrumbNavigationBarProperties
        static member Style (style: IStyle list) : IBreadcrumbNavigationBarProperties = !!("style", keyValueList CaseRules.LowerFirst style)

    type CommonProps<'a> =
        | Key of string
        interface IViewProperties
        interface IToolbarAndroidProperties
        interface ISegmentedControlIOSProperties
        interface IWebViewProperties
        interface IWebViewPropertiesAndroid
        interface IWebViewPropertiesIOS
        interface IDatePickerIOSProperties
        interface IDrawerLayoutAndroidProperties
        interface IPickerProperties<'a>
        interface IProgressBarAndroidProperties
        interface IProgressViewIOSProperties
        interface IRefreshControlProperties
        interface ISliderProperties
        interface ITabBarItemProperties
        interface ITabBarIOSProperties
        interface IListViewProperties
        interface IFlatListProperties<'a>
        interface IScrollViewProperties
        interface IStatusBarProperties
        interface ISwitchProperties
        interface IKeyboardAvoidingViewProps
        interface IActivityIndicatorProperties
        interface IActivityIndicatorIOSProperties
        interface IMapViewProperties
        interface IMapViewPropertiesAndroid
        interface IViewPropertiesIOS
        interface IViewPropertiesAndroid
        interface ISectionListProperties<'a>
        interface IButtonProperties
        interface IImageProperties
        interface IAnimatedScrollViewProperties
        interface ITouchableHighlightProperties
        interface ITouchableWithoutFeedbackProperties
        interface ITouchableNativeFeedbackProperties
        interface ITouchableOpacityProperties
        interface ITextProperties
        interface ITextInputProperties

[<AutoOpen>]
module Helpers =
    open Props

    [<Emit("$0")>]
    // density independent pixels
    let dip (_: float): ISizeUnit = jsNative

    [<Emit("$0 + \"%\"")>]
    // percents
    let pct (_: float): ISizeUnit = jsNative

    [<Emit("$0 + \"deg\"")>]
    let deg (_: float): IAngle = jsNative

    [<Emit("$0 + \"rad\"")>]
    let rad (_: float): IAngle = jsNative

    [<Emit("require($0)")>]
    // Use `require` to load a local image
    let inline localImage (_path:string) : IImageSource = jsNative

    let inline remoteImage (source: ImageURISourceProperties list) =
      unbox<IImageSource> (keyValueList CaseRules.LowerFirst source)

    let inline remoteImages (sources: ImageURISourceProperties list array) =
      unbox<IImageSource> (Array.map remoteImage sources)

    let inline section<'a> (data: 'a []) (props: SectionListDataProps<'a> list) (custom: obj): SectionListData<'a> =
        let pascalCaseProps, camelCaseProps =
          List.partition (function
                          | SectionListDataProps.ItemSeparatorComponent _ -> true
                          | _ -> false)
                          props

        unbox<SectionListData<'a>>
          (JS.Constructors.Object.assign(
            createObj ["data" ==> data],
            keyValueList CaseRules.LowerFirst camelCaseProps,
            keyValueList CaseRules.None pascalCaseProps,
            custom
          ))

    let inline createElement(c: ReactElementType<'T>, props: 'P list, children: ReactElement seq) =
        ReactBindings.React.createElement (c, keyValueList CaseRules.LowerFirst props, children)

    let inline createElementWithBaseProps(c: ReactElementType<'T>, baseProps: (string*obj) list, props: 'P list, children: ReactElement seq) =
        ReactBindings.React.createElement(c, JS.Constructors.Object.assign(createObj baseProps, keyValueList CaseRules.LowerFirst props), children)

    let inline internal createElementWithObjProps(c: ReactElementType, props: obj, children: ReactElement seq) =
        ReactBindings.React.createElement (c, props, children)

    let inline text (props:ITextProperties list) (text:string): ReactElement =
        createElement(RN.Text, props, [str text])

    let inline textInput (props: ITextInputProperties list): ReactElement =
        createElement(RN.TextInput, props, [])

    let inline textInputWithChild (props: ITextInputProperties list) (text: string): ReactElement =
        createElement(RN.TextInput, props, [str text])

    let inline createToolbarAction(title:string,showStatus:ToolbarActionShowStatus) : ToolbarAndroidAction =
        createObj [
            "title" ==> title
            "show" ==> showStatus
        ]

    let inline createToolbarActionWithIcon(title:string,icon: IImageSource,showStatus:ToolbarActionShowStatus) : ToolbarAndroidAction =
        createObj [
            "title" ==> title
            "icon" ==> icon
            "show" ==> showStatus
        ]

    let inline toolbarAndroid (props:IToolbarAndroidProperties list)  : ReactElement =
        createElement(
            RN.ToolbarAndroid,
            props,
            [])

    let inline keyboardAvoidingView (props:IKeyboardAvoidingViewProps list) (children: ReactElement seq): ReactElement =
        createElement(
          RN.KeyboardAvoidingView,
          props,
          children)

    let inline view (props: IViewProperties list) (children: ReactElement seq): ReactElement =
        createElement(
            RN.View,
            props,
            children)

    let inline webView (props:IWebViewProperties list) : ReactElement =
        createElement(
          RN.WebView,
          props, [])

    let inline segmentedControlIOS (props:ISegmentedControlIOSProperties list) : ReactElement =
        createElement(
          RN.SegmentedControlIOS,
          props, [])

    let inline activityIndicator (props:IActivityIndicatorProperties list) : ReactElement =
        createElement(
          RN.ActivityIndicator,
          props, [])

    let inline activityIndicatorIOS (props:IActivityIndicatorIOSProperties list) : ReactElement =
        createElement(
          RN.ActivityIndicatorIOS,
          props, [])

    let inline datePickerIOS (props:IDatePickerIOSProperties list) : ReactElement =
        createElement(
          RN.DatePickerIOS,
          props, [])

    let inline drawerLayoutAndroid (props:IDrawerLayoutAndroidProperties list) (renderNavigationView: unit -> ReactElement) (children: ReactElement seq): ReactElement =
        createElementWithObjProps(
          RN.DrawerLayoutAndroid,
          !!JS.Constructors.Object.assign(
                createObj ["renderNavigationView" ==> renderNavigationView],
                keyValueList CaseRules.LowerFirst props),
          children)

    let inline pickerIOSItem (props:Picker.PickerIOSItemProperties list) : ReactElement =
        createElement(
          RN.PickerIOS.Item,
          props, [])

    let inline pickerItem<'a> (props:Picker.PickerItemProperties<'a> list) : IPickerItem<'a> =
        unbox<IPickerItem<'a>> (createElement(RN.Picker.Item, props, []))

    let inline picker (props:IPickerProperties<'a> list) (children:IPickerItem<'a> seq): ReactElement =
        createElement(
          RN.Picker,
          props,
          unbox<ReactElement seq> children)

    let inline pickerIOS (props:Picker.PickerIOSProperties<'a> list) (children:ReactElement seq): ReactElement =
        createElement(
          RN.PickerIOS,
          props,
          children)

    let inline progressBarAndroid (props:IProgressBarAndroidProperties list) : ReactElement =
        createElement(
          RN.ProgressBarAndroid,
          props, [])

    let inline progressViewIOS (props:IProgressViewIOSProperties list) : ReactElement =
        createElement(
          RN.ProgressViewIOS,
          props, [])

    let inline refreshControl (props:IRefreshControlProperties list) : ReactElement =
        createElement(
          RN.RefreshControl,
          props, [])

    let inline slider (props:ISliderProperties list) : ReactElement =
        createElement(
          RN.Slider,
          props, [])

    let inline switch (props:ISwitchProperties list) : ReactElement =
        createElement(
          RN.Switch,
          props, [])

    let inline image (props:IImageProperties list) : ReactElement =
        createElement(
          RN.Image,
          props, [])

    let inline imageWithChild (props: IImageProperties list) (child: ReactElement) : ReactElement =
        createElement(
            RN.Image,
            props,
            [child])

    let inline listView<'a> (dataSource:ListViewDataSource<'a>) (props: IListViewProperties list)  : ReactElement =
        createElementWithObjProps(
          RN.ListView,
          !!JS.Constructors.Object.assign(
                createObj ["dataSource" ==> dataSource],
                keyValueList CaseRules.LowerFirst props), [])

    let inline flatList<'a> (data:'a []) (props: IFlatListProperties<'a> list)  : ReactElement =
        // Some of FlatList properties are upper case:
        // https://github.com/DefinitelyTyped/DefinitelyTyped/blob/master/types/react-native/index.d.ts#L3608-L3623
        let pascalCaseProps =
          List.filter (function
                       | ItemSeparatorComponent _ -> true
                       | ListEmptyComponent _ -> true
                       | ListFooterComponent _ -> true
                       | ListHeaderComponent _ -> true
                       | _ -> false)
                       (unbox<FlatListProperties<'a> list> props)

        createElementWithObjProps(
          RN.FlatList,
          !!JS.Constructors.Object.assign(
                createObj ["data" ==> data],
                keyValueList CaseRules.LowerFirst props,
                keyValueList CaseRules.None pascalCaseProps), [])

    let inline sectionList<'a> (sections: SectionListData<'a> []) (props: ISectionListProperties<'a> list)  : ReactElement =
        let pascalCaseProps =
          List.filter (function
                       | SectionListProperties.ItemSeparatorComponent _ -> true
                       | SectionListProperties.ListEmptyComponent _ -> true
                       | SectionListProperties.ListFooterComponent _ -> true
                       | SectionListProperties.ListHeaderComponent _ -> true
                       | SectionSeparatorComponent _ -> true
                       | _ -> false)
                       (unbox<SectionListProperties<'a> list> props)

        createElementWithObjProps(
          RN.SectionList,
          !!JS.Constructors.Object.assign(
                createObj ["sections" ==> sections],
                keyValueList CaseRules.LowerFirst props,
                keyValueList CaseRules.None pascalCaseProps), [])

    let inline mapView (props:IMapViewProperties list) (children: ReactElement seq): ReactElement =
        createElement(
          RN.MapView,
          props,
          children)

    let inline modal (props:ModalProperties list) (children: ReactElement seq): ReactElement =
        createElement(
          RN.Modal,
          props,
          children)

    let inline button (props:IButtonProperties list) (children: ReactElement seq) : ReactElement =
        createElement(
          RN.Button,
          props,
          children)

    let inline touchableWithoutFeedback (props:ITouchableWithoutFeedbackProperties list) (children: ReactElement seq): ReactElement =
        createElement(
          RN.TouchableWithoutFeedback,
          props,
          children)

    let inline touchableHighlight (props:ITouchableHighlightProperties list) (children: ReactElement seq) : ReactElement =
        createElement(
          RN.TouchableHighlight,
          props,
          children)

    let inline touchableHighlightWithChild (props:ITouchableHighlightProperties list) (child: ReactElement): ReactElement =
        createElement(
          RN.TouchableHighlight,
          props,
          [child])

    let inline touchableOpacity (props:ITouchableOpacityProperties list) (children: ReactElement seq): ReactElement =
        createElement(
          RN.TouchableOpacity,
          props,
          children)

    let inline touchableNativeFeedback (props:ITouchableNativeFeedbackProperties list) (children: ReactElement seq): ReactElement =
        createElement(
          RN.TouchableNativeFeedback,
          props,
          children)


    let inline navigator (props:INavigatorProperties list) : ReactElement =
        createElement(
          RN.Navigator,
          props, [])

    let inline tabBarItem (props:ITabBarItemProperties list) : ReactElement =
        createElement(
          RN.TabBarIOS.Item,
          props, [])

    let inline tabBarIOS (props:ITabBarIOSProperties list) : ReactElement =
        createElement(
          RN.TabBarIOS,
          props, [])

    let inline scrollView (props:IScrollViewProperties list) (children: ReactElement seq) : ReactElement =
        createElement(
          RN.ScrollView,
          props,
          children)

    let inline swipeableListView (props:SwipeableListViewProps<_> list) : ReactElement =
        createElement(
          RN.SwipeableListView,
          props, [])

    let inline statusBar (props:IStatusBarProperties list) : ReactElement =
        createElement(
          RN.StatusBar,
          props, [])

    let inline navigationHeader (props:INavigationHeaderProps list) (rendererProps:NavigationTransitionProps): ReactElement =
        createElementWithObjProps(
          RN.NavigationExperimental.Header,
          !!JS.Constructors.Object.assign(keyValueList CaseRules.LowerFirst props, rendererProps), [])

    let inline navigationState (index:int) (routes:NavigationRoute list): NavigationState =
        !!createObj ["index" ==> index
                     "routes" ==> Array.ofList routes]

    let inline navigationRoute (key:string) (title:string option): NavigationRoute =
        !!createObj ["key" ==> key
                     "title" ==> title]

    let inline navigationCardStack (navigationState: NavigationState)
                            (renderScene: NavigationTransitionProps -> ReactElement)
                            (props:INavigationCardStackProps list): ReactElement =
        createElementWithObjProps(
          RN.NavigationExperimental.CardStack,
          !!JS.Constructors.Object.assign(
                createObj ["renderScene" ==> renderScene
                           "navigationState" ==> navigationState],
                keyValueList CaseRules.LowerFirst props), [])

    let inline navigationContainer (props:NavigationContainerProps list) : ReactElement =
        createElement(
          RN.NavigationContainer,
          props, [])

    let inline navigationRootContainer (props:NavigationRootContainerProps list) : ReactElement =
        createElement(
          RN.NavigationRootContainer,
          props, [])

    let inline navigationBar (props:NavigationBarProperties list) : ReactElement =
        createElement(
          NavigatorStatic.Globals.NavigationBar,
          props, [])

    let inline breadcrumbNavigationBar (props:IBreadcrumbNavigationBarProperties list) : ReactElement =
        createElement(
          NavigatorStatic.Globals.BreadcrumbNavigationBar,
          props, [])

    let inline emptyDataSource<'a>() : ListViewDataSource<'a> =
        !!RN.ListView.DataSource.Create(
            !!createObj ["rowHasChanged" ==> fun r1 r2 -> r1 <> r2])

    let inline newDataSource<'a> (elements:'a []) =
        emptyDataSource<'a>().cloneWithRows(!!elements)

    let inline updateDataSource<'a> (data:'a []) (dataSource : ListViewDataSource<'a>) : ListViewDataSource<'a> =
        dataSource.cloneWithRows(!!data)

    let inline animatedView (props: IAnimatedViewProperties list) (children: ReactElement list): ReactElement =
        createElement(
            Animated.Globals.View,
            props,
            children)

    let inline animatedScrollView (props: IAnimatedScrollViewProperties list) (children: ReactElement list): ReactElement =
        createElement(
            Animated.Globals.ScrollView,
            props,
            children)

    let inline animatedImage (props: IAnimatedImageProperties list) (children: ReactElement list): ReactElement =
        createElement(
            Animated.Globals.Image,
            props,
            children)

    let inline animatedText (props: IAnimatedTextProperties list) (children: ReactElement list): ReactElement =
        createElement(
            Animated.Globals.Text,
            props,
            children)

    [<Import("Buffer","buffer")>]
    [<Emit("$0.from($1).toString($2)")>]
    let encode (text: string, encoding:string) : string = jsNative

    let encodeBase64 (text: string) : string = encode(text,"base64")
    let encodeAscii (text: string) : string = encode(text,"ascii")

    [<Import("BackHandler","react-native")>]
    let private BackHandler = obj()

    let removeOnHardwareBackPressHandler (onHardwareBackPress: unit -> bool): unit =
        BackHandler?removeEventListener("hardwareBackPress", onHardwareBackPress) |> ignore

    let setOnHardwareBackPressHandler (onHardwareBackPress: unit -> bool): unit =
        BackHandler?addEventListener("hardwareBackPress", onHardwareBackPress) |> ignore


    let exitApp (): unit =
        BackHandler?exitApp() |> ignore

    [<Import("Linking","react-native")>]
    let private Linking = obj()

    /// Opens the given URL
    let openUrl (url:string) : unit =
        Linking?openURL(url) |> ignore

module Alert =
    [<Import("Alert","react-native")>]
    let private Alert = obj()

    type Options =
        | Cancelable of bool
        | OnDismiss of (unit -> unit)

    let private createButton(label:string,callback:unit -> unit) =
        createObj [
            "text" ==> label
            "onPress" ==> callback
        ]

    let alertWithOptions (title:string,message:string,buttons: (string * (unit -> unit)) seq, options: Options list) : unit =
        Alert?alert( title, message, Seq.map createButton buttons |> Seq.toArray, keyValueList CaseRules.LowerFirst options ) |> ignore

    /// Shows an alert with many buttons
    let alert (title:string,message:string,buttons: (string * (unit -> unit)) seq) : unit =
        alertWithOptions( title, message, buttons, [])

    /// Shows an alert button with one button
    let alertWithOneButton (title:string,message:string,okText:string,onOk:unit -> unit) : unit =
        alert( title, message, [ okText,onOk ]) |> ignore

    /// Shows an alert button with two buttons
    let alertWithTwoButtons (title:string,message:string,cancelText:string,onCancel:unit -> unit,okText:string,onOk:unit -> unit) : unit =
        alert( title, message, [ (cancelText,onCancel); (okText,onOk) ]) |> ignore

    let confirm (title:string,message:string,cancelText:string,okText:string) =
        Promise.create(fun onSuccess onError ->
            let onError() = onError(Exception("Cancelled"))
            alertWithTwoButtons (title,message,cancelText,onError,okText,onSuccess)
        )

module NetInfo =
    [<Import("*","@react-native-community/netinfo")>]
    let private NetInfo = obj()

    open Fable.Core.JS
    open Browser.Types

    let getConnectionType() : Promise<string> =
        !!NetInfo?fetch()

/// ImageStore contains functions which help to deal with image data on the device.
module ImageStore =
    [<Import("ImageStore","react-native")>]
    let private ImageStore = obj()

    /// Retrieves the base64-encoded data for an image in the ImageStore. If the specified URI does not match an image in the store, an exception will be raised.
    let getBase64ForTag uri : JS.Promise<string> =
        Promise.create(fun onSuccess onError ->
            ImageStore?getBase64ForTag(uri, onSuccess, onError) |> ignore
        )

    /// Stores a base64-encoded image in the ImageStore, and returns a URI that can be used to access or display the image later.
    /// Images are stored in memory only, and must be manually deleted when you are finished with them by calling removeImageForTag().
    let addImageFromBase64 imageData : JS.Promise<string> =
        Promise.create(fun onSuccess onError ->
            ImageStore?addImageFromBase64(imageData, onSuccess, onError) |> ignore
        )

/// ImageEditor contains functions which help to deal with image data.
module ImageEditor =
    [<RequireQualifiedAccess>]
    type ResizeMode =
    | Contain
    | Cover
    | Stretch

    type CropData() =
        let data = createObj [  ]

        member this.SetSize(width:int,height:int) =
            let size =
                createObj
                    [ "width" ==> width
                      "height" ==> height ]

            data?size <- size
            this

        member this.SetDisplaySize(width:int,height:int) =
            let size =
                createObj
                    [ "width" ==> width
                      "height" ==> height ]

            data?displaySize <- size
            this

        member this.SetOffset(x:int,y:int) =
            let offset =
                createObj
                    [ "x" ==> x
                      "y" ==> y ]

            data?offset <- offset
            this

        member this.SetResizeMode(mode:ResizeMode) =

            data?displaysize <-
                match mode with
                | ResizeMode.Contain -> "contain"
                | ResizeMode.Cover -> "cover"
                | ResizeMode.Stretch -> "stretch"
            this


    [<Import("ImageEditor","react-native")>]
    let private ImageEditor = obj()

    /// Crop the image specified by the URI param. If URI points to a remote image, it will be downloaded automatically.
    /// If the image cannot be loaded/downloaded, the failure callback will be called.
    let cropImage (uri:string) (cropData:CropData) : JS.Promise<string> =
        Promise.create(fun onSuccess onError ->
            ImageEditor?cropImage(uri, cropData?data, onSuccess, onError) |> ignore
        )

module Toast =
    [<Import("ToastAndroid","react-native")>]
    let private Toast = obj()

    /// Shows a toast with short duration
    let showShort (message:string) : unit =
        !!Toast?show(message,Toast?SHORT)

    /// Shows a toast with long duration
    let showLong (message:string) : unit =
        !!Toast?show(message,Toast?LONG)

module Platform =
    type OS<'a> =
        | Ios of 'a
        | Android of 'a
        | Macos of 'a
        | Windows of 'a
        | Web of 'a
        | Default of 'a

    let select<'a> (specifics: OS<'a> list): 'a =
        Globals.Platform.select (keyValueList CaseRules.LowerFirst specifics)
