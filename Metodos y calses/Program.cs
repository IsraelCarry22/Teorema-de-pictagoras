using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Metodos_y_calses
{
    class triangulo_rectangulo
    {
        static void Main(string[] args)
        {

            bool final = false;
            double cateto_OP;
            double cateto_AD;
            double Hip;
            int val;

            triangulo_rectangulo TR;
            TR = new triangulo_rectangulo();

            while (!final)
            {
                Console.Clear();
                Console.WriteLine("//Teorema de pictagoras, area y preimetro//\n");

                Console.WriteLine("/Elige una Opcion/\n[1]Calculo Area.\n[2]Calculo Perimetro.\n[3]Calculo Cateto Opuesto.\n[4]Calculo Cateto Adyacente.\n[5]Calculo Hipotenusa.\n[6]Salir");
                val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Cateto Adyacente: ");
                        cateto_AD = double.Parse(Console.ReadLine());
                        Console.Write("Cateto Opuesto: ");
                        cateto_OP = double.Parse(Console.ReadLine());

                        Console.WriteLine("Area del triangulo es: " + TR.teorema_pictagoras(cateto_OP,cateto_AD));
                        Console.WriteLine("Pulsa cualquier tecla para continuar...");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Cateto Adyacente: ");
                        cateto_AD = double.Parse(Console.ReadLine());
                        Console.Write("Cateto Opuesto: ");
                        cateto_OP = double.Parse(Console.ReadLine());
                        Console.Write("Hipotenusa: ");
                        Hip = double.Parse(Console.ReadLine());

                        Console.WriteLine("Area del triangulo es: " + TR.teorema_pictagoras(cateto_OP,cateto_AD,Hip));
                        Console.WriteLine("Pulsa cualquier tecla para continuar...");
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Cateto Adyacente: ");
                        cateto_AD = double.Parse(Console.ReadLine());
                        Console.Write("Hipotenusa: ");
                        Hip = double.Parse(Console.ReadLine());

                        Console.WriteLine("Cateto Opuesto es: " + TR.Cal_Cateto_Opuesto(cateto_AD,Hip));
                        Console.WriteLine("Pulsa cualquier tecla para continuar...");
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Cateto Opuesto: ");
                        cateto_OP = double.Parse(Console.ReadLine());
                        Console.Write("Hipotenusa: ");
                        Hip = double.Parse(Console.ReadLine());

                        Console.WriteLine("Cateto Adyacente es: " + TR.Cal_Cateto_Adyacente(cateto_OP, Hip));
                        Console.WriteLine("Pulsa cualquier tecla para continuar...");
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Cateto Adyacente: ");
                        cateto_AD = double.Parse(Console.ReadLine());
                        Console.Write("Cateto Opuesto: ");
                        cateto_OP = double.Parse(Console.ReadLine());

                        Console.WriteLine("Hipotenusa es: " + TR.Cal_Hipotenusa(cateto_OP, cateto_AD));
                        Console.WriteLine("Pulsa cualquier tecla para continuar...");
                        break;
                    case 6:
                        Console.Clear();
                        final = true;
                        Console.WriteLine("Adios :)");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Valor invalido o fuera de rango...");
                        break;
                }
                Console.ReadKey();
            }
        }

        public double teorema_pictagoras(double Cateto_Opuesto, double Cateto_Adyacente)
        {
            return (Cateto_Adyacente * Cateto_Opuesto / 2);
        }

        public double teorema_pictagoras(double Cateto_Opuesto, double Cateto_Adyacente, double Hipotenusa)
        {
            return (Cateto_Adyacente + Cateto_Opuesto + Hipotenusa);
        }

        public double Cal_Hipotenusa(double Cateto_Opuesto, double Cateto_Adyacente)
        {
            return Math.Sqrt(Math.Pow(Cateto_Opuesto, 2) + Math.Pow(Cateto_Adyacente, 2));
        }

        public double Cal_Cateto_Opuesto(double Cateto_Adyacente, double Hipotenusa)
        {
            return Math.Sqrt(Math.Pow(Cateto_Adyacente, 2) - Math.Pow(Hipotenusa, 2));
        }

        public double Cal_Cateto_Adyacente(double Cateto_Opuesto, double Hipotenusa)
        {
            return Math.Sqrt(Math.Pow(Cateto_Opuesto, 2) - Math.Pow(Hipotenusa, 2));
        }

    }
}
