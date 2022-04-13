public class Exercicio14{
    public void Questao(){
        int num1, num2, num3; 

        Console.WriteLine("Digite um número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite outro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite outro número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2 && num1 > num3){
            Console.WriteLine($"O maior número é {num1}");
        }else if(num2 > num1 && num2 > num3){
            Console.WriteLine($"O maior número é {num2}");
        }else if(num3 > num1 && num3 > num2){
            Console.WriteLine($"O maior número é {num3}");
        }
    }
}