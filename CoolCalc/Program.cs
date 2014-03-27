using System;
using Gtk;

namespace CoolCalc
{
	class MainClass
	{
		public static void main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}

