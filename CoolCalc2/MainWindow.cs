using System;
using System.Linq;
using Gtk;
using Pango;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{
	bool checkRadDeg;
	double operand1, operand2;
	string textviewInput = ""; //this is used to store the textview input for the calculations 

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		textview1.Buffer.Text = "0"; //Initializes the text view with a zero
		btnOn.Sensitive = false; //The on button is disabled at program start

		////////////////////////////// DESIGN

		textview1.ModifyFont(FontDescription.FromString("Helvetica 32"));
		label1.ModifyFont(FontDescription.FromString("Helvetica 16"));
		label1.ModifyBg (Gtk.StateType.Normal, new Gdk.Color (255, 255, 255));
		label1.ModifyFg (Gtk.StateType.Normal, new Gdk.Color (143, 143, 143));

		//Color of buttons:
		//Equals button to blue color (Inspiration from Googles Scientific Calculator)
		Gdk.Color colEquals = new Gdk.Color(73,141,252);
		Gdk.Color colFunctions = new Gdk.Color (212, 212, 212);
		Gdk.Color colFont = new Gdk.Color(255,255,255);

		//Equals button:
		btnEquals.ModifyBg (Gtk.StateType.Normal, colEquals);
		btnEquals.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(80, 150,255));
		btnEquals.ModifyBg (Gtk.StateType.Active, colEquals);
		btnEquals.ModifyFg (Gtk.StateType.Normal, colFont);
		btnEquals.ModifyFg (Gtk.StateType.Prelight, colFont);
		btnEquals.ModifyFg (Gtk.StateType.Active, colFont);

		//Function buttons:
		//All number buttons are default color and all the function buttons are darker.
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
		btnDel.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnDel.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnDel.ModifyBg (Gtk.StateType.Active, colFunctions);
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
		btnLn.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnLn.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnLn.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnSinInv.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnSinInv.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnSinInv.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnCosInv.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnCosInv.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnCosInv.ModifyBg (Gtk.StateType.Active, colFunctions);
		btnTanInv.ModifyBg (Gtk.StateType.Normal, colFunctions);
		btnTanInv.ModifyBg (Gtk.StateType.Prelight, new Gdk.Color(225,225,225));
		btnTanInv.ModifyBg (Gtk.StateType.Active, colFunctions);
		////////////////////////////// DESIGN - END
	}

	//IfZero prevents multiple zero in the text field to be present - IfZero(); needs to be called in 
	//every button click.
	//IfZero also contains the function to remove the result from the textview and put it in the label.
	//This allows for new calculations after the equals sign have been pressed. But if a operation sign have been pressed it should ignore the new operation function.
	protected void IfZero (){
		if (textview1.Buffer.Text == "0") {
			textview1.Buffer.Text = "";
		} else if (label1.Text.Contains ("=") && !textview1.Buffer.Text.Contains("+") && !textview1.Buffer.Text.Contains("-") && !textview1.Buffer.Text.Contains("*") && !textview1.Buffer.Text.Contains("/") && !textview1.Buffer.Text.Contains("%") && !textview1.Buffer.Text.Contains("^") || textview1.Buffer.Text.Contains("E")) {
			label1.Text = "Ans " + textview1.Buffer.Text;
			textview1.Buffer.Text = "";
		}
	}

	//Checks if thet ext buffer ends with a symbol and making it impossible to have multiples of the
	//same symbol. It haves an input so we can define what input it should write depending on in which
	//symbol code we add this function. - Niclas Bach Nielsen
	protected void CheckSymbol(string input){
		if (textview1.Buffer.Text.EndsWith ("+") ||
		    textview1.Buffer.Text.EndsWith ("-") ||
		    textview1.Buffer.Text.EndsWith ("/") ||
		    textview1.Buffer.Text.EndsWith ("%") ||
			textview1.Buffer.Text.EndsWith ("^") ||
			textview1.Buffer.Text.EndsWith (".")) {
		} else {
			textview1.Buffer.Text = textview1.Buffer.Text + input;
		}
		if (textview1.Buffer.Text.Contains ("Error")) {
			textview1.Buffer.Text = "0" + input;
		}
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		//Comment of Application.Quit() and a.RetVal = true (instead of false) 
		//Prevents the application from quitting
		Application.Quit ();
		a.RetVal = false;
	}
		
	protected void OnClearBtnClicked (object sender, EventArgs e)
	{
		label1.Text = "";
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
			//DO NOTHING
		} else {
			CheckSymbol ("+");
		}

	}

	//Works the same as the plus (+) button but with minus (-)
	protected void OnBtnMinusClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith("-")) {
			//DO NOTHING
		} else {
			CheckSymbol ("-");
		}
	}

	//works the same, but with divide (/)
	protected void OnBtnDivClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith ("/")) {
			//DO NOTHING
		} else {
			CheckSymbol ("/");
		}
	}

	//works the same, but with multiply (*)
	protected void OnBtnMulClicked (object sender, EventArgs e)
	{

		if (textview1.Buffer.Text.EndsWith ("*")) {
			//DO NOTHING
		} else {
			CheckSymbol ("*");
		}
	}
		
	protected void OnBtnPercClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith ("%")) {
			//DO NOTHING
		} else {
			CheckSymbol ("%");
		}	
	}

	protected void OnBtnXYClicked (object sender, EventArgs e)
	{
		if (textview1.Buffer.Text.EndsWith ("^")) {
			//DO NOTHING
		} else {
			CheckSymbol ("^");
		}
	}

	protected void OnBtnX3Clicked (object sender, EventArgs e)
	{
		label1.Text = textview1.Buffer.Text + "³" + " =";
		//if x rise to power 3 is selected
		{ 
			operand1 = Convert.ToDouble(textview1.Buffer.Text) * Convert.ToDouble(textview1.Buffer.Text) *
				Convert.ToDouble(textview1.Buffer.Text);
			textview1.Buffer.Text = Convert.ToString(operand1);


		}
	}

	protected void OnBtnX2Clicked (object sender, EventArgs e)
	{
		label1.Text = textview1.Buffer.Text + "²" + " =";
		//if x rise to power 2 is selected
		{ 
			operand1 = Convert.ToDouble (textview1.Buffer.Text) * Convert.ToDouble (textview1.Buffer.Text);
			textview1.Buffer.Text = Convert.ToString(operand1);


		}
	}

	protected void OnBtnDotClicked (object sender, EventArgs e)
	{
		int testDot = 0;
		int dotPlus, dotMinus, dotMulti, dotDiv, dotPerc = 0;
		if (textview1.Buffer.Text.EndsWith (".")) {
			//DO NOTHING
		} else {
			testDot = textview1.Buffer.Text.LastIndexOf (",");
			dotPlus = textview1.Buffer.Text.LastIndexOf ("+");
			dotMinus = textview1.Buffer.Text.LastIndexOf ("-");
			dotMulti = textview1.Buffer.Text.LastIndexOf ("*");
			dotDiv = textview1.Buffer.Text.LastIndexOf ("/");
			dotPerc = textview1.Buffer.Text.LastIndexOf ("%");
			Console.WriteLine (testDot);
			if (testDot == -1 || dotPlus > testDot || dotMinus > testDot || dotMulti > testDot || dotDiv > testDot|| dotPerc > testDot) {
				CheckSymbol (".");
			}
		}
	}

	//Equals button - uses switch sentence to determine wether we have to add (+), divide (/) etc.
	protected void OnBtnEqualsClicked (object sender, EventArgs e)
	{
		label1.Text = textview1.Buffer.Text + " ="; //Making the label above the textview equal to the text view - for an intuitive and sexy calculator
		textviewInput = textview1.Buffer.Text;

		//Regex is used to split the strings and store the numbers and symbols in rNumbers and rSymbols
		System.Text.RegularExpressions.Regex rNumbers = new System.Text.RegularExpressions.Regex("[+]|[-]|[/]|[*]|[%]|[/^]");
		System.Text.RegularExpressions.Regex rSymbols = new System.Text.RegularExpressions.Regex("[0-9]+[.]?[0-9]?");

		//Giving the numbers and symbols their own list
		List<string> numbersList = rNumbers.Split(textviewInput).ToList<string>();
		List<string> symbolsList = rSymbols.Split(textviewInput).ToList<string>();
		symbolsList.RemoveAll(item => item == ""); //Removing all the spaces in order to calculate

		//Storing the first number in operand1
		operand1 = System.Convert.ToDouble(numbersList[0]);

		try{
			//For loop going through numbersList to get the numbers in order to do the calculations
			for (int i = 1, j = 0; i < numbersList.Count; i++, j++) {
				Console.Write ("\n{0} ", operand1); //show first part of equation in console

				//Get the next number
				operand2 = System.Convert.ToDouble (numbersList [i]);

				//Checking the symbolsList for which operation to perform. The switch case is used to perform the different operations.
				//If needed, other operations can be added.
				switch (symbolsList [j]) {
				case "+":
					{
						operand1 += operand2;
						break;
					}
				case "-":
					{
						operand1 -= operand2;
						break;
					}
				case "/":
					{
						operand1 /= operand2;
						break;
					}
				case "*":
					{
						operand1 *= operand2;
						break;
					}
				case "%":
					{
						operand1 %= operand2;
						break;
					}
				case "^":
					{
						operand1 = Math.Pow (operand1, operand2);
						break;
					}
				//Show final part of equation in console
				//Console.Write ("{0} {1} = {2}", symbolsList [j], operand2, operand1);

			}

			//Show the answer in the console and the textview1
			
			textview1.Buffer.Text = Convert.ToString(operand1);
			Console.WriteLine("\n\nYour final answer is: " + operand1 + "\n");
			}
		}

		catch{
			textview1.Buffer.Text = "Error";
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
		
	//ON button implementation. Enables all buttons and the textview but disables the ON button
	//since the program is already ON
	protected void OnBtnOnClicked (object sender, EventArgs e)
	{
		btnOn.Sensitive = false;
		btnOff.Sensitive = true;
		table1.Sensitive = true;
		degreebut.Sensitive = true;
		radianbut.Sensitive = true;
		textview1.Sensitive = true;
		textview1.Buffer.Text = "0";
	}

	//OFF button implementation. Disables all buttons and the textview but disables the OFF button
	protected void OnBtnOffClicked (object sender, EventArgs e)
	{
		btnOn.Sensitive = true;
		btnOff.Sensitive = false;
		table1.Sensitive = false;
		degreebut.Sensitive = false;
		radianbut.Sensitive = false;
		textview1.Sensitive = false;
		textview1.Buffer.Text = "0";
	}

	protected void OnBtnPiClicked (object sender, EventArgs e)
	{
		IfZero ();
		if (textview1.Buffer.Text.EndsWith ("3.14159265359")) {
			//DO NOTHING
		} else {
			textview1.Buffer.Text += "3.14159265359";
		}
	}


	// the factorial function is the product of all positive numbers. the loop takes a number and 
	//multiply with the number one less, until it hits 1.
	protected void OnBtnFactClicked (object sender, EventArgs e)
	{
		label1.Text = textview1.Buffer.Text + "!" + " =";
		double fac = 1;
		for (int i = 1; i <= Convert.ToDouble(textview1.Buffer.Text); i++) 
		{
			fac = i * fac;
		}
		textview1.Buffer.Text = Convert.ToString (fac);
	}

	//Radian and degree is used when calculating cos, sin, tan, whether you want the result in radians or degrees.  
	//the two radio buttons are booleans, theefore it will always be either radians or degrees. but is only taking into consideration
	//when calculating cos, sin, tan. 
	protected void OnRadianbutToggled (object sender, EventArgs e)
	{
		checkRadDeg = true;
	}
	protected void OnDegreebutToggled (object sender, EventArgs e)
	{
		checkRadDeg = false;
	}
		
	//	coding for Sin
	protected void OnBtnSinClicked (object sender, EventArgs e)
	{

		//if radian is selected
		if (checkRadDeg == true) {
			//writes function in label1 
			label1.Text = "sin(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text = Convert.ToString (System.Math.Sin (Convert.ToDouble (textview1.Buffer.Text)));
		}
		//if degree is selected
		else if(checkRadDeg == false) {
			//writes function in label1 
			label1.Text = "sin(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text = Convert.ToString (System.Math.Sin ((Convert.ToDouble (System.Math.PI) / 180) * (Convert.ToDouble (textview1.Buffer.Text))));
		}
	}

	// 	coding for Cos
	protected void OnBtnCosClicked (object sender, EventArgs e)
	{
		//if radian is selected
		if (checkRadDeg == true) {
			//writes function in label1 
			label1.Text = "cos(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text = Convert.ToString (System.Math.Cos (Convert.ToDouble (textview1.Buffer.Text)));
		}
		//if degree is selected
		else if(checkRadDeg == false) {
			//writes function in label1 
			label1.Text = "cos(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text = Convert.ToString (System.Math.Cos ((Convert.ToDouble (System.Math.PI) / 180) * (Convert.ToDouble (textview1.Buffer.Text))));
		}
	}

	protected void OnBtnTanClicked (object sender, EventArgs e)
	{
		//if radian is selected
		if (checkRadDeg == true) {
			label1.Text = "tan(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text = Convert.ToString (System.Math.Tan (Convert.ToDouble (textview1.Buffer.Text)));
		}
		//if degree is selected
		else if(checkRadDeg == false) {
			label1.Text = "tan(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text = Convert.ToString (System.Math.Tan ((Convert.ToDouble (System.Math.PI) / 180) * (Convert.ToDouble (textview1.Buffer.Text))));
		}
	}

	protected void OnBtnSinInvClicked (object sender, EventArgs e)
	{
		//if sin inverse is selected
		//if Radian is selected
		if (checkRadDeg == true)
		{
			label1.Text = "sin⁻¹(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text =
				Convert.ToString(System.Math.Asin (Convert.ToDouble (textview1.Buffer.Text)));

		}
		//if Degree is selected
		else
		{
			label1.Text = "sin⁻¹(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text =
				Convert.ToString (System.Math.Asin (Convert.ToDouble (System.Math.PI) / 180) *
					Convert.ToDouble (textview1.Buffer.Text));
		}
	}

	protected void OnBtnCosInvClicked (object sender, EventArgs e)
	{
		//if cos inverse is selected
		//if Radian is selected
		if (checkRadDeg == true)
		{
			label1.Text = "cos⁻¹(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text =
				Convert.ToString(System.Math.Acos (Convert.ToDouble (textview1.Buffer.Text)));
		}
		//if Degree is selected
		else
		{
			label1.Text = "cos⁻¹(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text =
				Convert.ToString (System.Math.Acos (Convert.ToDouble (System.Math.PI) / 180) *
					Convert.ToDouble (textview1.Buffer.Text));
		}

	}

	protected void OnBtnTanInvClicked (object sender, EventArgs e)
	{
		//if tan inverse is selected
		//if Radian is selected
		if (checkRadDeg == true)
		{
			label1.Text = "tan⁻¹(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text =
				Convert.ToString(System.Math.Atan (Convert.ToDouble (textview1.Buffer.Text)));
		}
		//if Degree is selected
		else
		{
			label1.Text = "tan⁻¹(" + textview1.Buffer.Text + ")" + " =";
			textview1.Buffer.Text =
				Convert.ToString (System.Math.Atan (Convert.ToDouble (System.Math.PI) / 180) *
					Convert.ToDouble (textview1.Buffer.Text));
		}
	}
		
	protected void OnBtnSqrClicked (object sender, EventArgs e)
	{
		label1.Text = "√(" + textview1.Buffer.Text + ")" + " =";

		//if squareroot is selected
		{
			operand1 = System.Math.Sqrt(Convert.ToDouble(textview1.Buffer.Text));
			textview1.Buffer.Text = Convert.ToString(operand1);
		}
	}

	protected void OnBtnLogClicked (object sender, EventArgs e)
	{
		label1.Text = "log(" + textview1.Buffer.Text + ")" + " =";
		//if log is selected
		{
			operand1 = System.Math.Log10 (Convert.ToDouble (textview1.Buffer.Text));
			textview1.Buffer.Text = Convert.ToString(operand1);
		}
	}

	protected void OnBtnLnClicked (object sender, EventArgs e)
	{
		label1.Text = "ln(" + textview1.Buffer.Text + ")" + " =";
		//if ln is selected
		{
			operand1 = System.Math.Log (Convert.ToDouble (textview1.Buffer.Text));
			textview1.Buffer.Text = Convert.ToString(operand1);
		}
	}
		
}
