using System;
using CifrasLibrary;

namespace CifrasSubstituicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cifras _cifras = new Cifras();
            
            int[] cifrasPossiveis = { 1, 2, 3, 4 };
            int cifra = 0;
            string textoCifrado = "";
            bool encerrarApp = false;
            bool recifrar = false;
            string text = "";

            while (!encerrarApp)
            {
                Console.WriteLine("Cifras de Substituição");
                Console.WriteLine("------------------------------------");
                if (!recifrar)
                {
                    Console.WriteLine("Insira a fase a ser criptografada");
                    text = Console.ReadLine();
                }

                Console.WriteLine("------------------------------------");
                Console.WriteLine("Digite o número da cifra que será aplicada:");
                Console.WriteLine("1 - ATBASH");
                Console.WriteLine("2 - ALBAM");
                Console.WriteLine("3 - ATBAH");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Cifra escolhida: ");

                //validação escolhas
                bool cifraEscolhida = false;
                while (!cifraEscolhida)
                {
                    cifra = Convert.ToInt32(Console.ReadLine());
                    foreach (int cp in cifrasPossiveis)
                    {
                        if (cp.Equals(cifra))
                        {
                            cifraEscolhida = true;
                            break;
                        }
                    }
                    if (!cifraEscolhida)
                        Console.WriteLine("Escolha uma cifra válida ou encerre o programa.");
                }

                if (cifra == 4)
                {
                    Console.WriteLine("Encerrando... Pressione 'Enter' para finalizar.");
                    Console.ReadLine();
                    return;
                }

                textoCifrado = _cifras.Decifrar(text, cifra);
                Console.WriteLine(textoCifrado);

                // Aguardar ação do usuário para encerrar
                bool novaOperacao = false;
                while (!novaOperacao)
                {
                    Console.Write("Deseja realizar outra operação? Pressione S para Sim ou N para Não. ");
                    string finalizarPrograma = Console.ReadLine();
                    finalizarPrograma = finalizarPrograma.ToUpper();
                    if (finalizarPrograma == "N")
                    {
                        encerrarApp = true;
                        Console.WriteLine("Encerrando... Pressione 'Enter' para finalizar.");
                        Console.ReadLine();
                        break;
                    }
                    else if (finalizarPrograma == "S")
                    {
                        recifrar = false;
                        Console.WriteLine("Reiniciando cifras. \n");
                        novaOperacao = true;
                        
                        bool validarConfirm = false;
                        while (!validarConfirm)
                        {
                            Console.WriteLine("Deseja recifrar?");
                            string recifrarConfirm = Console.ReadLine();
                            recifrarConfirm = recifrarConfirm.ToUpper();
                            if (recifrarConfirm == "S")
                            {
                                validarConfirm = true;
                                recifrar = true;
                                text = textoCifrado;
                            }
                            else if (recifrarConfirm == "N")
                            {
                                recifrar = false;
                                validarConfirm = true;
                            }
                            else
                            {
                                Console.WriteLine("Insira 'S' para recfirar ou 'N' para uma nova cifra: ");
                            }
                        }
                    }
                }
            }
        }
    }
}

