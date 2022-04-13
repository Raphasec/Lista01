public class Exercicio8{
    public void Questao(){
        Console.WriteLine("-------------");
        Console.WriteLine("Calculadora");
        Console.WriteLine("-------------");

        Console.WriteLine("Digite o valor 1:");
        string e1 = Console.ReadLine();
        Console.WriteLine("Digite o valor 2:");
        string e2 = Console.ReadLine();

        double x = Convert.ToDouble(e1);
        double y = Convert.ToDouble(e2);

        double soma = x + y;
        double subtracao = x - y;
        double multiplicacao = x * y;
        
        Console.WriteLine("Qual operação deseja realizar? +, -, * ou /?");
        string op = Console.ReadLine();

        if (op == "+"){
            Console.WriteLine($"\nA soma de {x} e {y} é: {soma}.");
            if((soma % 2) == 0){
                Console.WriteLine("O resultado da operação é um número par");
            }else{
                Console.WriteLine("O resultado da operação é um número ímpar");
            }
            if(soma >= 0){
                Console.WriteLine("O resultado é positivo");
            }else{
                Console.WriteLine("O resultado é negativo");
            }
        }else if (op == "-"){
            Console.WriteLine($"\nA subtração de {x} e {y} é: {subtracao}.");
            if((subtracao % 2) == 0){
                Console.WriteLine("O resultado da operação é um número par");
            }else{
                Console.WriteLine("O resultado da operação é um número ímpar");
            }  
            if(subtracao >= 0){
                Console.WriteLine("O resultado é positivo");
            }else{
                Console.WriteLine("O resultado é negativo");
            }
        }else if (op == "*"){
            Console.WriteLine($"\nA multiplicação de {x} e {y} é: {multiplicacao}.");
            if((multiplicacao % 2) == 0){
                Console.WriteLine("O resultado da operação é um número par");
            }else{
                Console.WriteLine("O resultado da operação é um número ímpar");
            }
            if(multiplicacao >= 0){
                Console.WriteLine("O resultado é positivo");
            }else{
                Console.WriteLine("O resultado é negativo");
            }
        }
        else if(op == "/"){
            if (y == 0){
                
                System.Console.WriteLine("\nO divisor não pode ser nulo");
            
            }else{
                double divisao = x / y;
                Console.WriteLine($"\nA divisão de {x} e {y} é: {divisao:F4}.");
                if((divisao % 2) == 0){
                Console.WriteLine("O resultado da operação é um número par");
                }else{
                Console.WriteLine("O resultado da operação é um número ímpar");
                }
                if(divisao >= 0){
                Console.WriteLine("O resultado é positivo");
                }else{
                Console.WriteLine("O resultado é negativo");
                }
            }
        }
    }
}