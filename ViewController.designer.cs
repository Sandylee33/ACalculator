// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ACalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AnswerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DivideButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MinusButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MultiplyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Number1TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Number2TextBox { get; set; }

        [Action ("AddButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("DivideButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DivideButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("MinusButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MinusButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("MultiplyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MultiplyButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddButton != null) {
                AddButton.Dispose ();
                AddButton = null;
            }

            if (AnswerLabel != null) {
                AnswerLabel.Dispose ();
                AnswerLabel = null;
            }

            if (DivideButton != null) {
                DivideButton.Dispose ();
                DivideButton = null;
            }

            if (MinusButton != null) {
                MinusButton.Dispose ();
                MinusButton = null;
            }

            if (MultiplyButton != null) {
                MultiplyButton.Dispose ();
                MultiplyButton = null;
            }

            if (Number1TextBox != null) {
                Number1TextBox.Dispose ();
                Number1TextBox = null;
            }

            if (Number2TextBox != null) {
                Number2TextBox.Dispose ();
                Number2TextBox = null;
            }
        }
    }
}