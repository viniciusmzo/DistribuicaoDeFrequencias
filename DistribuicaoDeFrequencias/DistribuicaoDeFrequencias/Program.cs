using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoDeFrequencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, amplitudeClasse = 0, pm = 0, ordem = 0, contFi = 0;
            int linhas, colunas;
            List<int> dados = new List<int>();
            List<int> dados2 = new List<int>();
            List<int> calcularFi = new List<int>();
            int[,] rol;
            char opc;

            //ENTRADA DE QUANTOS DADOS SERÃO INSERIDOS NO ROL
            Console.Write("Digite a quantidade de dados: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Insira o " + (i + 1) + "º valor: ");
                dados.Add(int.Parse(Console.ReadLine()));
            }


            //ORDENAR DADOS EM FORMA CRESCENTE
            dados.Sort();

            

            //ROL
            Console.WriteLine("Defina as dimensões do ROL: (LINHAS x COLUNAS)");
            linhas = int.Parse(Console.ReadLine());
            colunas = int.Parse(Console.ReadLine());

            rol = new int[linhas, colunas];
            int x = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    
                    rol[i, j] = dados[x];
                    x += 1;
                }
            }

            

            for (int i = 0; i < linhas; i++)
            {

                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(rol[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Deseja definir o numero de classes? (S/N)");
            opc = char.Parse(Console.ReadLine().ToUpper());

            if (opc == 'S')
            {
                Console.Write("Digite a ordem da classe: ");
                ordem = int.Parse(Console.ReadLine());
            }
            else if (opc == 'N') { ordem = Convert.ToInt32(Math.Sqrt(num)); }

            Console.Write("Deseja definir a amplitude das classes? (S/N)");
            opc = char.Parse(Console.ReadLine().ToUpper());

            if (opc == 'S')
            {
                Console.Write("Digite a amplitude da classe: ");
                amplitudeClasse = int.Parse(Console.ReadLine());
            }
            else if (opc == 'N') { amplitudeClasse = num / ordem; }
            
            Console.Write("| ORDEM | CLASSE | FI | FIAC | FR | FR% | FR%AC |");



            Console.ReadKey();
        }

    }
}
