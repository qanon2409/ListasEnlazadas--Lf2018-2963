using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseAlg275
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            /*LinkedList<string> nomEstud = new LinkedList<string>();
            bool z=true;
            while(z)
            {
                Console.WriteLine("1. Agreguese a la lista");
                Console.WriteLine("2. Eliminese de la lista");
                Console.WriteLine("3. Confirmar existencia en la lista");
                Console.WriteLine("4. Mover posicion en lista");
                Console.WriteLine("5. Mostar todo");
                Console.WriteLine("6. Salir");


                switch (Convert.ToInt32(Console.ReadLine()))
                {
                                    

                    case 1:
                        {
                            Console.WriteLine("Escriba su nombre");
                            string b = Console.ReadLine();
                            nomEstud.AddLast(b);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Escriba su nombre");
                            string c = Console.ReadLine();
                            nomEstud.Remove(c);
                            Console.WriteLine("Usted ha sido removido con exito!");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Escriba su nombre");
                            string d = Console.ReadLine();
                            nomEstud.Contains(d);
                            if(nomEstud.Contains(d))
                            {
                                Console.WriteLine("Usted esta en la lista!");

                            }
                            else
                            {
                                Console.WriteLine("Usted debe inscribirse en la lista!");
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Escriba como quiere ser movido");
                            Console.WriteLine("1. Ultimo");
                            Console.WriteLine("2. Primero");

                            

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Escriba su nombre");
                                        string b2 = Console.ReadLine();
                                        var b3 = nomEstud.Find(b2);
                                        var b4 = nomEstud.Find(nomEstud.Last.Value);
                                        nomEstud.AddAfter(b4, b2);
                                        nomEstud.Remove(b3);
                                        Mostrar();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Escriba su nombre");
                                        string b2 = Console.ReadLine();
                                        var b3 = nomEstud.Find(b2);
                                        var b4 = nomEstud.Find(nomEstud.First.Value);
                                        nomEstud.AddBefore(b4, b2);
                                        nomEstud.Remove(b3);
                                        Mostrar();
                                        break;
                                    }
                            }
                            //Mover();
                            

                            break;
                        }


                    case 5:
                        {
                            foreach(string s in nomEstud)
                            {
                                Console.WriteLine(s);
                            }
                            Console.ReadKey();
                            break;
                        }

                    case 6:
                        {
                            z = false;
                            break;
                        }


                }

                




            }



            void Mostrar()
            {
                foreach (string s in nomEstud)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
                
            }

           



            //Agregar elementos a la lista
            /*var valor = materias.AddFirst("Matematicas");
            materias.AddBefore(valor, "Contabilidad I");
            materias.AddLast("Informatica I");
            materias.AddLast("Mercadotecnia II");
            materias.AddLast("Programacion Basica");
            materias.AddLast("Programacion Avanzada");

            //Recorrer
            foreach(string s in materias)
            {
                Console.WriteLine("Asignatura: "+s);
            }
            Console.ReadKey();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
