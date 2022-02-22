using System;

namespace punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valcomp = 0, pdes = 0;
            double valpag;
            Console.WriteLine("Ingrese color del producto");
            String color = Console.ReadLine();
            Console.WriteLine("Ingrese precio producto ");
            valcomp = int.Parse(Console.ReadLine());
            if(color == "blanco")
            {
                pdes = 0;
            }
            else
            {
                if(color == "verde")
                {
                    pdes = 10;
                }
                else
                {
                    if(color == "amarillo")
                    {
                        pdes = 25;
                    }
                    else
                    {
                        if(color == "azul")
                        {
                            pdes = 50;
                        }
                        else
                        {
                            pdes = 100;
                        }
                    }
                }
            }
                
            valpag = valcomp - pdes * valcomp / 100;
            Console.WriteLine("el cliente debe pagar: $" + valpag);
        }
    }
}
