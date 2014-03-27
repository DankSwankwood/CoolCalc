using System;

namespace CoolCalc
{
	public partial class NewWindow : Gtk.Window
	{
		public NewWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

