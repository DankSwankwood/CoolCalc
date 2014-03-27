using System;
using Gtk;

namespace CoolCalc
{
	public partial class MainWindow : Gtk.Window
	{
		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{

			Build ();

		}

		protected void OnBtnNumZeroClicked (object sender, EventArgs e)
		{
			Console.WriteLine ("Button zero is pressed!");
			throw new NotImplementedException ();
		}

		protected void OnBtnNum1Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum2Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum3Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum4Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum5Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum6Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum7Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum8Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnBtnNum9Clicked (object sender, EventArgs e)
		{
			//OnTextview1InsertAtCursor += "9";
			throw new NotImplementedException ();
		}

//		protected void OnTextview1InsertAtCursor (object o, Gtk.InsertAtCursorArgs args)
//		{
//
//			throw new NotImplementedException ();
//		}
	}
}

