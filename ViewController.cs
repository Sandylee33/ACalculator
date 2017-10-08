using System;

using UIKit;

namespace ACalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void AddButton_TouchUpInside(UIButton sender)
        {
            var calculation = new Calculation();
            if (!Check(Number1TextBox.Text,Number2TextBox.Text))
            {
				var popup = UIAlertController.Create
					 ("Alert", "Enter a number", UIAlertControllerStyle.Alert);
				popup.AddAction(UIAlertAction.Create
								("ok", UIAlertActionStyle.Cancel, null));
				PresentViewController(popup, animated: true, completionHandler: null);
            }

            else{
				string answer = calculation.Addition(float.Parse(Number1TextBox.Text),
													float.Parse(Number2TextBox.Text));
                AnswerLabel.Text = "the answer is " + answer;
            }
           

        }



        partial void MinusButton_TouchUpInside(UIButton sender)
        {
			var calculation = new Calculation();
			if (!Check(Number1TextBox.Text, Number2TextBox.Text))
			{
				var popup = UIAlertController.Create
					 ("Alert", "Enter a number", UIAlertControllerStyle.Alert);
				popup.AddAction(UIAlertAction.Create
								("ok", UIAlertActionStyle.Cancel, null));
				PresentViewController(popup, animated: true, completionHandler: null);
			}

			else
			{
                string answer = calculation.Subtraction(float.Parse(Number1TextBox.Text),
													float.Parse(Number2TextBox.Text));
				AnswerLabel.Text = "the answer is " + answer;
			}
        }

        partial void MultiplyButton_TouchUpInside(UIButton sender)
        {
			var calculation = new Calculation();
			if (!Check(Number1TextBox.Text, Number2TextBox.Text))
			{
				var popup = UIAlertController.Create
					 ("Alert", "Enter a number", UIAlertControllerStyle.Alert);
				popup.AddAction(UIAlertAction.Create
								("ok", UIAlertActionStyle.Cancel, null));
				PresentViewController(popup, animated: true, completionHandler: null);
			}

			else
			{
                string answer = calculation.Multiplication(float.Parse(Number1TextBox.Text),
													float.Parse(Number2TextBox.Text));
				AnswerLabel.Text = "the answer is " + answer;
			}
        }

        partial void DivideButton_TouchUpInside(UIButton sender)
        {
			var calculation = new Calculation();
			if (!Check(Number1TextBox.Text, Number2TextBox.Text))
			{
				var popup = UIAlertController.Create
					 ("Alert", "Enter a number", UIAlertControllerStyle.Alert);
				popup.AddAction(UIAlertAction.Create
								("ok", UIAlertActionStyle.Cancel, null));
				PresentViewController(popup, animated: true, completionHandler: null);
			}

			else
			{
                string answer = calculation.Division(float.Parse(Number1TextBox.Text),
													float.Parse(Number2TextBox.Text));
				AnswerLabel.Text = "the answer is " + answer;
			}
        }

        bool Check(string a, string b){
            if (!float.TryParse(a, out float resulta) || !float.TryParse(b, out float resultb))
            {
                return false;
            }
            else { return true; }
        }

    }



    public class Calculation{
        
        public string Addition(float a, float b)
		{
            return (a + b).ToString();
		}

        public string Subtraction(float a, float b)
		{
            return (a - b).ToString();
		}
		public string Multiplication(float a, float b)
		{
            return (a * b).ToString();
		}
		public string Division(float a, float b)
		{
            if (b != 0f)
			{
                return (a / b).ToString();
			}
			else { return "N/A"; }

		}

	}

}
