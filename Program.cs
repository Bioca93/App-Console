using System;

namespace LigacaoDosExercicios
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string nome;
            char aceitar;

            Console.WriteLine("Olá! Como te chamas?");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("{0}, vamos fazer uns exercícios, aceitas?", nome);
            Console.WriteLine("Escreve S para aceitar, ou N para recusar.");
            aceitar = Convert.ToChar(Console.ReadLine());

           
                
                if (aceitar == ('s') || aceitar == ('S'))
                {
                    Console.WriteLine("Obrigado por teres aceite. Vamos então indicar as instruções: ");
                    Console.WriteLine("1. Não podes repetir no mesmo exercício nenhum número se não és banido.");
                    Console.WriteLine("2.Escolhe o número do exercício que pretendes jogar de acordo com o número que aparece no ecrã.");
                    Console.WriteLine("3. Podes repetir os exercícios até 10 vezes.");
                    Console.WriteLine("4. Boa sorte!");
                    Console.WriteLine("5. Pressiona a tecla enter para continuar.");
                }
                else 
                Console.WriteLine("Obrigado! E um resto de excelente dia!");
                Console.WriteLine("Pressiona 0 para sair.");
    

            Console.ReadLine();
            Console.Clear();

            

            int exercicio;
            int counter = 10;
