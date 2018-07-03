using System;
using Gtk;
using System.Collections.Generic;

namespace Examen
{
	delegate void fantasmas(List<Label> posiciones);
    //Hice tanto a los pacman como a los fantasmas y frutas como texto, ya que no logré ingresar las imagenes en el programa mediante GTK
   //Los métodos de movimiento se encuentran en la clase LL, no pude utilizar los metodos propuestos en los tips, ya que el computador no me los reconcía
    //Si bien no pude imprementar los movimientos, logre realizar que estos cambiaran en la clase LL.
    public partial class SecondWindow : Gtk.Window
    {

		public List<Label> posiciones = new List<Label>();
		LL lL = new LL(0);

        public SecondWindow() :
                base(Gtk.WindowType.Toplevel)
        {
            

			posiciones.Add(t11);
            posiciones.Add(t12);
            posiciones.Add(t13);
            posiciones.Add(t14);
            posiciones.Add(t15);
            posiciones.Add(t16);
            posiciones.Add(t21);
            posiciones.Add(t22);
            posiciones.Add(t23);
            posiciones.Add(t24);
            posiciones.Add(t25);
            posiciones.Add(t26);
            posiciones.Add(t31);
            posiciones.Add(t32);
			posiciones.Add(t33);
			posiciones.Add(t34);
            posiciones.Add(t35);
            posiciones.Add(t36);
            posiciones.Add(t41);
            posiciones.Add(t42);
			posiciones.Add(t43);
			posiciones.Add(t44);
            posiciones.Add(t45);
            posiciones.Add(t46);
            posiciones.Add(t51);
            posiciones.Add(t52);
            posiciones.Add(t53);
            posiciones.Add(t54);
            posiciones.Add(t55);
            posiciones.Add(t56);
            posiciones.Add(t61);
            posiciones.Add(t62);
            posiciones.Add(t63);
            posiciones.Add(t64);
            posiciones.Add(t65);
            posiciones.Add(t66);

			//lL.Inicio(posiciones, "fantasma rosado");
			//lL.Inicio(posiciones, "fantasma rojo");
			//lL.Inicio(posiciones, "guinda");
			//lL.Inicio(posiciones, "uva");
			this.Build();
			//Ll.MovimientoPacman(posiciones, movimiento);
			//lL.Perseguir(posiciones);
			//Ll.MovimientoPacman(posiciones, movimiento);
			//Build();

            
        }
        
    }





}
