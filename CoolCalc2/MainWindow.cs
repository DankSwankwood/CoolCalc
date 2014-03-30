using System;
using System.Linq;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	string opr;
	double result, operand1, operand2;


	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		//Initializes the text view with a zero
		textview1.Buffer.Text = "0";
		btnOn2.Sensitive = false; //The on button is disable at program start

		//Equals button to blue color (Inspiration from Googles Scientific Calculator)
		Gdk.Color col = new Gdk.Color(73,141,252);
		Gdk.Color colFont = new Gdk.Color(255,255,255);
		//Gdk.Color.Parse ("blue", ref col);
		btnEquals.ModifyBg (Gtk.StateType.Normal, col);
		btnEquals.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(80, 150,255));
		btnEquals.ModifyBg (Gtk.StateType.Active, col);
		//btnEquals.ModifyBase (Gtk.StateType.Normal, colFont);
		btnEquals.ModifyText (Gtk.StateType.Prelight, colFont);



	}

	//IfZero prevents multiple zero in the text field to be present - IfZero(); needs to be called in 
	//every button click.
	protected void IfZero (){
		if (textview1.Buffer.Text == "0" ) {
			textview1.Buffer.Text = "";
		}
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		//Comment of Application.Quit() and a.RetVal = true (instead of false) 
		//Prevents the application from quitting
		Application.Quit ();
		a.RetVal = false;
	}

	protected void OnTextview1InsertAtCursor (object o, InsertAtCursorArgs args)
	{
	}


		
	protected void OnClearBtnClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = "0";
	}
	//All the numpad buttons (from 0-9). All have IfZero() that checks for zeros before non zero integers
	protected void OnBtnNumZeroClicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "0";

	}

	protected void OnBtnNum1Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "1";
	}

	protected void OnBtnNum2Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "2";
	}

	protected void OnBtnNum3Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "3";
	}

	protected void OnBtnNum4Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "4";
	}

	protected void OnBtnNum5Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "5";
	}

	protected void OnBtnNum6Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "6";
	}

	protected void OnBtnNum7Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "7";
	}

	protected void OnBtnNum8Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "8";
	}

	protected void OnBtnNum9Clicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text += "9";
	}
	//Coding for the plus button.
	//Their can only be one "+" sign present at a time after each number, this does the if and else
	//make sure of by checking if the text ends with a plus symbol (+), if it does it should remove it. 
	//Else it should add a plus symbol (+).
	protected void OnBtnPlusClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith("+")) {
			textview1.Buffer.Text = textview1.Buffer.Text.Remove(textview1.Buffer.Text.LastIndexOf("+"));
		} else {
			textview1.Buffer.Text += "+";
		}

	}
	//Works the same as the plus (+) button but with minus (-)
	protected void OnBtnMinusClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith("-")) {
			textview1.Buffer.Text = textview1.Buffer.Text.Remove(textview1.Buffer.Text.LastIndexOf("-"));
		} else {
			textview1.Buffer.Text += "-";
		}
	}
	//addition function - making sure that the operation is "+"
	private void addition(object sender, EventArgs e){

		operand1 = Convert.ToDouble (textview1.Buffer.Text);
		opr = "+";
		textview1.Buffer.Clear();
	}

	//Equals button - uses switch sentence to determine wether we have to add (+), divide (/) etc.
	protected void OnBtnEqualsClicked (object sender, EventArgs e)
	{
		operand2 = Convert.ToDouble (textview1.Buffer.Text);

		switch (opr) 
		{
		case "+":
			result = operand1 + operand2;
			textview1.Buffer.Text = Convert.ToString (result);
			break;
		}
	}

	protected void OnBtnDotClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith(".")) {
			textview1.Buffer.Text = textview1.Buffer.Text.Remove(textview1.Buffer.Text.LastIndexOf("."));
		} else {
			textview1.Buffer.Text += ".";
		}

	}

	//DEL button is implemented here. When clicked it stores the display text in a string and assigns
	//its length to an integer. The display text is then set to a substring that has one less
	//string length than before.
	protected void OnBtnDelClicked (object sender, EventArgs e)
	{
		string str = textview1.Buffer.Text;
		int stringLength = str.Length;

		textview1.Buffer.Text = (str.Substring (0, stringLength - 1));

		//Prevents the program to crash and at the same time sets the display text to '0'
		//when there is no more numbers to delete.
		if (textview1.Buffer.Text == "") {
			textview1.Buffer.Text = "0";
		}
	}

	protected void OnBtnLeftClicked (object sender, EventArgs e)
	{
		//textview1.Buffer.Insert(textview1.Buffer.StartIter, "HEJ");
		//textview1.Buffer.PlaceCursor (textView1.Buffer.EndIter);
		textview1.Buffer.PlaceCursor (textview1.Buffer.EndIter);

	}

	protected void OnBtnOnClicked (object sender, EventArgs e)
	{
			textview1.Sensitive = true;
			textview1.Buffer.Text = "0";
			btnNumZero.Sensitive = true;
			btnNum1.Sensitive = true;
			btnNum2.Sensitive = true;
			btnNum3.Sensitive = true;
			btnNum4.Sensitive = true;
			btnNum5.Sensitive = true;
			btnNum6.Sensitive = true;
			btnNum7.Sensitive = true;
			btnNum8.Sensitive = true;
			btnNum9.Sensitive = true;
			btnEquals.Sensitive = true;
			btnPlus.Sensitive = true;
			btnMinus.Sensitive = true;
			clearBtn.Sensitive = true;

			btnOff.Sensitive = true;
			btnOn.Sensitive = false;
	}

	protected void OnBtnOffClicked (object sender, EventArgs e)
	{
			textview1.Sensitive = false;
			textview1.Buffer.Text = "0";
			btnNumZero.Sensitive = false;
			btnNum1.Sensitive = false;
			btnNum2.Sensitive = false;
			btnNum3.Sensitive = false;
			btnNum4.Sensitive = false;
			btnNum5.Sensitive = false;
			btnNum6.Sensitive = false;
			btnNum7.Sensitive = false;
			btnNum8.Sensitive = false;
			btnNum9.Sensitive = false;
			btnEquals.Sensitive = false;
			btnPlus.Sensitive = false;
			btnMinus.Sensitive = false;
			clearBtn.Sensitive = false;
			btnOff.Sensitive = false;
			btnOn.Sensitive = true;
	}
	//ON button implementation. Enables all buttons and the textview but disables the ON button
	//since the program is already ON
	protected void OnBtnOn2Clicked (object sender, EventArgs e)
	{
		btnOn2.Sensitive = false;
		btnOff2.Sensitive = true;
		table1.Sensitive = true;
		textview1.Sensitive = true;
		textview1.Buffer.Text = "0";
	}

	//OFF button implementation. Disables all buttons and the textview but disables the OFF button
	protected void OnBtnOff2Clicked (object sender, EventArgs e)
	{
		btnOn2.Sensitive = true;
		btnOff2.Sensitive = false;
		table1.Sensitive = false;
		textview1.Sensitive = false;
		textview1.Buffer.Text = "0";

	}
}
