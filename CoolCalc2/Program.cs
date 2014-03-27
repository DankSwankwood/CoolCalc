using System;
using Gtk;

namespace CoolCalc2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();


//			Button btn17 = new Button ();
//			Gdk.Color col = new Gdk.Color ();
//			Gdk.Color.Parse ("blue", ref col);
//			btn17.ModifyFg (StateType.Normal, col);

		}
	}
}
