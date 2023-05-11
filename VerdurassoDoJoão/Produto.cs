using System;
using System.Collections.Generic;
using Produtos;
using Caminhao;


namespace VerduraoDoJoao.Melanciometro
{
    internal class Loja
    {
        private static List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {
            float ArredPrecoC;
            float ArredPrecoB;
            string sair;
            string placaCaminhao = null;
            string diaSemana = null;
            DayOfWeek today = DateTime.Today.DayOfWeek;

            do
            {
                // Rezetar:
                bool failLogin = false;
                bool sairCompra = false;
                double valorComum = 5.5;
                double valorBaby = 8.56;
                double pagarComum = 0;
                double pagarBaby = 0;
                double carrinhoComum = 0;
                double carrinhoBaby = 0;
            etiqueta:
                if (failLogin == false)
                {
                    // Boas vindas
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Bem vindo ao Verdurão do João ");
                    Console.ResetColor();
                    Console.WriteLine();
                    //Console.WriteLine("Digite: 1 para registrar seu caminhão ou 2 para logar");
                    Console.Write("Digite ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("1"); // Loja
                    Console.ResetColor();
                    Console.Write(" para acessar a loja ou ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("2"); // Login
                    Console.ResetColor();
                    Console.WriteLine(" para logar");
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Bem vindo ao Verdurão do João ");
                    Console.ResetColor();
                    Console.WriteLine();
                    //Console.WriteLine("Digite: 1 para registrar seu caminhão ou 2 para logar");
                    Console.Write("Digite ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("1"); // Loja
                    Console.ResetColor();
                    Console.Write(" para acessar a loja.");
                    Console.WriteLine();
                }
                

                Console.ForegroundColor = ConsoleColor.Green;
                var cmd = Console.ReadLine();
                Console.ResetColor();

                // Còdigo para logar --> senha: 123 usuário: "joão"
                if (cmd == "2" & failLogin == false)
                {
                    int tentativas = 3;
                    string usuario;
                    string senha;
                    bool autenticado = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine($"Por favor, informe suas credenciais de acesso: \tVocê tem {tentativas} tentativas");
                        Console.Write("Usuário: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        usuario = Console.ReadLine();
                        Console.ResetColor();
                        Console.Write("Senha: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        senha = Console.ReadLine();
                        Console.ResetColor();


                        if (usuario == "joão" && senha == "123")
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Login realizado com sucesso!");
                            Console.ResetColor();
                            Console.WriteLine("Bem Vindo João");
                            string comandoEscolhido;

                            do
                            {
                                // Exibição do menu
                                Console.Clear();
                                Console.WriteLine("Escolha uma opção: ");
                                Console.WriteLine("1 - Cadastrar produtos");
                                Console.WriteLine("2 - Listar produtos");
                                Console.WriteLine("3 - Sair");

                                // Leitura da opção desejada pelo usuário:
                                Console.Write("Opção desejada: ");
                                comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper(); // Converte para char, dps para string, para por fim ter acesso ao ToUpper, Podendo então o usuário digitar tando s/S

                                switch (comandoEscolhido)
                                {
                                    case "1":
                                        Console.Write("\nNome do produto: ");
                                        string nome = Console.ReadLine();
                                        Console.Write("Preço do produto: ");
                                        string preco = Console.ReadLine();
                                        Produto novoProduto = new Produto(nome, Convert.ToDouble(preco));
                                        produtos.Add(novoProduto);
                                        Console.WriteLine("Produto adicionado com sucesso!");
                                        break;
                                    case "2":
                                        if (produtos.Count > 0)
                                        {
                                            Console.WriteLine("\nListagem de Produtos");
                                            foreach (Produto p in produtos)
                                            {
                                                Console.WriteLine(p.DetalhesProduto());
                                            }
                                            Console.Write("Pressione qualquer teclar para prosseguir...");
                                            Console.ReadKey();
                                        }
                                        else
                                            Console.WriteLine("\nNão há produtos cadastrados.");
                                            Console.ReadKey();
                                        break;
                                    case "3":
                                        Console.WriteLine("\nObrigado por usar o programa.");
                                        Console.ReadKey();
                                        break;
                                    default:
                                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                                        break;
                                }
                            } while (comandoEscolhido == "3");

                            placaCaminhao = "ADM João";
                            autenticado = true;
                        }
                        else
                        {
                            tentativas--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Usuário ou senha incorretos.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();

                            if (tentativas == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("Número máximo de tentativas atingido. \r\nACESSO BLOQUEADO.");
                                Console.ReadKey();
                                //return;
                                //Environment.Exit(0);
                                Console.ResetColor();
                                Console.Clear();
                                failLogin = true;
                                goto etiqueta;
                            }
                        }

                    } while (!autenticado);

                }
                else if(cmd == "1")
                {
                    Console.WriteLine("Digite a placa do seu caminhão");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Placa p1 = new Placa();
                    Placa = Console.ReadLine();
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Digite ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("1");
                    Console.ResetColor();
                    Console.Write(" para acessar a loja ou ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("2"); // Login
                    Console.ResetColor();

                }
                // Dia da semana + desconto do dia 
                switch (today)
                {
                    case DayOfWeek.Monday:
                        diaSemana = "Segunda-Feira";
                        valorComum *= (1 - 0.01);
                        valorBaby *= (1 - 0.01);
                        break;
                    case DayOfWeek.Tuesday:
                        diaSemana = "Terça Verde";
                        valorComum *= (1 - 0.15);
                        valorBaby *= (1 - 0.15);
                        break;
                    case DayOfWeek.Wednesday:
                        diaSemana = "Quarta Verde";
                        valorComum *= (1 - 0.17);
                        valorBaby *= (1 - 0.17);
                        break;
                    case DayOfWeek.Thursday:
                        diaSemana = "Quinta-Feira";
                        valorComum *= (1 - 0.02);
                        valorBaby *= (1 - 0.02);
                        break;
                    case DayOfWeek.Friday:
                        diaSemana = "Sexta-feira";
                        valorComum *= (1 - 0.03);
                        valorBaby *= (1 - 0.03);
                        break;
                }
                Console.Clear();

                Console.WriteLine();
                // Operações para compra
                while (sairCompra == false)
                {
                    //arredondando os valores das melancias
                    Console.Clear();
                    ArredPrecoC = (float)valorComum;
                    ArredPrecoB = (float)valorBaby;

                    pagarComum = Math.Round((double)ArredPrecoC * carrinhoComum, 2);
                    pagarBaby = Math.Round((double)ArredPrecoB * carrinhoBaby, 2);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Hoje é {diaSemana}");
                    Console.WriteLine($"Temos disponíveis a melancia comum a {ArredPrecoC = (float)Math.Round((double)valorComum, 2)} o quilo e a melancia do tipo Baby a {ArredPrecoB = (float)Math.Round((double)valorBaby, 2)} o quilo.");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t" + carrinhoComum + "kg de Melancia Comum no carrinho | R$" + pagarComum);
                    Console.WriteLine("\t" + carrinhoBaby + "kg de Melancia Baby no carrinho | R$" + pagarBaby);
                    Console.ResetColor();
                    Console.WriteLine("\n");

                    Console.Write("Digite ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("1"); // Melancia comum
                    Console.ResetColor();
                    Console.Write(" ou ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("2"); // Melancia Baby
                    Console.ResetColor();
                    Console.Write(" para selecionar o tipo de melancia ou ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("3"); // Finalizar
                    Console.ResetColor();
                    Console.Write(" para finalizar a compra");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\t1 - ");
                    Console.ResetColor();
                    Console.Write("Melancia Comum");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\t2 - ");
                    Console.ResetColor();
                    Console.Write("Melancia Baby");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\t3 - ");
                    Console.ResetColor();
                    Console.Write("Finalizar");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string respostaUsuario = Console.ReadLine();
                    Console.ResetColor();


                    switch (respostaUsuario)
                    {
                        case "1": // Melancia Comum
                            try
                            {
                                Console.WriteLine("Quantos quilos você quer comprar da Melancia Comum?");
                                Console.ForegroundColor = ConsoleColor.Green;
                                carrinhoComum += Convert.ToDouble(Console.ReadLine());
                                Console.ResetColor();
                                if (carrinhoComum < 0.0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Valor inválido! O carrinho não pode ter valores negativos");
                                    Console.ResetColor();
                                    carrinhoComum = 0;
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Digite um valor válido de Kg!");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                            sairCompra = false;
                            break;
                        case "2": // Melancia Baby
                            try
                            {
                                Console.WriteLine("Quantos quilos você quer comprar da Melancia Baby?");
                                Console.ForegroundColor = ConsoleColor.Green;
                                carrinhoBaby += Convert.ToDouble(Console.ReadLine());
                                Console.ResetColor();
                                if (carrinhoBaby < 0.0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Valor inválido! O carrinho não pode ter valores negativos");
                                    Console.ResetColor();
                                    carrinhoBaby = 0;
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Digite um valor válido de Kg!");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                            sairCompra = false;
                            break;
                        // Sai da compra
                        case "3":
                            sairCompra = true;
                            break;
                        default:
                            // Caso o usuário digite algo fora 1, 2 ou finalizar
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Não entendi, digite 1, 2 ou 3 para finalizar");
                            Console.ResetColor();
                            Console.ReadKey();
                            sairCompra = false;
                            break;
                    }
                }
                Console.Clear();

                //Resultado
                double total = ((pagarComum) + (pagarBaby));
                // Código para criar a tabela
                string[,] tabela = new string[4, 4] { { Convert.ToString(diaSemana), "\tMelancia Comum", "\tmelancia Baby", "\t\t" + placaCaminhao }, { "Peso melancia", "\t\t" + Convert.ToString(carrinhoComum), "\t\t" + Convert.ToString(carrinhoBaby), "\t- - - - - - - -" }, { "Valor melancia", "\t\t" + Convert.ToString(pagarComum), "\t\t" + Convert.ToString(pagarBaby), "\t- - - - - - - -" }, { "Valor Total", "\t- - - - - - - -", "\t- - - - - - - -", "\t\t" + Convert.ToString(total) } };
                // Código para mostrar a tabela
                Console.ForegroundColor = ConsoleColor.Green;
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        Console.Write("\t " + tabela[x, y]);
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();

                Console.WriteLine();
                Console.Write("\r\nDigite");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" S ");
                Console.ResetColor();
                Console.Write("para encerrar o programa ou precione");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" enter ");
                Console.ResetColor();
                Console.Write("caso queira refazer a operação");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                sair = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

            } while (sair.ToLower() != "s");

            Console.ReadLine();
        }
    }
}