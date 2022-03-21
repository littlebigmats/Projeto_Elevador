using ConsoleApp4.Model;
using System;

namespace ConsoleApp4
{
    internal class Program
    {
        private static int andardatual;
        private static int andardesejado;

        public static int andarterreo { get; set; }
        public static int andaratual { get; set; }

        static void Main(string[] args)
        {
            Model.Elevador elevador = new Model.Elevador();
            elevador.Id = 1;
            elevador.Capacidade = 4;
            elevador.TotalAndar = 8;
            elevador.andarterreo = 0;

            // Favor comunicar aqui o Andar Atual e o Andar Desejado ANTES de iniciar o programa com CTRL F5.

            elevador.andaratual = 2;
            elevador.andardesejado = 5;


            bool continuar = true;
            int entrando = 0;

            Console.Clear();

            do
            {
                Console.WriteLine(@"Olá! Bem-vindo ao elevador {0}, 
favor selecionar o andar atual, o andar desejado e a quantidade de pessoas entrando ", elevador.Id);
                elevador.andardatual = int.Parse(Console.ReadLine());
                elevador.andardesejado = int.Parse(Console.ReadLine());
                entrando = int.Parse(Console.ReadLine());


                if (entrando > elevador.Capacidade)
                {
                    Elevador.Error();
                }
                else if (elevador.andardesejado > elevador.TotalAndar)
                {
                    Elevador.Error2();
                }
                else
                {
                    Elevador.Inicializar();
                    if (elevador.andardatual != elevador.andarterreo)
                    {
                        Console.WriteLine(@"Elevador chegando até você");
                        Console.WriteLine(@"O elevador se encontra no andar {0}", elevador.andarterreo);

                        Console.WriteLine(@"O elevador está indo para o andar {0}", elevador.andardatual);

                        Elevador.Entrar();
                        elevador.andarterreo = elevador.andaratual;

                        if (elevador.andardatual > elevador.andardesejado)
                        {
                            Elevador.Descer();

                        } else { Elevador.Subir(); }

                        Elevador.Sair();
                        


                    }
                    else
                    {
                        Elevador.Entrar();
                        if(elevador.andardatual > elevador.andardesejado)
                        {
                            Elevador.Descer();

                        } else { Elevador.Subir(); }
                        Elevador.Sair();
                    }

                }
            }
            while (continuar);


        }

    }
}
