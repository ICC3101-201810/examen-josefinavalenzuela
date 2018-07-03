using System;
using Gtk;
using System.Collections.Generic;

namespace Examen
{
    public class LL
    {
		int score;
		public LL(int S)
        {
			score = S;
        }

        //Posciones fantasmas y frutas de manera aleatoria al iniciar el programa
		public List<Label> Inicio(List<Label> posiciones, string Fantasma)
        {
			Random rnd = new Random();
			int random1 = rnd.Next(1,6);
			int random2 = rnd.Next(1,6);


			string nombre = "t" + (random1).ToString() + random2.ToString();
			while ((random1 == 3 && (random2 == 3 || random2 == 4)) || (random1 == 4 && (random2 == 3 || random2 == 4))  ) 
			{
				random1 = rnd.Next(1, 6);
                random2 = rnd.Next(1, 6);

                
                nombre = "t" + (random1).ToString() + random2.ToString();	
			}
            foreach (Label i in posiciones)
            {
                if (i.Name == nombre)
                {
					if(i.Text == "")
					{
						i.Text = Fantasma;

					}

					else
					{
						random1 = rnd.Next(1, 6);
                        random2 = rnd.Next(1, 6);
					}
                }
             
            }
			return posiciones;

        }

		public List<Label> Perseguir(List<Label> posiciones)
		{
			Label pacman;
		
			string objetivo = "";
			foreach (Label i in posiciones)
			{
				if (i.Text == "pacman")
				{
					pacman = i;
					objetivo = i.Name;

				}
			}

            //La primera opcion de movimiento es moverse dentro de su columna
            //Si el pacman se encuentra en su misma columna, entonces se mueve dentro de su fila
			foreach (Label i in posiciones)
			{
				if (i.Text == "fantasma rosado")
                {
					if (objetivo[1] > i.Name[1])
					{
						i.Text = "";

						foreach (Label i2 in posiciones)
						{
							if("t" + (i.Name[1] + 1).ToString() + i.Name[2].ToString() == i2.Name)
							{
								i2.Text = "fantasma rosado";
							}
 
						}
					}

					else if (objetivo[2] < i.Name[1])
					{
						i.Text = "";

                        foreach (Label i2 in posiciones)
                        {
                            if ("t" + (i.Name[1] - 1).ToString() + i.Name[2].ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rosado";
                            }

                        }
					}

					else if(objetivo[2] > i.Name[2])
					{
						i.Text = "";
						foreach (Label i2 in posiciones)
                        {
							if ("t" + (i.Name[1]).ToString() + (i.Name[2] +1).ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rosado";
                            }

                        }
					}

					else if (objetivo[2] < i.Name[2])
                    {
                        i.Text = "";

                        foreach (Label i2 in posiciones)
                        {
							if ("t" + (i.Name[1]).ToString() + (i.Name[2]-1).ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rosado";
                            }

                        }
                    }

                }

                if (i.Text == "fantasma rojo")
				{
                    if (objetivo[1] > i.Name[1])
                    {
                        i.Text = "";

                        foreach (Label i2 in posiciones)
                        {
                            if ("t" + (i.Name[1] + 1).ToString() + i.Name[2].ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rojo";
                            }

                        }
                    }

                    else if (objetivo[2] < i.Name[1])
                    {
                        i.Text = "";

                        foreach (Label i2 in posiciones)
                        {
                            if ("t" + (i.Name[1] - 1).ToString() + i.Name[2].ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rojo";
                            }

                        }
                    }

                    else if (objetivo[2] > i.Name[2])
                    {
                        i.Text = "";
                        foreach (Label i2 in posiciones)
                        {
                            if ("t" + (i.Name[1]).ToString() + (i.Name[2] + 1).ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rojo";
                            }

                        }
                    }

                    else if (objetivo[2] < i.Name[2])
                    {
                        i.Text = "";

                        foreach (Label i2 in posiciones)
                        {
                            if ("t" + (i.Name[1]).ToString() + (i.Name[2] - 1).ToString() == i2.Name)
                            {
                                i2.Text = "fantasma rojo";
                            }
                            
                        }
                    }

                }
			}
			return posiciones;
                     
		}
		//Recibe como parametro el movimiento del usuario (1 = Izquierda, 2 = Derecha, 3 = Arriba, 4 = Abajo)
		public List<Label> MovimientoPacman(List<Label> posiciones, int movimiento)
		
		{
			string lugar = "";

			foreach(Label l in posiciones)
			{
				if (l.Text == "pacman")
				{
					if (movimiento == 1 && ((Convert.ToInt32(l.Name[2])> 1 && (Convert.ToInt32(l.Name[2]) < 6))))
					{
						
						lugar = "t" + l.Name[1] + ((Convert.ToInt32(l.Name[2]) - 1).ToString());

                        
					}

					else if (movimiento == 2 && ((Convert.ToInt32(l.Name[2]) > 1 && (Convert.ToInt32(l.Name[2]) < 6))))
                    {
                        lugar = "t" + l.Name[1] + ((Convert.ToInt32(l.Name[2]) + 1).ToString());


                    }

					else if (movimiento == 3 && ((Convert.ToInt32(l.Name[1]) > 1 && (Convert.ToInt32(l.Name[1]) < 6))))
                    {
						lugar = "t" + ((Convert.ToInt32(l.Name[1]) + 1).ToString()) + l.Name[2];

                        
                    }

					else if (movimiento == 4 && ((Convert.ToInt32(l.Name[1]) > 1 && (Convert.ToInt32(l.Name[1]) < 6))))
                    {
                        lugar = "t" + ((Convert.ToInt32(l.Name[1]) - 1).ToString()) + l.Name[2];

                        
                    }
				}

				foreach(Label l2 in posiciones)
				{
					if(l2.Name == lugar)
					{
						if (l2.Text == "uva")
						{
							score += 15;
                            //Vuelvo a posiciones la uva
							posiciones = Inicio(posiciones, "uva");

						}

						if (l2.Text == "guinda")
                        {
                            score += 10;
                            //Vuelvo a posiciones la guinda
                            posiciones = Inicio(posiciones, "guinda");

                        }

						else if (l2.Text == "fantasma rosado" || l2.Text == "fantasma rojo")
                        {
                            Label perdiste = new Label();
                            List<Label> perdistee = new List<Label>();
                            perdistee.Add(perdiste);

                            //Se recorre la lista en SecondWindow y se nota que esta posee un único Label.
                            return perdistee;
                        }

						l2.Text = "pacman";
					}
				}
			}

			return posiciones;
		}



    }
}
