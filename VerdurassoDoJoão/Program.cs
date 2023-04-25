using System;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double valorComum = 5.5;
            //double valorBaby = 8.56;
            //double quiloComum = 0;
            //double quiloBaby = 0;
            //double pagarComum = 0;
            //double pagarBaby = 0;
            //double total = (pagarComum + pagarBaby);
            float ArredPrecoC;
            float ArredPrecoB;
            string sair;
            string placaCaminhao = null;
            string diaSemana = null;
            DayOfWeek today = DateTime.Today.DayOfWeek;
            // string[,] tabela = new string[4, 4] { { Convert.ToString(diaSemana), "\tMelancia Comum", "melancia Baby", placaCaminhao }, { "Peso melancia", "\t" + Convert.ToString(quiloComum), "\t" + Convert.ToString(quiloBaby), "- -" }, { "Valor melancia", "\t" + Convert.ToString(pagarComum), "\t" + Convert.ToString(pagarBaby), "- -" }, { "Valor Total", "      - - -", "      - - -", " " + Convert.ToString(total) } };

            //=> Acessar loja
            //=> Login
            //      Menu João:
            //      Registrar Caminhão
            //      Deletar Caminhão
            //      Procurar Caminhão pela Placa
            //      Procurar Caminhão pelo CPF/ CNPJ do proprietário
            //      Regiustrar Produto
            //      Deletar Produto
            //      Sair

            do
            {
                // Rezetar:
                bool sairCompra = false;
                double valorComum = 5.5;
                double valorBaby = 8.56;
                double pagarComum = 0;
                double pagarBaby = 0;
                double carrinhoComum = 0;
                double carrinhoBaby = 0;

                // Boas vindas
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bem vindo ao Verdurão do João ");
                Console.ResetColor();
                //Console.WriteLine("Digite: 1 para registrar seu caminhão ou 2 para logar");
                //Console.WriteLine("Informe a placa do seu caminhão ou digite login para logar");
                Console.Write("Digite ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("1"); // Loja
                Console.ResetColor();
                Console.Write(" para acessar a loja ou ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("2"); // Login
                Console.ResetColor();
                Console.WriteLine(" para logar");
                Console.ForegroundColor = ConsoleColor.Green;
                var cmd = Console.ReadLine();
                Console.ResetColor();

                // Còdigo para logar --> senha: 123 usuário: "joão"
                if (cmd == "2")
                {
                    int tentativas = 0;
                    string usuario;
                    string senha;
                    bool autenticado = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Por favor, informe suas credenciais de acesso:");
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
                            placaCaminhao = "ADM João";
                            autenticado = true;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Login realizado com sucesso!");
                            Console.ResetColor();
                        }
                        else
                        {
                            tentativas++;

                            Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");

                            if (tentativas == 3)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("Número máximo de tentativas atingido. \r\nACESSO BLOQUEADO.");
                                Console.ReadKey();
                                Environment.Exit(0);
                                //break;
                            }
                        }

                    } while (!autenticado);

                }
                else
                {
                    Console.WriteLine("Digite a placa do seu caminhão");
                    Console.ForegroundColor = ConsoleColor.Green;
                    placaCaminhao = Console.ReadLine();
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.Black;

                /* COntrole de dia da semana escolhido pelo usuário
                 * Console.Write("Informe o dia da semana: \r\n 1 - Segunda; \r\n 2 - Terça 15% off; \r\n 3 - Quarta 17% off; \r\n 4 - Quinta; \r\n 5 - Sexta\r\n");

                    while (diaSemana == null)
                    {
                        switch (Console.ReadLine())
                        {
                            case "1":
                                diaSemana = "Segunda-feira";
                                desconto = 0.01;
                                break;
                            case "2":
                                diaSemana = "Terça Verde";
                                desconto = 0.15;
                                break;
                            case "3":
                                diaSemana = "Quarta Verde";
                                desconto = 0.17;
                                break;
                            case "4":
                                diaSemana = "Quinta-Feira";
                                desconto = 0.02;
                                break;
                            case "5":
                                diaSemana = "Sexta-feira";
                                desconto = 0.03;
                                break;
                            default:
                                // Caso o usuário digite algo fora 1, 2, 3, 4, 5
                                Console.WriteLine("Não entendi, digite 1, 2, 3, 4 ou 5");
                                break;
                        }
                    }*/

                // Dia da semana + desconto do dia 
                switch (today)
                {
                    case DayOfWeek.Monday:
                        diaSemana = "Segunda-Feira";
                        valorComum = valorComum * (1 - 0.01);
                        valorBaby = valorBaby * (1 - 0.01);
                        break;
                    case DayOfWeek.Tuesday:
                        diaSemana = "Terça Verde";
                        valorComum = valorComum * (1 - 0.15);
                        valorBaby = valorBaby * (1 - 0.15);
                        break;
                    case DayOfWeek.Wednesday:
                        diaSemana = "Quarta Verde";
                        valorComum = valorComum * (1 - 0.17);
                        valorBaby = valorBaby * (1 - 0.17);
                        break;
                    case DayOfWeek.Thursday:
                        diaSemana = "Quinta-Feira";
                        valorComum = valorComum * (1 - 0.02);
                        valorBaby = valorBaby * (1 - 0.02);
                        break;
                    case DayOfWeek.Friday:
                        diaSemana = "Sexta-feira";
                        valorComum = valorComum * (1 - 0.03);
                        valorBaby = valorBaby * (1 - 0.03);
                        break;
                }
                Console.Clear();

                Console.WriteLine();
                // Operações para compra
                while (sairCompra == false)
                {
                    //arredondando os valores das melancias
                    Console.Clear();
                    ArredPrecoC = (float)(Math.Round((double)valorComum, 2));
                    ArredPrecoB = (float)(Math.Round((double)valorBaby, 2));
                    pagarComum = Math.Round((double)ArredPrecoC * carrinhoComum, 2);
                    pagarBaby = Math.Round((double)ArredPrecoB * carrinhoBaby, 2);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Hoje é {diaSemana}");
                    Console.WriteLine($"Temos disponíveis a melancia comum a {ArredPrecoC} o quilo e a melancia do tipo Baby a {ArredPrecoB} o quilo."); // ------------- ALTERAR --------------- 5,50 e 8,56
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
                        Console.Write(tabela[x, y] + "\t ");
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
                sair = Console.ReadLine();
                Console.Clear();
            } while (sair.ToLower() != "s");

            Console.ReadLine();
        }
    }
}

