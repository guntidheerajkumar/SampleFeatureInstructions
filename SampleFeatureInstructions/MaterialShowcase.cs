using System;
using CoreGraphics;
using UIKit;

namespace SampleFeatureInstructions
{
    public class MaterialShowcase : UIView
    {
        // MARK: Material design guideline constant
        public const float BackgroundAlpha = .96f;
        public const float TargetHolderRadius = 44f;
        public const float TextCenterOffset = 44f + 20f;
        public const float InstructionsCenterOffset = 20f;
        public const float LabelMargin = 40f;
        public const float TargetPadding = 20f;

        // Other default properties
        public const float LabelDefaultHeight = 50f;
        public static UIColor BackgroundDefaultColor = UIColor.Black;
        public static UIColor TargetHolderColor = UIColor.Yellow;

        // MARK: Animation properties
        public const float AniComeInDuration = .5f; // second
        public const float AniGoOutDuration = .5f;  // second
        public const float AniTargetHolderScale = 2.2f;
        public static UIColor AniRippleColor = UIColor.Green;
        public const float AniRippleAlpha = .5f;
        public const float AniRippleScale = 1.6f;

        public const float OffsetThreshold = 88f;

        // MARK: Private view properties
        public UIView containerView;
        public UIView targetView;
        public UIView backgroundView;
        public UIView targetHolderView;
        public UIView hiddenTargetHolderView;
        public UIView targetRippleView;
        public UIView targetCopyView;
        public MaterialShowcaseInstructionView instructionView;

        // MARK: Public Properties

        // Background
        public UIColor backgroundPromptColor = UIColor.Blue;
        public float backgroundPromptColorAlpha;
        // Target
        public bool shouldSetTintColor = true;
        public UIColor targetTintColor;
        public float targetHolderRadius;
        public UIColor targetHolderColor;
        // Text
        public string primaryText;
        public string secondaryText;
        public UIColor primaryTextColor;
        public UIColor secondaryTextColor;
        public float primaryTextSize;
        public float secondaryTextSize;
        public UIFont primaryTextFont;
        public UIFont secondaryTextFont;
        // Animation
        public float aniComeInDuration;
        public float aniGoOutDuration;
        public float aniRippleScale;
        public UIColor aniRippleColor;
        public float aniRippleAlpha;

        public MaterialShowcase() : base(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height))
        {
            this.Configure();
        }
    }
}
