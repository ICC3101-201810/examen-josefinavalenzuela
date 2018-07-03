using System;
using System.Windows;
using Gtk;
using System.IO;

using System.Collections.Generic;
using Examen;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

	protected void OnIngresarClicked(object sender, EventArgs e)
	{
		SecondWindow secondWindow = new SecondWindow();
		this.Destroy();
		secondWindow.Show();
        
	}
}
