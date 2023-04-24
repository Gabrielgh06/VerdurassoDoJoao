using System;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorComum = 5.5;
            double valorBaby = 8.56;
            double quiloComum = 0;
            double quiloBaby = 0;
            double desconto = 0;
            double descontoComum = 0;
            double descontoBaby = 0;
            double total = (descontoComum + descontoBaby);
            string sair;
            string placaCaminhao = null;
            string diaSemana = null;
            DayOfWeek today = DateTime.Today.DayOfWeek;
            string[,] tabela = new string[4, 4] { { Convert.ToString(diaSemana), "\tMelancia Comum", "melancia Baby", placaCaminhao }, { "Peso melancia", "\t" + Convert.ToString(quiloComum), "\t" + Convert.ToString(quiloBaby), "- -" }, { "Valor melancia", "\t" + Convert.ToString(descontoComum), "\t" + Convert.ToString(descontoBaby), "- -" }, { "Valor Total", "      - - -", "      - - -", " " + Convert.ToString(total) } };

            //
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

                // Boas vindas
                Console.WriteLine("Bem vindo ao Verdurão do João ");
                //Console.WriteLine("Digite: 1 para registrar seu caminhão ou 2 para logar");
                Console.WriteLine("Informe a placa do seu caminhão ou digite login para logar");
                var cmd = Console.ReadLine();

                // Còdigo para logar --> senha: 123 usuário: "joão"
                if (cmd == "login")
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
                        usuario = Console.ReadLine();
                        Console.Write("Senha: ");
                        senha = Console.ReadLine();

                        if (usuario == "joão" && senha == "123")
                        {
                            placaCaminhao = "João";
                            autenticado = true;
                            Console.WriteLine("Login realizado com sucesso!");
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
                                Console.WriteLine("Número máximo de tentativas atingido. ACESSO BLOQUEADO.");
                                Console.ReadKey();
                                break;
                            }
                        }

                    } while (!autenticado);

                }
                else
                {
                    //placaCaminhao = Console.ReadLine();
                    placaCaminhao = cmd;
                }

                //Console.Write("Informe o dia da semana: \r\n 1 - Segunda; \r\n 2 - Terça 15% off; \r\n 3 - Quarta 17% off; \r\n 4 - Quinta; \r\n 5 - Sexta\r\n");
                //while (diaSemana == null)
                //{
                //    switch (Console.ReadLine())
                //    {
                //        case "1":
                //            diaSemana = "Segunda-feira";
                //            desconto = 0.01;
                //            break;
                //        case "2":
                //            diaSemana = "Terça Verde";
                //            desconto = 0.15;
                //            break;
                //        case "3":
                //            diaSemana = "Quarta Verde";
                //            desconto = 0.17;
                //            break;
                //        case "4":
                //            diaSemana = "Quinta-Feira";
                //            desconto = 0.02;
                //            break;
                //        case "5":
                //            diaSemana = "Sexta-feira";
                //            desconto = 0.03;
                //            break;
                //        default:
                //            // Caso o usuário digite algo fora 1, 2, 3, 4, 5
                //            Console.WriteLine("Não entendi, digite 1, 2, 3, 4 ou 5");
                //            break;
                //    }
                //}

               Console.BackgroundColor = ConsoleColor.Black;

                // Dia da semana + desconto do dia 
                switch (today)
                {
                    case DayOfWeek.Monday:
                        diaSemana = "Segunda";
                        //valorBaby = valorBaby * (1 - 0.01);
                        //valorComum = valorComum * (1 - 0.01);
                        desconto = 0.01;
                        break;
                    case DayOfWeek.Tuesday:
                        diaSemana = "Terça Verde";
                        desconto = 0.15;
                        break;
                    case DayOfWeek.Wednesday:
                        diaSemana = "Quarta Verde";
                        desconto = 0.17;
                        break;
                    case DayOfWeek.Thursday:
                        diaSemana = "Quinta-Feira";
                        desconto = 0.02;
                        break;
                    case DayOfWeek.Friday:
                        diaSemana = "Sexta-feira";
                        desconto = 0.03;
                        break;
                }

                Console.Clear();

                // Código para criar a tabela
                //string[,] tabela = new string[4, 4] { { Convert.ToString(today), "\tMelancia Comum", "melancia Baby", placaCaminhao }, { "Peso melancia", "\t" + Convert.ToString(quiloComum), "\t" + Convert.ToString(quiloBaby), "- -" }, { "Valor melancia", "\t" + Convert.ToString(descontoComum), "\t" + Convert.ToString(descontoBaby), "- -" }, { "Valor Total", "      - - -", "      - - -", " " + Convert.ToString(total) } };

                /* Código para mostrar a tabela com o carrinho do respectivo caminhão
                 
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write(tabela[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                */

                Console.WriteLine("Temos disponíveis a melancia comum a 5,50 o quilo e a melancia do tipo Baby a 8,56 o quilo.");
                Console.WriteLine();
                // Operações para compra
                while (sairCompra == false)
                {
                    Console.WriteLine();
                    // Código para mostrar a tabela do caminhão com seu respectivo carrinho
                    for (int a = 0; a < 4; a++)
                    {
                        for (int s = 0; s < 4; s++)
                        {
                            Console.Write(tabela[a, s] + "\t");
                        }
                        Console.WriteLine("tabela1");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 ou 2 para selecionar o tipo de melancia ou 3 para finalizar a compra\r\n" +
                        "1 - melancia comum; \r\n2 - melancia baby; \r\n3 - finalizar");
                    //($"melancia baby:{preco.ToString()}");
                    string userResponse = Console.ReadLine();
                    switch (userResponse)
                    {
                        case "1":
                            // Qual a quantidade
                            Console.WriteLine("Quantos quilos você quer comprar da melancia comum?");
                            quiloComum = Convert.ToDouble(Console.ReadLine());
                            double pagarComum = valorComum * quiloComum;
                            descontoComum = pagarComum - (pagarComum * desconto);
                            sairCompra = false;
                            Console.Clear();
                            break;
                        case "2":
                            Console.WriteLine("Quantos quilos você quer comprar da melancia baby?");
                            quiloBaby = double.Parse(Console.ReadLine());
                            double pagarBaby = valorBaby * quiloBaby;
                            descontoBaby = pagarBaby - (pagarBaby * desconto);
                            sairCompra = false;
                            Console.Clear();
                            break;
                        // Sai do while
                        case "3":
                            sairCompra = true;
                            break;
                        default:
                            // Caso o usuário digite algo fora 1, 2 ou finalizar
                            Console.Clear();
                            Console.WriteLine("Não entendi, digite 1, 2 ou finalizar");
                            sairCompra = false;
                            break;
                    }
                }
                Console.Clear();

                //Resultado
                for (int q = 0; q < 4; q++)
                {
                    for (int w = 0; w < 4; w++)
                    {
                        Console.Write(tabela[q, w] + "\t ");
                    }
                    Console.WriteLine("tabela2");
                }
                Console.WriteLine();
                Console.WriteLine("\r\nDigite a palavra 'sair' para encerrar o programa ou precione enter caso queira refazer a operação");
                sair = Console.ReadLine();
                Console.Clear();
            } while (sair.ToLower() != "sair");
            Console.ReadLine();
        }
    }
}


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
