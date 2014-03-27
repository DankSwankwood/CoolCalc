using System;
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

		//Trying to change the color of the button (WIP)
		Gdk.Color col = new Gdk.Color();
		Gdk.Color.Parse ("blue", ref col);
		clearBtn.ModifyBase (StateType.Normal, col);
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

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}
}
