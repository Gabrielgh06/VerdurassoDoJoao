using System;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	O software deve permitir a entrada da placa do caminhão

            //•	O software deve considerar dois valores fixos: melancia comum R$ 5.50 e melancia baby 8.54 o quilo

            //•	O software deve possuir um looping(do while) que possa interagir com o usuário do sistema, esse looping irá mostrar o menu e as entradas de dados, deixando-o controlado por sentinela
            //(o usuário que vai determinar o fim)

            //•	O software deve considerar o looping e calcular o valor total de melancia comum e o valor total de melancia baby que foi carregada no caminhão em questão

            //•	O software deve também considerar e mostrar o total geral das duas melancias

            //•	Na entrada de dados o usuário vai entrar com um número inteiro. Você deverá utilizar um switch para mostrar uma mensagem personalizada para cada dia da semana.O dia 1 é segunda-feira o dia 5 é sexta-feira.
            //Os dias de promoção é na terça e quarta, chamada de quarta verde, então você deve dar um desconto na terça de 15 % e na quarta 17 %, as mensagens devem ser personalizadas(terça verde, quarta verde).
            //Os outros dias respectivamente devem dar os seguintes descontos: Seg(1 %) , Quinta(2 %) , Sexta(3 %) e não possuem mensagem de promoções.

            //•	Por último ele solicitou também, um controle de usuário, considerando que a senha é 123 e o usuário é “joão” crie um sistema de login que verifique se o usuário e a senha possui os dados corretos
            //para autenticar.

            //•	Muito importante, saber que ele pediu para bloquear e abandonar o looping se o usuário errar três vezes.Então, aplique os conhecimentos de if, if else, while, break, continue e aplique nesse desafio,
            //considere que ele pode acertar a senha e o usuário na 1ª , 2ª ou 3ª tentativa.


            string sair;
            string placaCaminhao = null;
            double valorComum = 5.0;
            double valorBaby = 8.56;
            double quiloComum = 0;
            double quiloBaby = 0;
            double pagarComum = 0;
            double pagarBaby = 0;
            double total = 0;
            string diaSemana = null;
            do
            {
                bool respostaValidaC = false;
                bool respostaValidaB = false;

                Console.WriteLine("Bem vindo ao Verdurão do João ");
                Console.WriteLine("Informe a placa do seu caminhão ou digite login para logar");
                var cmd = Console.ReadLine();
                if (cmd == "login")
                {
                    //còdigo para logar --> senha: 123 usuário: "joão"
                    int tentativas = 0;
                    string usuario;
                    string senha;
                    bool autenticado = false;
                    Console.Clear();
                    do
                    {
                        //Console.WriteLine("Por favor, informe suas credenciais de acesso:");
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
                                Console.WriteLine("Número máximo de tentativas atingido. Bloqueando acesso.");
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
                Console.Write("Informe o dia da semana: 1 - Segunda 2 - Terça 3 - Quarta 4 - Quinta 5 - Sexta  ");
                switch (Console.ReadLine())
                {
                    case "1":
                        diaSemana = "Segunda-feira";
                        break;
                    case "2":
                        diaSemana = "Terça Verde";
                        break;
                    case "3":
                        diaSemana = "Quarta Verde";
                        break;
                    case "4":
                        diaSemana = "Quinta-Feira";
                        break;
                    case "5":
                        diaSemana = "Sexta-feira";
                        break;

                }
                //diaSemana = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                string[,] tabela = new string[4, 4] { { Convert.ToString(diaSemana), "Melancia Comum", "melancia Baby", placaCaminhao }, { "Peso melancia", Convert.ToString(quiloComum), Convert.ToString(quiloBaby), "- - - -" }, { "Valor melancia", Convert.ToString(pagarComum), Convert.ToString(pagarBaby), "- - - -" }, { "Valor Total", "- - - -", "- - - -", Convert.ToString(total) } };

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(tabela[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                //Melancia Comum
                while (respostaValidaC == false)
                {
                    Console.WriteLine($"Temos disponíveis a melancia comum a 5,50 o quilo e a melancia do tipo Baby a 8,56 o quilo    | Seu Carrinho: {total}");
                    //($"melancia baby:{preco.ToString()}");
                    Console.WriteLine("Você quer comprar a Melancia Comum?");
                    Console.WriteLine("Digite S ou N");
                    string userResponseComum = Console.ReadLine();
                    switch (userResponseComum.ToUpper())
                    {
                        case "S":
                            // Qual a quantidade
                            Console.WriteLine("Quantos quilos você quer comprar?");
                            quiloComum = Convert.ToDouble(Console.ReadLine());
                            pagarComum = valorComum * quiloComum;
                            respostaValidaC = true;
                            break;
                        case "N":
                            respostaValidaC = true;
                            // Continua o código
                            break;
                        default:
                            // Caso o usuário digite algo fora S ou N
                            Console.Clear();
                            Console.WriteLine("Não entendi, digite S ou N");
                            break;
                    }
                }


                Console.Clear();
                //Melancia Baby
                while (respostaValidaB == false)
                {
                    Console.WriteLine("Você quer comprar a Melancia Baby?");
                    Console.WriteLine("Digite S ou N");
                    string userResponseBaby = Console.ReadLine();
                    switch (userResponseBaby.ToUpper())
                    {
                        case "S":
                            // Qual a quantidade
                            Console.WriteLine("Quantos quilos você quer comprar?");
                            quiloBaby = double.Parse(Console.ReadLine());
                            pagarBaby = valorBaby * quiloBaby;
                            respostaValidaB = true;
                            break;
                        case "N":
                            respostaValidaB = true;
                            // Continua o código
                            break;
                        default:
                            // Caso o usuário digite algo fora S ou N
                            Console.Clear();
                            Console.WriteLine("Não entendi, digite S ou N");
                            break;
                    }
                }
                Console.Clear();
                //Resultado
                Console.WriteLine("Caminhão da placa " + placaCaminhao + ", esta comprando:\r\n"
                   + "Quilos da melancia Comum: " + quiloComum + " Valor: " + pagarComum + "\r\n"
                   + "Quilos da melancia Baby: " + quiloBaby + " Valor: " + pagarBaby);
                Console.WriteLine("O total a se pagar é de: " + (total = pagarBaby + pagarComum));
                Console.WriteLine("\r\nDigite a palavra 'sair' para encerrar o programa ou precione enter caso queira refazer a operação");
                sair = Console.ReadLine();
                Console.Clear();
            } while (sair.ToLower() != "sair");

            Console.ReadLine();
        }
    }
}

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
