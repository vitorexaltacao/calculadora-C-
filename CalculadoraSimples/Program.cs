using System; // Importa o namespace System para usar funcionalidades básicas

class Program // Define a classe principal do programa
{
    static void Main(string[] args) // Método principal onde a execução do programa começa
    {
        // Exibe uma mensagem de boas-vindas
        Console.WriteLine("Bem vindo à Calculadora");
        
        // Pede para o usuário escolher uma operação
        Console.WriteLine("Escolha uma operação: (+, -, *, /)");

        // Lê a operação escolhida e verifica se a entrada não é nula
        string? operacaoInput = Console.ReadLine();
        
        if (string.IsNullOrEmpty(operacaoInput))
        {
            // Caso a entrada seja nula ou vazia, exibe uma mensagem e encerra o programa
            Console.WriteLine("Nenhuma operação foi selecionada.");
            return;
        }
        
        // Armazena o primeiro caractere da operação
        char operacao = operacaoInput[0];

        // Solicita o primeiro número
        Console.WriteLine("Digite o primeiro número:");

        // Lê e converte a entrada para double
        double num1;
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida para o primeiro número.");
            return;
        }

        // Solicita o segundo número
        Console.WriteLine("Digite o segundo número:");

        // Lê e converte a entrada para double
        double num2;
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida para o segundo número.");
            return;
        }

        // Inicializa a variável resultado
        double resultado = 0;

        // Estrutura de decisão para realizar a operação escolhida
        switch (operacao)
        {
            case '+': // Se a operação for adição
                resultado = num1 + num2; // Calcula a soma
                break;
            case '-': // Se a operação for subtração
                resultado = num1 - num2; // Calcula a diferença
                break;
            case '*': // Se a operação for multiplicação
                resultado = num1 * num2; // Calcula o produto
                break;
            case '/': // Se a operação for divisão
                if (num2 != 0) // Verifica se o divisor não é zero
                    resultado = num1 / num2; // Calcula a divisão
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return;
                }
                break;
            default: // Se a operação não for válida
                Console.WriteLine("Operação inválida.");
                return;
        }

        // Exibe o resultado da operação
        Console.WriteLine($"O resultado da operação é: {resultado}");
    }
}
