using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Sistema_Pastelaria
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declaração de variaveis
            int escolha;

            do
            {
                //Selecionar menu
                Console.WriteLine(new string('=', 79));
                Console.WriteLine(new string(' ', 25) + "Cifra de cesar");
                Console.WriteLine(new string('=', 79));
                Console.WriteLine("\n1 - Criptografar");
                Console.WriteLine("2 - Descriptografar");
                Console.WriteLine("0 - Encerrar programa");
                Console.Write("\n\n Digite a opção desejada: ");
                while (!(int.TryParse(Console.ReadLine(), out escolha) && (escolha >= 0 && escolha <= 2)))
                {
                    Console.Write("Opção INVÁLIDA !! Digite uma opção válida de 0 a 2: ");
                }
                Console.Clear();
                switch (escolha)
                {
                    case 0:
                        break;
                    case 1:
                        Criptografar();
                        break;
                    case 2:
                        Descriptografar();
                        break;
                }
            } while (escolha != 0);
        } 
        
        static int Erro(int var, int qntmin, int qntmax)
        {
            while (!(int.TryParse(Console.ReadLine(), out var) && (qntmin >= 1 && qntmax <= 26)))
            {
                Console.Write("Opção INVÁLIDA !! Digite uma numeração válida de {0} a {1}: ", qntmin, qntmax);
            }
            return var;
        }

        static void Criptografar()
        {
            //declaração de variaveis
            string textcript = "", textdescrip = "";
            int chave = 0, qntcar, i, num;

            Console.Clear();
            Console.Write("Digite o texto que deseja criptografar: ");
            //Leitura do texto que a pessoa quer criptografar
            textdescrip = Console.ReadLine();
            //Solicita a chave da cifra
            Console.Write("Digite a chave da cifra: ");
            chave = Erro(chave, 1, 26);
            //Guarda  a quantidade de caracteres da palavra com o .Lenght
            qntcar = textdescrip.Length;

            for (i = 0; i < qntcar; i++)
            {
                //converte o texto de cada caractere da palavra pra número e adiciona a chave
                num = Convert.ToInt16(textdescrip[i]) + chave;

                textcript += Convert.ToChar(num);
            }
            Console.Write(textcript);
            Console.ReadKey(true);
            Console.Clear();
        }

        static void Descriptografar()
        {
            //declaração de variaveis
            string textcript = "", textdescrip = "";
            int chave = 0, qntcar, i, num;


            Console.Clear();
            Console.Write("Digite o texto que deseja descriptografar: ");
            //Leitura do texto que a pessoa quer criptografar
            textcript = Console.ReadLine();
            //Solicita a chave da cifra
            Console.Write("Digite a chave da cifra: ");
            chave = Erro(chave, 1, 26);
            //Guarda  a quantidade de caracteres da palavra com o .Lenght
            qntcar = textcript.Length;

            for (i = 0; i < qntcar; i++)
            {
                //converte o texto de cada caractere da palavra pra número e adiciona a chave
                num = Convert.ToInt16(textcript[i]) - chave;
                textdescrip += Convert.ToChar(num);

            }
            Console.Write(textdescrip);
            Console.ReadKey(true);
            Console.Clear();
        }
        
    }
}