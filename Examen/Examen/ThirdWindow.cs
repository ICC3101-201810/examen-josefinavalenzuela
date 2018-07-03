using System;
namespace Examen
{
    public partial class ThirdWindow : Gtk.Window
    {
        public ThirdWindow() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
