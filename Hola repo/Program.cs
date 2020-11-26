using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_repo
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2, resultado;
            Console.WriteLine("hola mundo");
            Console.WriteLine("hola amigos"); 
            Console.WriteLine("como estan");
            //codigo que suma dos numeros 
            Console.WriteLine("suma de dos numeros");
            Console.WriteLine("primer numero:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo muero:");
            numero2 = int.Parse(Console.ReadLine());
           
            
           
            resultado = numero1 + numero2;
            Console.WriteLine("el resultado es  " + resultado);











            Console.ReadKey();
        }
    }
}
