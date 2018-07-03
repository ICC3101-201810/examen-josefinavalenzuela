using System;
namespace Examen
{
    public partial class SecondWindow : Gtk.Window
    {
        public SecondWindow() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
