﻿using System;

namespace CoolCalc
{
	public partial class MainWindow : Gtk.Window
	{
		public MainWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			//this is cool
		}
	}
}

