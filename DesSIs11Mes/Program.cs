using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSIs11Mes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "Inexistente", "Jan", "Fev", "Mar", "Abr","Mai","jun","jul","Ago","Set","Out","Nov","Dez" };
            Console.WriteLine("Informe um numero de 1 a 12: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("O mês que selecionou foi: "+ mes[i] );   


            Console.ReadKey();
        }
    }
}