do { 
            do
            {
                Console.WriteLine("Escreve o numero correspondente ao exercicio que pretendes executar: ");
                Console.WriteLine("1 - Identificar 4 números e o resultado apresentado será o maior entre eles.");
                Console.WriteLine("2 - Identificar 2 números e o resultado apresentado será o maior valor da divisão entre eles.");
                Console.WriteLine("3 - Identificar 4 números e o resultado apresentado será o menor valor da divisão com a soma entre eles.");
                Console.WriteLine("4 - Identificar 2 números e o resultado apresentado será o valor da divisão com duas casas décimais.");
                Console.WriteLine("5 - Identificar 2 números e o resultado apresentado será conforme o valor da sua multiplicação.");
                Console.WriteLine("6 - Calculadora.");
                Console.WriteLine("0 - Sair.");
                Console.WriteLine("Número de oportunidades: " + counter);

                exercicio = Convert.ToInt32(Console.ReadLine());
                counter--;

                if (exercicio > 6 || exercicio < 0)
                {
                    Console.WriteLine("A opção " + exercicio + " não é válida");
                    Console.WriteLine("Por favor insira uma opção válida");
                    Console.WriteLine();
                }
                    if (exercicio == 0)
                        break;
                    
                Console.ReadLine(); 
                Console.Clear();
                

                switch (exercicio)
                {
                    case 1:
                        int A;
                        int B;
                        int C;
                        int D;

                        Console.Write("Introduza um número para A:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduza um número para B:");
                        B = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduza um número para C:");
                        C = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduza um número para D:");
                        D = Convert.ToInt32(Console.ReadLine());

                        if (A > B && A > C && A > D)
                        {
                            Console.WriteLine("O valor atribuito a A com o número " + A + " é o maior!");
                        }
                        if (B > A && B > C && B > D)
                        {
                            Console.WriteLine("O valor atribuido a B com o número {0} é o maior!", B);
                        }
                        if (C > A && C > B && C > D)
                        {
                            Console.WriteLine("O valor atribuido a C com o número {0} é o maior!", C);
                        }
                        if (D > A && D > B && D > C)
                        {
                            Console.WriteLine("O valor atribuido a D com o número " + D + " é o maior");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;
                        

                    case 2:
                        double num1;
                        double num2;

                        Console.WriteLine("Introduza um número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduza outro número diferente: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        double resultado1 = num1 / num2;
                        double resultado2 = num2 / num1;

                        if (num1 / num2 > num2 / num1)
                            Console.WriteLine("Da divisão entre {0} e {1} resulta o número maior com o valor de {2}", num1, num2, resultado1);
                        else
                            Console.WriteLine("Da divisão entre {0} e {1} resulta o número maior com o valor de {2}", num2, num1, resultado2);

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        double primeiroNum;
                        double segundoNum;
                        double terceiroNum;
                        double quartoNum;

                        Console.Write("Induza um primeiro valor: ");
                        primeiroNum = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Introduza um segundo valor: ");
                        segundoNum = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Introduza um terceiro valor: ");
                        terceiroNum = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Introduza um quarto valor: ");
                        quartoNum = Convert.ToDouble(Console.ReadLine());

                        double resultado3 = primeiroNum / segundoNum + terceiroNum + quartoNum;
                        resultado1 = Convert.ToDouble(resultado3);

                        double resultado4 = segundoNum / primeiroNum + terceiroNum + quartoNum;
                        resultado4 = Convert.ToDouble(resultado4);

                        double resultado5 = terceiroNum / primeiroNum + segundoNum + quartoNum;
                        resultado5 = Convert.ToDouble(resultado5);

                        double resultado6 = quartoNum / primeiroNum + segundoNum + terceiroNum;
                        resultado6 = Convert.ToDouble(resultado6);


                        if (resultado3 < resultado4 && resultado3 < resultado5 && resultado3 < resultado6)
                        {
                            Console.WriteLine("Após a divisão do valor {0} com a soma dos restantes valores {1}, {2} e {3} resulta o valor {4} sendo identificado como o menor resultado.", primeiroNum, segundoNum, terceiroNum, quartoNum, resultado3);
                        }
                        if (resultado4 < resultado3 && resultado4 < resultado5 && resultado4 < resultado6)
                        {
                            Console.WriteLine("Após a divisão do valor {0} com a soma dos restantes valores {1}, {2} e {3} resulta o valor {4} sendo identificado como o menor resultado.", segundoNum, primeiroNum, terceiroNum, quartoNum, resultado4);
                        }
                        if (resultado5 < resultado3 && resultado5 < resultado4 && resultado5 < resultado6)
                        {
                            Console.WriteLine("Após a divisão do valor {0} com a soma dos restantes valores {1}, {2} e {3} resulta o valor {4} sendo identificado como o menor resultado.", terceiroNum, primeiroNum, segundoNum, quartoNum, resultado5);
                        }
                        if (resultado6 < resultado3 && resultado6 < resultado4 && resultado6 < resultado5)
                        {
                            Console.WriteLine("O valor indentificado como menor é {0}, após a divisão do valor atribuido a {1} com a soma dos restantes valores {2}, {3} e {4}", resultado6, quartoNum, primeiroNum, segundoNum, terceiroNum);
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        decimal z;
                        decimal y;   // ou float x = 2.3454;

                        Console.Write("Introduza um valor para Z: ");
                        z = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Introduza um valor para Y: ");
                        y = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("O valor de Z dividindo por Y é: {0}", decimal.Round((z / y), 2));

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        int E;
                        int F;

                        Console.Write("Introduza um número para E: ");
                        E = Convert.ToInt32(Console.ReadLine()); // ou E = int.Parse(Console.ReadLine());

                        Console.Write("Introduza um número para F: ");
                        F = Convert.ToInt32(Console.ReadLine()); // ou F = int.Parse(Console.ReadLine());

                        Console.WriteLine("O resultado da multiplicação entre o número atribuido a E: {0} e o número atribuido a F: {1} é de {2}", E, F, (E * F));
                        int resultado = E * F;

                        if (resultado % 2 == 0)
                            Console.WriteLine("Bizz");
                        else
                            Console.WriteLine("Buzz");

                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case 6:
                        double number1, number2, result = 0;
                        string operador;

                        Console.WriteLine("Introduz o primeiro número: ");
                        number1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduz o sinal da operação a realizar: ");
                        operador = Console.ReadLine();

                        Console.WriteLine("Introduz o segundo número: ");
                        number2 = Convert.ToDouble(Console.ReadLine());


                        switch (operador)
                        {
                            case "+":
                                result = number1 + number2;
                                break;
                            case "-":
                                result = number1 - number2;
                                break;
                            case "*":
                                result = number1 * number2;
                                break;
                            case "/":
                                result = number1 / number2;
                                break;
                            default:
                                Console.WriteLine("Operação inválida.");
                                break;
                        }
                        Console.WriteLine("{0}{1}{2} = {3}", number1, operador, number2, result);
                        break;
                }

            } while ((exercicio > 6 || exercicio < 1) && counter < 11);
 } while (exercicio != 0);


        }


    
    }
}
