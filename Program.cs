using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroDeUsuariosAula08
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            Console.ForegroundColor = ConsoleColor.Green; // Mudou de cor
            Console.Write("Digite os nomes separados por vírgula");
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor
            Console.WriteLine("     (exemplo: João, Maria, Pedro)");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor
            string entrada = Console.ReadLine();

            // Dividir a entrada em nomes separados por vírgula
            string[] nomesDigitados = entrada.Split(',');

            // Adicionar os nomes à lista
            foreach (string nome in nomesDigitados)
            {
                nomes.Add(nome.Trim());
            }

            bool continuar = true;
            // ---------------------------- Bloco para selecionar ----------------------------------------------------
            while (continuar)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // Mudou de cor para Ciano
                Console.WriteLine("\nOpções disponíveis:");

                
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                //opção 1
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para AMARELO ESCURO
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para AMARELO
                Console.WriteLine("Verificar se um nome está na lista");
                //opção 2
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para AMARELO ESCURO
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para AMARELO
                Console.WriteLine("Deletar um nome da lista");
                //opção 3
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para AMARELO ESCURO
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para AMARELO
                Console.WriteLine("Visualizar todos os nomes da lista");
                //opção 4
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para AMARELO ESCURO
                Console.Write("4 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para AMARELO
                Console.WriteLine("Adicionar mais nomes à lista");
                //opção 5
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para AMARELO ESCURO
                Console.Write("5 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para AMARELO
                Console.WriteLine("Alterar um nome da lista");
                //opção 6
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para AMARELO ESCURO
                Console.Write("6 - ");
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para VERMELHO
                Console.WriteLine("Encerrar o programa");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para BRANCO
                //Fim das opções

                Console.WriteLine("\nDigite o número correspondente à opção desejada:");
                string opcao = Console.ReadLine();


                // ---------------------------- sequencias de cases ----------------------------------------------------
                switch (opcao)
                {
                    case "1":
                        // Verificar se um nome está na lista
                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                        Console.WriteLine("Digite um nome para verificar se está na lista:");
                        Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        string nomeVerificar = Console.ReadLine();

                        if (nomes.Contains(nomeVerificar))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                            Console.WriteLine("O nome está na lista.");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                            Console.Write("O nome ");
                            Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Amarelo
                            Console.WriteLine("não está na lista.");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        }
                        break;

                    case "2":
                        // Deletar um nome da lista
                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                        Console.WriteLine("Nomes na lista:");
                        Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        if (nomes.Count == 0)
                        {
                            Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                            Console.WriteLine("A lista está vazia ainda...");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        }
                        else
                        {
                            foreach (string nome in nomes)
                            {
                                Console.WriteLine(nome);
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                            Console.WriteLine("\nDigite um nome para deletar da lista:");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                            string nomeDeletar = Console.ReadLine();

                            if (nomes.Remove(nomeDeletar))
                            {
                                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                                Console.WriteLine("O nome foi removido da lista com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                            }
                            else
                            {
                                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Amarelo
                                Console.WriteLine("O nome não foi encontrado na lista.");
                                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                            }
                        }
                        break;

                    case "3":
                        // Visualizar todos os nomes da lista
                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                        Console.WriteLine("Nomes na lista:");
                        Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        if (nomes.Count == 0)
                        {
                            Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                            Console.WriteLine("A lista está vazia ainda...");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        }
                        else
                        {
                            foreach (string nome in nomes)
                            {
                                Console.WriteLine(nome);
                            }
                        }
                        break;

                    case "4":
                        // Adicionar mais nomes à lista
                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.ForegroundColor = ConsoleColor.Green; // Mudou de cor
                        Console.Write("Digite os nomes separados por vírgula");
                        Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor
                        Console.WriteLine("     (exemplo: João, Maria, Pedro)");
                        Console.ForegroundColor = ConsoleColor.White; // Mudou de cor
                        string novosNomes = Console.ReadLine();

                        string[] nomesAdicionais = novosNomes.Split(',');

                        foreach (string nome in nomesAdicionais)
                        {
                            nomes.Add(nome.Trim());
                        }

                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                        Console.WriteLine("Certo! adicionado à lista com sucesso.");
                        Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        break;

                    case "5":
                        // Alterar um nome da lista
                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                        Console.WriteLine("Nomes na lista:");
                        Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        if (nomes.Count == 0)
                        {
                            Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                            Console.WriteLine("Nenhum nome localizado em sua lista.");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                        }
                        else
                        {
                            foreach (string nome in nomes)
                            {
                                Console.WriteLine(nome);
                            }

                            Console.ForegroundColor = ConsoleColor.Cyan; // Mudou de cor para Amarelo
                            Console.WriteLine("\nDigite o nome que deseja alterar:");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                            string nomeExistente = Console.ReadLine();

                            if (nomes.Contains(nomeExistente))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                                Console.WriteLine("Digite o novo nome:");
                                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                                string novoNome = Console.ReadLine();

                                int index = nomes.IndexOf(nomeExistente);
                                nomes[index] = novoNome;

                                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                                Console.WriteLine("O nome foi alterado com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                            }
                            else
                            {
                                Console.WriteLine("Esse nome não existe na lista.");
                            }
                        }
                        break;

                    case "6":
                        // Encerrar o programa
                        continuar = false;
                        Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                        Console.Write("Obrigado por utilizar o programa! ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Encerrando em 7 segundos...");
                        Thread.Sleep(7000); // tempo
                        break;
                    // ---------------------------- fim das cases ----------------------------------------------------
                    // ---------------------------- Se não entrar nas cases, da essa mensagem ------------------------

                    default:
                        Console.WriteLine("Opção inválida. Digite um número válido.");
                        break;

                    // -----------------------------------------------------------------------------------------------

                }
            }
        }
    }
}
