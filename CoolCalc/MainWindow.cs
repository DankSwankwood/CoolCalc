using System;

namespace CoolCalc
{
	public partial class MainWindow : Gtk.Window
	{
		public MainWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			//Added comment for test
			this.Build ();
			//this is cool
		}

		protected void OnButton7Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

