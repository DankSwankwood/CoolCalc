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

		//////////////////////////////DESIGN
		//Color of buttons:
		//Equals button to blue color (Inspiration from Googles Scientific Calculator)
		Gdk.Color colEquals = new Gdk.Color(73,141,252);
		Gdk.Color colFunctions = new Gdk.Color (212, 212, 212);
		Gdk.Color colFont = new Gdk.Color(255,255,255);
		//Equals button:
		btnEquals.ModifyBg (Gtk.StateType.Normal, colEquals);
		btnEquals.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(80, 150,255));
		btnEquals.ModifyBg (Gtk.StateType.Active, colEquals);
		//btnEquals.ModifyBase (Gtk.StateType.Normal, colFont);
		btnEquals.ModifyText (Gtk.StateType.Prelight, colFont);

		//Function buttons:
		btnPlus.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnPlus.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnPlus.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnMinus.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnMinus.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnMinus.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnMul.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnMul.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnMul.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnDiv.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnDiv.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnDiv.ModifyBg (Gtk.StateType.Active, colFunctions);
		clearBtn.ModifyBg (Gtk.StateType.Normal, colFunctions);
		clearBtn.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		clearBtn.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnPerc.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnPerc.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnPerc.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnRightPar.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnRightPar.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnRightPar.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnLeftPar.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnLeftPar.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnLeftPar.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnDel.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnDel.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnDel.ModifyBg (Gtk.StateType.Active, colFunctions);
//		btnRight.ModifyBg (Gtk.StateType.Normal, colFunctions);
//		btnRight.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
//		btnRight.ModifyBg (Gtk.StateType.Active, colFunctions);
//		btnLeft.ModifyBg (Gtk.StateType.Normal, colFunctions);
//		btnLeft.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
//		btnLeft.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnSin.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnSin.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnSin.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnCos.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnCos.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnCos.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnTan.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnTan.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnTan.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnSqr.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnSqr.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnSqr.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnPi.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnPi.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnPi.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnLog.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnLog.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnLog.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnX3.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnX3.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnX3.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnX2.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnX2.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnX2.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnXY.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnXY.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnXY.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnFact.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnFact.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnFact.ModifyBg (Gtk.StateType.Active, colFunctions);




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

	protected void OnBtnPiClicked (object sender, EventArgs e)
	{
		IfZero ();
		textview1.Buffer.Text = "3.14159265359";

		if (textview1.Buffer.Text.EndsWith("3.14159265359")){
			textview1.Buffer.Text = textview1.Buffer.Text + "3.14159265359";
		}
//		if (textview1.Buffer.Text.EndsWith("3.14159265359")) {
//			textview1.Buffer.Text = "3.14159265359";
//		} else if(textview1.Buffer.Text.){
//			textview1.Buffer.Text = textview1.Buffer.Text + "3.14159265359";
//		}
	}
}
