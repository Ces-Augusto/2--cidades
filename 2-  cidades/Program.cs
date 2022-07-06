using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___cidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MesE = null;
            int dia, mes, ano;
            double cidades;
            
            

            Console.WriteLine("\tCidade \n 1 – Atibaia\n 2 – Bragança Paulista\n 3 – Mairiporã\n 4 – Nazaré\n 5 – Terra Preta\n 6 – Extrema\n 7 – Vargem\n");

            Console.WriteLine("Digite o numero da Cidade que deseja\n");
            cidades = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Digite a data (dd/mm/aaaa): \n");
            var DataAtual = Convert.ToDateTime(Console.ReadLine());

            mes = DataAtual.Month;
            dia = DataAtual.Day;
            ano = DataAtual.Year;

            switch (mes)
            {
                case 1:
                    MesE = "Janeiro";
                    break;
                case 2:
                    MesE = "Fevereiro";
                    break;
                case 3:
                    MesE = "Março";
                    break;
                case 4:
                    MesE = "Abril";
                    break;
                case 5:
                    MesE = "Maio";
                    break;
                case 6:
                    MesE = "Junho";
                    break;
                case 7:
                    MesE = "Julho";
                    break;
                case 8:
                    MesE = "Agosto";
                    break;
                case 9:
                    MesE = "Setembro";
                    break;
                case 10:
                    MesE = "Outubro";
                    break;
                case 11:
                    MesE = "Novembro";
                    break;
                case 12:
                    MesE = "Dezembro";
                    break;
            }

            if (cidades == 1)
            {
                Console.WriteLine("Atibaia");
            }
            if (cidades == 2)
            {
                Console.WriteLine("Bragança Paulista ");
            }
            if (cidades == 3)
            {
                Console.WriteLine("Mairiporã ");
            }
            if (cidades == 4)
            {
                Console.WriteLine("Nazaré ");
            }
            if (cidades == 5)
            {
                Console.WriteLine("Terra Preta ");
            }
            if (cidades == 6)
            {
                Console.WriteLine("Extrema");
            }
            if (cidades == 7)
            {
                Console.WriteLine("Vargem");
            }
            Console.WriteLine(dia + " de " + MesE + " de " + ano);
            Console.ReadKey();
        }
    }
}