//($"melancia baby:{preco.ToString()}");

// • O software deve permitir a entrada da placa do caminhão
// • O software deve considerar dois valores fixos: melancia comum R$ 5.50 e melancia baby 8.54 o quilo
// • O software deve possuir um looping(do while) que possa interagir com o usuário do sistema, esse looping irá mostrar o menu e as entradas de dados, deixando-o controlado por sentinela
//(o usuário que vai determinar o fim)
// • O software deve considerar o looping e calcular o valor total de melancia comum e o valor total de melancia baby que foi carregada no caminhão em questão
// • O software deve também considerar e mostrar o total geral das duas melancias
// • Na entrada de dados o usuário vai entrar com um número inteiro. Você deverá utilizar um switch para mostrar uma mensagem personalizada para cada dia da semana.O dia 1 é segunda-feira o dia 5 é sexta-feira.
//Os dias de promoção é na terça e quarta, chamada de quarta verde, então você deve dar um desconto na terça de 15 % e na quarta 17 %, as mensagens devem ser personalizadas(terça verde, quarta verde).
//Os outros dias respectivamente devem dar os seguintes descontos: Seg(1 %) , Quinta(2 %) , Sexta(3 %) e não possuem mensagem de promoções.
// • Por último ele solicitou também, um controle de usuário, considerando que a senha é 123 e o usuário é “joão” crie um sistema de login que verifique se o usuário e a senha possui os dados corretos
//para autenticar.
// • Muito importante, saber que ele pediu para bloquear e abandonar o looping se o usuário errar três vezes.Então, aplique os conhecimentos de if, if else, while, break, continue e aplique nesse desafio,
//considere que ele pode acertar a senha e o usuário na 1ª , 2ª ou 3ª tentativa.


//Desafio 1) agora o João do Caminhão quer vender Caqui, Morango, Laranja e Uva.
//
//Desafio 2) agora o João quer dar desconto, mas não é pra todo mundo, é só pra quem já comprou 5 mil reais de algum produto e só em comprar acima de 1 mil reais de outro produto.
//
//Desafio 3) agora o João esta tendo procura por verduras também, mas só que nem sempre, tem períodos que procuram milho, tem períodos que procuram batata e tem períodos que o caqui o João não tem para vender,
//então o João quer poder acrescentar produtos e tirar produtos e também poder trocar os preços sem precisar de um novo programa.
//
//Desafio 4) agora o João quer saber o total de vendas não só para cada cliente mas para todos clientes, então ele precisa de um relatório que mostre o total de venda para cada produto e o faturamento geral.
//Conversando com o João ele descobriu que programador do sistema dele fez SENAI e ele foi procurar mais sobre e descobriu o sistema FIBRA, SEBRAE, SENAC e etc. João fez um curso no SEBRAE e descobriu varias coisas 
//
//Desafio 5) João descobriu que é muito importante ter um relação com o cliente então agora o João quer saber para quem ele mais vende.
//
//Desafio 6) João descobriu que não é só o faturamento que é importante mas que tem que calcular o lucro, então agora o João quer além de registrar os preços de cada produto, registrar o custo e saber qual cliente é o
//mais lucrativo já que João aprendeu que nem sempre o cliente que mais comprou vai ser o que deu mais lucro.
//
//Desafio 7) Acrescente seu desafio para turma
//
//
