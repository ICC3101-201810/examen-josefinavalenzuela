
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table table3;

	private global::Gtk.Button ingresar;

	private global::Gtk.Label label1;

	private global::Gtk.Label label19;

	private global::Gtk.Entry usuario;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table3 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.ingresar = new global::Gtk.Button();
		this.ingresar.CanFocus = true;
		this.ingresar.Name = "ingresar";
		this.ingresar.UseUnderline = true;
		this.ingresar.Label = global::Mono.Unix.Catalog.GetString("ingresar");
		this.table3.Add(this.ingresar);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.ingresar]));
		w1.TopAttach = ((uint)(1));
		w1.BottomAttach = ((uint)(2));
		w1.LeftAttach = ((uint)(2));
		w1.RightAttach = ((uint)(3));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Ingrese su nombre");
		this.table3.Add(this.label1);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.label1]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label19 = new global::Gtk.Label();
		this.label19.Name = "label19";
		this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Bienvenido!");
		this.table3.Add(this.label19);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.label19]));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.usuario = new global::Gtk.Entry();
		this.usuario.CanFocus = true;
		this.usuario.Name = "usuario";
		this.usuario.IsEditable = true;
		this.usuario.InvisibleChar = '●';
		this.table3.Add(this.usuario);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.usuario]));
		w4.TopAttach = ((uint)(1));
		w4.BottomAttach = ((uint)(2));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add(this.table3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ingresar.Clicked += new global::System.EventHandler(this.OnIngresarClicked);
	}
}