
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.EventBox eventbox1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Label label1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView textview1;
	private global::Gtk.HBox hbox3;
	private global::Gtk.RadioButton degreebut;
	private global::Gtk.RadioButton radianbut;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button btnOff2;
	private global::Gtk.Button btnOn2;
	private global::Gtk.Table table1;
	private global::Gtk.Button btnCos;
	private global::Gtk.Button btnCosMinus;
	private global::Gtk.Button btnDel;
	private global::Gtk.Button btnDiv;
	private global::Gtk.Button btnDot;
	private global::Gtk.Button btnEquals;
	private global::Gtk.Button btnFact;
	private global::Gtk.Button btnLeftPar;
	private global::Gtk.Button btnLn;
	private global::Gtk.Button btnLog;
	private global::Gtk.Button btnMinus;
	private global::Gtk.Button btnMul;
	private global::Gtk.Button btnNum1;
	private global::Gtk.Button btnNum2;
	private global::Gtk.Button btnNum3;
	private global::Gtk.Button btnNum4;
	private global::Gtk.Button btnNum5;
	private global::Gtk.Button btnNum6;
	private global::Gtk.Button btnNum7;
	private global::Gtk.Button btnNum8;
	private global::Gtk.Button btnNum9;
	private global::Gtk.Button btnNumZero;
	private global::Gtk.Button btnPerc;
	private global::Gtk.Button btnPi;
	private global::Gtk.Button btnPlus;
	private global::Gtk.Button btnRightPar;
	private global::Gtk.Button btnSin;
	private global::Gtk.Button btnSinMinus;
	private global::Gtk.Button btnSqr;
	private global::Gtk.Button btnTan;
	private global::Gtk.Button btnTanMinus;
	private global::Gtk.Button btnX2;
	private global::Gtk.Button btnX3;
	private global::Gtk.Button clearBtn;
	private global::Gtk.EventBox eventbox2;
	private global::Gtk.Button btnXY;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.eventbox1 = new global::Gtk.EventBox ();
		this.eventbox1.Name = "eventbox1";
		// Container child eventbox1.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Justify = ((global::Gtk.Justification)(1));
		this.vbox2.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanDefault = true;
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.AcceptsTab = false;
		this.textview1.Justification = ((global::Gtk.Justification)(1));
		this.textview1.Indent = 5;
		this.GtkScrolledWindow.Add (this.textview1);
		this.vbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
		w3.Position = 1;
		this.eventbox1.Add (this.vbox2);
		this.vbox1.Add (this.eventbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.eventbox1]));
		w5.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.degreebut = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Degree"));
		this.degreebut.CanFocus = true;
		this.degreebut.Name = "degreebut";
		this.degreebut.DrawIndicator = true;
		this.degreebut.UseUnderline = true;
		this.degreebut.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox3.Add (this.degreebut);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.degreebut]));
		w6.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.radianbut = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Radian"));
		this.radianbut.CanFocus = true;
		this.radianbut.Name = "radianbut";
		this.radianbut.DrawIndicator = true;
		this.radianbut.UseUnderline = true;
		this.radianbut.Group = this.degreebut.Group;
		this.hbox3.Add (this.radianbut);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.radianbut]));
		w7.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnOff2 = new global::Gtk.Button ();
		this.btnOff2.CanFocus = true;
		this.btnOff2.Name = "btnOff2";
		this.btnOff2.UseUnderline = true;
		this.btnOff2.FocusOnClick = false;
		this.btnOff2.BorderWidth = ((uint)(6));
		this.btnOff2.Label = global::Mono.Unix.Catalog.GetString ("OFF");
		this.hbox1.Add (this.btnOff2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnOff2]));
		w8.PackType = ((global::Gtk.PackType)(1));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnOn2 = new global::Gtk.Button ();
		this.btnOn2.CanFocus = true;
		this.btnOn2.Name = "btnOn2";
		this.btnOn2.UseUnderline = true;
		this.btnOn2.FocusOnClick = false;
		this.btnOn2.BorderWidth = ((uint)(6));
		this.btnOn2.Label = global::Mono.Unix.Catalog.GetString ("ON");
		this.hbox1.Add (this.btnOn2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnOn2]));
		w9.PackType = ((global::Gtk.PackType)(1));
		w9.Position = 1;
		w9.Expand = false;
		this.hbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox1]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(7)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.btnCos = new global::Gtk.Button ();
		this.btnCos.CanFocus = true;
		this.btnCos.Name = "btnCos";
		this.btnCos.UseUnderline = true;
		this.btnCos.FocusOnClick = false;
		this.btnCos.Label = global::Mono.Unix.Catalog.GetString ("cos");
		this.table1.Add (this.btnCos);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnCos]));
		w12.TopAttach = ((uint)(1));
		w12.BottomAttach = ((uint)(2));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnCosMinus = new global::Gtk.Button ();
		this.btnCosMinus.CanFocus = true;
		this.btnCosMinus.Name = "btnCosMinus";
		this.btnCosMinus.UseUnderline = true;
		this.btnCosMinus.Label = global::Mono.Unix.Catalog.GetString ("cos-1");
		this.table1.Add (this.btnCosMinus);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnCosMinus]));
		w13.TopAttach = ((uint)(2));
		w13.BottomAttach = ((uint)(3));
		w13.LeftAttach = ((uint)(1));
		w13.RightAttach = ((uint)(2));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnDel = new global::Gtk.Button ();
		this.btnDel.CanFocus = true;
		this.btnDel.Name = "btnDel";
		this.btnDel.UseUnderline = true;
		this.btnDel.FocusOnClick = false;
		this.btnDel.Label = global::Mono.Unix.Catalog.GetString ("DEL");
		this.table1.Add (this.btnDel);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnDel]));
		w14.LeftAttach = ((uint)(2));
		w14.RightAttach = ((uint)(3));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnDiv = new global::Gtk.Button ();
		this.btnDiv.CanFocus = true;
		this.btnDiv.Name = "btnDiv";
		this.btnDiv.UseUnderline = true;
		this.btnDiv.FocusOnClick = false;
		this.btnDiv.Label = global::Mono.Unix.Catalog.GetString ("/");
		this.table1.Add (this.btnDiv);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnDiv]));
		w15.TopAttach = ((uint)(1));
		w15.BottomAttach = ((uint)(2));
		w15.LeftAttach = ((uint)(6));
		w15.RightAttach = ((uint)(7));
		w15.XOptions = ((global::Gtk.AttachOptions)(4));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnDot = new global::Gtk.Button ();
		this.btnDot.CanFocus = true;
		this.btnDot.Name = "btnDot";
		this.btnDot.UseUnderline = true;
		this.btnDot.FocusOnClick = false;
		this.btnDot.Label = global::Mono.Unix.Catalog.GetString (".");
		this.table1.Add (this.btnDot);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnDot]));
		w16.TopAttach = ((uint)(4));
		w16.BottomAttach = ((uint)(5));
		w16.LeftAttach = ((uint)(4));
		w16.RightAttach = ((uint)(5));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnEquals = new global::Gtk.Button ();
		this.btnEquals.CanFocus = true;
		this.btnEquals.Name = "btnEquals";
		this.btnEquals.UseUnderline = true;
		this.btnEquals.FocusOnClick = false;
		this.btnEquals.Label = global::Mono.Unix.Catalog.GetString ("=");
		this.table1.Add (this.btnEquals);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnEquals]));
		w17.TopAttach = ((uint)(4));
		w17.BottomAttach = ((uint)(5));
		w17.LeftAttach = ((uint)(5));
		w17.RightAttach = ((uint)(6));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnFact = new global::Gtk.Button ();
		this.btnFact.CanFocus = true;
		this.btnFact.Name = "btnFact";
		this.btnFact.UseUnderline = true;
		this.btnFact.FocusOnClick = false;
		this.btnFact.Label = global::Mono.Unix.Catalog.GetString ("x!");
		this.table1.Add (this.btnFact);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnFact]));
		w18.TopAttach = ((uint)(4));
		w18.BottomAttach = ((uint)(5));
		w18.LeftAttach = ((uint)(2));
		w18.RightAttach = ((uint)(3));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnLeftPar = new global::Gtk.Button ();
		this.btnLeftPar.CanFocus = true;
		this.btnLeftPar.Name = "btnLeftPar";
		this.btnLeftPar.UseUnderline = true;
		this.btnLeftPar.FocusOnClick = false;
		this.btnLeftPar.Label = global::Mono.Unix.Catalog.GetString ("(");
		this.table1.Add (this.btnLeftPar);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnLeftPar]));
		w19.LeftAttach = ((uint)(3));
		w19.RightAttach = ((uint)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnLn = new global::Gtk.Button ();
		this.btnLn.CanFocus = true;
		this.btnLn.Name = "btnLn";
		this.btnLn.UseUnderline = true;
		this.btnLn.Label = global::Mono.Unix.Catalog.GetString ("ln");
		this.table1.Add (this.btnLn);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnLn]));
		w20.LeftAttach = ((uint)(1));
		w20.RightAttach = ((uint)(2));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnLog = new global::Gtk.Button ();
		this.btnLog.CanFocus = true;
		this.btnLog.Name = "btnLog";
		this.btnLog.UseUnderline = true;
		this.btnLog.FocusOnClick = false;
		this.btnLog.Label = global::Mono.Unix.Catalog.GetString ("log");
		this.table1.Add (this.btnLog);
		global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnLog]));
		w21.XOptions = ((global::Gtk.AttachOptions)(4));
		w21.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnMinus = new global::Gtk.Button ();
		this.btnMinus.CanFocus = true;
		this.btnMinus.Name = "btnMinus";
		this.btnMinus.UseUnderline = true;
		this.btnMinus.FocusOnClick = false;
		this.btnMinus.Label = global::Mono.Unix.Catalog.GetString ("-");
		this.table1.Add (this.btnMinus);
		global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnMinus]));
		w22.TopAttach = ((uint)(3));
		w22.BottomAttach = ((uint)(4));
		w22.LeftAttach = ((uint)(6));
		w22.RightAttach = ((uint)(7));
		w22.XOptions = ((global::Gtk.AttachOptions)(4));
		w22.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnMul = new global::Gtk.Button ();
		this.btnMul.CanFocus = true;
		this.btnMul.Name = "btnMul";
		this.btnMul.UseUnderline = true;
		this.btnMul.FocusOnClick = false;
		this.btnMul.Label = global::Mono.Unix.Catalog.GetString ("*");
		this.table1.Add (this.btnMul);
		global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnMul]));
		w23.TopAttach = ((uint)(2));
		w23.BottomAttach = ((uint)(3));
		w23.LeftAttach = ((uint)(6));
		w23.RightAttach = ((uint)(7));
		w23.XOptions = ((global::Gtk.AttachOptions)(4));
		w23.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum1 = new global::Gtk.Button ();
		this.btnNum1.CanFocus = true;
		this.btnNum1.Name = "btnNum1";
		this.btnNum1.UseUnderline = true;
		this.btnNum1.FocusOnClick = false;
		this.btnNum1.Label = global::Mono.Unix.Catalog.GetString ("1");
		this.table1.Add (this.btnNum1);
		global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum1]));
		w24.TopAttach = ((uint)(3));
		w24.BottomAttach = ((uint)(4));
		w24.LeftAttach = ((uint)(3));
		w24.RightAttach = ((uint)(4));
		w24.XOptions = ((global::Gtk.AttachOptions)(4));
		w24.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum2 = new global::Gtk.Button ();
		this.btnNum2.CanFocus = true;
		this.btnNum2.Name = "btnNum2";
		this.btnNum2.UseUnderline = true;
		this.btnNum2.FocusOnClick = false;
		this.btnNum2.Label = global::Mono.Unix.Catalog.GetString ("2");
		this.table1.Add (this.btnNum2);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum2]));
		w25.TopAttach = ((uint)(3));
		w25.BottomAttach = ((uint)(4));
		w25.LeftAttach = ((uint)(4));
		w25.RightAttach = ((uint)(5));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum3 = new global::Gtk.Button ();
		this.btnNum3.CanFocus = true;
		this.btnNum3.Name = "btnNum3";
		this.btnNum3.UseUnderline = true;
		this.btnNum3.FocusOnClick = false;
		this.btnNum3.Label = global::Mono.Unix.Catalog.GetString ("3");
		this.table1.Add (this.btnNum3);
		global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum3]));
		w26.TopAttach = ((uint)(3));
		w26.BottomAttach = ((uint)(4));
		w26.LeftAttach = ((uint)(5));
		w26.RightAttach = ((uint)(6));
		w26.XOptions = ((global::Gtk.AttachOptions)(4));
		w26.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum4 = new global::Gtk.Button ();
		this.btnNum4.CanFocus = true;
		this.btnNum4.Name = "btnNum4";
		this.btnNum4.UseUnderline = true;
		this.btnNum4.FocusOnClick = false;
		this.btnNum4.Label = global::Mono.Unix.Catalog.GetString ("4");
		this.table1.Add (this.btnNum4);
		global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum4]));
		w27.TopAttach = ((uint)(2));
		w27.BottomAttach = ((uint)(3));
		w27.LeftAttach = ((uint)(3));
		w27.RightAttach = ((uint)(4));
		w27.XOptions = ((global::Gtk.AttachOptions)(4));
		w27.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum5 = new global::Gtk.Button ();
		this.btnNum5.CanFocus = true;
		this.btnNum5.Name = "btnNum5";
		this.btnNum5.UseUnderline = true;
		this.btnNum5.FocusOnClick = false;
		this.btnNum5.Label = global::Mono.Unix.Catalog.GetString ("5");
		this.table1.Add (this.btnNum5);
		global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum5]));
		w28.TopAttach = ((uint)(2));
		w28.BottomAttach = ((uint)(3));
		w28.LeftAttach = ((uint)(4));
		w28.RightAttach = ((uint)(5));
		w28.XOptions = ((global::Gtk.AttachOptions)(4));
		w28.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum6 = new global::Gtk.Button ();
		this.btnNum6.CanFocus = true;
		this.btnNum6.Name = "btnNum6";
		this.btnNum6.UseUnderline = true;
		this.btnNum6.FocusOnClick = false;
		this.btnNum6.Label = global::Mono.Unix.Catalog.GetString ("6");
		this.table1.Add (this.btnNum6);
		global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum6]));
		w29.TopAttach = ((uint)(2));
		w29.BottomAttach = ((uint)(3));
		w29.LeftAttach = ((uint)(5));
		w29.RightAttach = ((uint)(6));
		w29.XOptions = ((global::Gtk.AttachOptions)(4));
		w29.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum7 = new global::Gtk.Button ();
		this.btnNum7.CanFocus = true;
		this.btnNum7.Name = "btnNum7";
		this.btnNum7.UseUnderline = true;
		this.btnNum7.FocusOnClick = false;
		this.btnNum7.Label = global::Mono.Unix.Catalog.GetString ("7");
		this.table1.Add (this.btnNum7);
		global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum7]));
		w30.TopAttach = ((uint)(1));
		w30.BottomAttach = ((uint)(2));
		w30.LeftAttach = ((uint)(3));
		w30.RightAttach = ((uint)(4));
		w30.XOptions = ((global::Gtk.AttachOptions)(4));
		w30.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum8 = new global::Gtk.Button ();
		this.btnNum8.CanFocus = true;
		this.btnNum8.Name = "btnNum8";
		this.btnNum8.UseUnderline = true;
		this.btnNum8.FocusOnClick = false;
		this.btnNum8.Label = global::Mono.Unix.Catalog.GetString ("8");
		this.table1.Add (this.btnNum8);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum8]));
		w31.TopAttach = ((uint)(1));
		w31.BottomAttach = ((uint)(2));
		w31.LeftAttach = ((uint)(4));
		w31.RightAttach = ((uint)(5));
		w31.XOptions = ((global::Gtk.AttachOptions)(4));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNum9 = new global::Gtk.Button ();
		this.btnNum9.CanFocus = true;
		this.btnNum9.Name = "btnNum9";
		this.btnNum9.UseUnderline = true;
		this.btnNum9.FocusOnClick = false;
		this.btnNum9.Label = global::Mono.Unix.Catalog.GetString ("9");
		this.table1.Add (this.btnNum9);
		global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNum9]));
		w32.TopAttach = ((uint)(1));
		w32.BottomAttach = ((uint)(2));
		w32.LeftAttach = ((uint)(5));
		w32.RightAttach = ((uint)(6));
		w32.XOptions = ((global::Gtk.AttachOptions)(4));
		w32.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnNumZero = new global::Gtk.Button ();
		this.btnNumZero.CanFocus = true;
		this.btnNumZero.Name = "btnNumZero";
		this.btnNumZero.UseUnderline = true;
		this.btnNumZero.FocusOnClick = false;
		this.btnNumZero.Label = global::Mono.Unix.Catalog.GetString ("0");
		this.table1.Add (this.btnNumZero);
		global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnNumZero]));
		w33.TopAttach = ((uint)(4));
		w33.BottomAttach = ((uint)(5));
		w33.LeftAttach = ((uint)(3));
		w33.RightAttach = ((uint)(4));
		w33.XOptions = ((global::Gtk.AttachOptions)(4));
		w33.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnPerc = new global::Gtk.Button ();
		this.btnPerc.CanFocus = true;
		this.btnPerc.Name = "btnPerc";
		this.btnPerc.UseUnderline = true;
		this.btnPerc.FocusOnClick = false;
		this.btnPerc.Label = global::Mono.Unix.Catalog.GetString ("%");
		this.table1.Add (this.btnPerc);
		global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnPerc]));
		w34.LeftAttach = ((uint)(5));
		w34.RightAttach = ((uint)(6));
		w34.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnPi = new global::Gtk.Button ();
		this.btnPi.CanFocus = true;
		this.btnPi.Name = "btnPi";
		this.btnPi.UseUnderline = true;
		this.btnPi.FocusOnClick = false;
		this.btnPi.Label = global::Mono.Unix.Catalog.GetString ("π");
		this.table1.Add (this.btnPi);
		global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnPi]));
		w35.TopAttach = ((uint)(4));
		w35.BottomAttach = ((uint)(5));
		w35.LeftAttach = ((uint)(1));
		w35.RightAttach = ((uint)(2));
		w35.XOptions = ((global::Gtk.AttachOptions)(4));
		w35.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnPlus = new global::Gtk.Button ();
		this.btnPlus.CanFocus = true;
		this.btnPlus.Name = "btnPlus";
		this.btnPlus.UseUnderline = true;
		this.btnPlus.FocusOnClick = false;
		this.btnPlus.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.table1.Add (this.btnPlus);
		global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnPlus]));
		w36.TopAttach = ((uint)(4));
		w36.BottomAttach = ((uint)(5));
		w36.LeftAttach = ((uint)(6));
		w36.RightAttach = ((uint)(7));
		w36.XOptions = ((global::Gtk.AttachOptions)(4));
		w36.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnRightPar = new global::Gtk.Button ();
		this.btnRightPar.CanFocus = true;
		this.btnRightPar.Name = "btnRightPar";
		this.btnRightPar.UseUnderline = true;
		this.btnRightPar.FocusOnClick = false;
		this.btnRightPar.Label = global::Mono.Unix.Catalog.GetString (")");
		this.table1.Add (this.btnRightPar);
		global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnRightPar]));
		w37.LeftAttach = ((uint)(4));
		w37.RightAttach = ((uint)(5));
		w37.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnSin = new global::Gtk.Button ();
		this.btnSin.CanFocus = true;
		this.btnSin.Name = "btnSin";
		this.btnSin.UseUnderline = true;
		this.btnSin.FocusOnClick = false;
		this.btnSin.Label = global::Mono.Unix.Catalog.GetString ("sin");
		this.table1.Add (this.btnSin);
		global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnSin]));
		w38.TopAttach = ((uint)(1));
		w38.BottomAttach = ((uint)(2));
		w38.XOptions = ((global::Gtk.AttachOptions)(4));
		w38.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnSinMinus = new global::Gtk.Button ();
		this.btnSinMinus.CanFocus = true;
		this.btnSinMinus.Name = "btnSinMinus";
		this.btnSinMinus.UseUnderline = true;
		this.btnSinMinus.Label = global::Mono.Unix.Catalog.GetString ("sin-1");
		this.table1.Add (this.btnSinMinus);
		global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnSinMinus]));
		w39.TopAttach = ((uint)(2));
		w39.BottomAttach = ((uint)(3));
		w39.XOptions = ((global::Gtk.AttachOptions)(4));
		w39.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnSqr = new global::Gtk.Button ();
		this.btnSqr.CanFocus = true;
		this.btnSqr.Name = "btnSqr";
		this.btnSqr.UseUnderline = true;
		this.btnSqr.FocusOnClick = false;
		this.btnSqr.Label = global::Mono.Unix.Catalog.GetString ("√");
		this.table1.Add (this.btnSqr);
		global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnSqr]));
		w40.TopAttach = ((uint)(3));
		w40.BottomAttach = ((uint)(4));
		w40.LeftAttach = ((uint)(2));
		w40.RightAttach = ((uint)(3));
		w40.XOptions = ((global::Gtk.AttachOptions)(4));
		w40.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnTan = new global::Gtk.Button ();
		this.btnTan.CanFocus = true;
		this.btnTan.Name = "btnTan";
		this.btnTan.UseUnderline = true;
		this.btnTan.FocusOnClick = false;
		this.btnTan.Label = global::Mono.Unix.Catalog.GetString ("tan");
		this.table1.Add (this.btnTan);
		global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnTan]));
		w41.TopAttach = ((uint)(1));
		w41.BottomAttach = ((uint)(2));
		w41.LeftAttach = ((uint)(2));
		w41.RightAttach = ((uint)(3));
		w41.XOptions = ((global::Gtk.AttachOptions)(4));
		w41.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnTanMinus = new global::Gtk.Button ();
		this.btnTanMinus.CanFocus = true;
		this.btnTanMinus.Name = "btnTanMinus";
		this.btnTanMinus.UseUnderline = true;
		this.btnTanMinus.Label = global::Mono.Unix.Catalog.GetString ("tan-1");
		this.table1.Add (this.btnTanMinus);
		global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnTanMinus]));
		w42.TopAttach = ((uint)(2));
		w42.BottomAttach = ((uint)(3));
		w42.LeftAttach = ((uint)(2));
		w42.RightAttach = ((uint)(3));
		w42.XOptions = ((global::Gtk.AttachOptions)(4));
		w42.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnX2 = new global::Gtk.Button ();
		this.btnX2.CanFocus = true;
		this.btnX2.Name = "btnX2";
		this.btnX2.UseUnderline = true;
		this.btnX2.FocusOnClick = false;
		this.btnX2.Label = global::Mono.Unix.Catalog.GetString ("x^2");
		this.table1.Add (this.btnX2);
		global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnX2]));
		w43.TopAttach = ((uint)(3));
		w43.BottomAttach = ((uint)(4));
		w43.LeftAttach = ((uint)(1));
		w43.RightAttach = ((uint)(2));
		w43.XOptions = ((global::Gtk.AttachOptions)(4));
		w43.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.btnX3 = new global::Gtk.Button ();
		this.btnX3.CanFocus = true;
		this.btnX3.Name = "btnX3";
		this.btnX3.UseUnderline = true;
		this.btnX3.FocusOnClick = false;
		this.btnX3.Label = global::Mono.Unix.Catalog.GetString ("x^3");
		this.table1.Add (this.btnX3);
		global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnX3]));
		w44.TopAttach = ((uint)(3));
		w44.BottomAttach = ((uint)(4));
		w44.XOptions = ((global::Gtk.AttachOptions)(4));
		w44.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.clearBtn = new global::Gtk.Button ();
		this.clearBtn.CanFocus = true;
		this.clearBtn.Name = "clearBtn";
		this.clearBtn.UseUnderline = true;
		this.clearBtn.FocusOnClick = false;
		this.clearBtn.Label = global::Mono.Unix.Catalog.GetString ("CLEAR");
		this.table1.Add (this.clearBtn);
		global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1 [this.clearBtn]));
		w45.LeftAttach = ((uint)(6));
		w45.RightAttach = ((uint)(7));
		w45.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.eventbox2 = new global::Gtk.EventBox ();
		this.eventbox2.Name = "eventbox2";
		// Container child eventbox2.Gtk.Container+ContainerChild
		this.btnXY = new global::Gtk.Button ();
		this.btnXY.CanFocus = true;
		this.btnXY.Name = "btnXY";
		this.btnXY.UseUnderline = true;
		this.btnXY.FocusOnClick = false;
		this.btnXY.Label = global::Mono.Unix.Catalog.GetString ("x^y");
		this.eventbox2.Add (this.btnXY);
		this.table1.Add (this.eventbox2);
		global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table1 [this.eventbox2]));
		w47.TopAttach = ((uint)(4));
		w47.BottomAttach = ((uint)(5));
		w47.XOptions = ((global::Gtk.AttachOptions)(4));
		w47.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w48.Position = 2;
		w48.Expand = false;
		w48.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 512;
		this.DefaultHeight = 354;
		this.textview1.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.textview1.InsertAtCursor += new global::Gtk.InsertAtCursorHandler (this.OnTextview1InsertAtCursor);
		this.btnOn2.Clicked += new global::System.EventHandler (this.OnBtnOn2Clicked);
		this.btnOff2.Clicked += new global::System.EventHandler (this.OnBtnOff2Clicked);
		this.btnXY.Clicked += new global::System.EventHandler (this.OnBtnXYClicked);
		this.clearBtn.Clicked += new global::System.EventHandler (this.OnClearBtnClicked);
		this.btnX3.Clicked += new global::System.EventHandler (this.OnBtnX3Clicked);
		this.btnX2.Clicked += new global::System.EventHandler (this.OnBtnX2Clicked);
		this.btnSqr.Clicked += new global::System.EventHandler (this.OnBtnSqrClicked);
		this.btnSinMinus.Clicked += new global::System.EventHandler (this.OnBtnSinMinusClicked);
		this.btnPlus.Clicked += new global::System.EventHandler (this.OnBtnPlusClicked);
		this.btnPi.Clicked += new global::System.EventHandler (this.OnBtnPiClicked);
		this.btnPerc.Clicked += new global::System.EventHandler (this.OnBtnPercClicked);
		this.btnNumZero.Clicked += new global::System.EventHandler (this.OnBtnNumZeroClicked);
		this.btnNum9.Clicked += new global::System.EventHandler (this.OnBtnNum9Clicked);
		this.btnNum8.Clicked += new global::System.EventHandler (this.OnBtnNum8Clicked);
		this.btnNum7.Clicked += new global::System.EventHandler (this.OnBtnNum7Clicked);
		this.btnNum6.Clicked += new global::System.EventHandler (this.OnBtnNum6Clicked);
		this.btnNum5.Clicked += new global::System.EventHandler (this.OnBtnNum5Clicked);
		this.btnNum4.Clicked += new global::System.EventHandler (this.OnBtnNum4Clicked);
		this.btnNum3.Clicked += new global::System.EventHandler (this.OnBtnNum3Clicked);
		this.btnNum2.Clicked += new global::System.EventHandler (this.OnBtnNum2Clicked);
		this.btnNum1.Clicked += new global::System.EventHandler (this.OnBtnNum1Clicked);
		this.btnMul.Clicked += new global::System.EventHandler (this.OnBtnMulClicked);
		this.btnMinus.Clicked += new global::System.EventHandler (this.OnBtnMinusClicked);
		this.btnLog.Clicked += new global::System.EventHandler (this.OnBtnLogClicked);
		this.btnLn.Clicked += new global::System.EventHandler (this.OnBtnLnClicked);
		this.btnFact.Clicked += new global::System.EventHandler (this.OnBtnFactClicked);
		this.btnEquals.Clicked += new global::System.EventHandler (this.OnBtnEqualsClicked);
		this.btnDot.Clicked += new global::System.EventHandler (this.OnBtnDotClicked);
		this.btnDiv.Clicked += new global::System.EventHandler (this.OnBtnDivClicked);
		this.btnDel.Clicked += new global::System.EventHandler (this.OnBtnDelClicked);
	}
}
