using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTablasdemultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero,resultado;
            Console.WriteLine("Ingrese un valor numerico");
  numero=int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
            {
                resultado=numero*i;
            Console.WriteLine(numero+"x"+i+"="+resultado );
            }
            Console.ReadLine();
        }
    }
}
