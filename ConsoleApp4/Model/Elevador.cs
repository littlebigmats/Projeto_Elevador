using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4.Model
{
    internal class Elevador
    {
        public int andarterreo;
        public int andaratual;

        public int Id { get; set; }
        public int Capacidade { get; set; }
        public int TotalAndar { get; set; }
        public int andardatual { get; set; }
        public int andardesejado { get; set; }

        public static void Inicializar()
        {      
            Console.WriteLine(@"Chamando o Elevador!");
            
        }
        public static void Error()
        {
            Console.WriteLine("A capacidade máxima do elevador foi superada");
        }

        internal static void Error2()
        {
            Console.WriteLine("Digite um andar válido"); 
             
        }

        internal static void Entrar()
        {
            Console.WriteLine("Favor entrar!");
        }

      

        internal static void Descer()
        {
            Console.WriteLine("Estamos descendo!");
        }

        internal static void Subir()
        {
            Console.WriteLine("Estamos Subindo!");
        }

        internal static void Sair()
        {
            Console.WriteLine("Chegamos! Favor sair!");
        }
    }
}
