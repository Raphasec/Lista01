public class Exercicio21{
    public void Questao(){
        double a, b, c, delta, x1, x2;

        Console.WriteLine("-------------------------");
        Console.WriteLine("Calculadora do 2 grau");
        Console.WriteLine("-------------------------");

        Console.WriteLine("\nDigite o valor de A: ");
        a = Convert.ToDouble(Console.ReadLine());
        
         if(a != 0){
             Console.WriteLine("\nDigite o valor de B: ");
             b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = (b * b) - 4 * a * c;

            if(delta == 0){
                x1 = -b / (2*a);
                Console.WriteLine($"A equação possui apenas a raiz {x1:F2}");
            }else if(delta > 0){
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                
                Console.WriteLine($"As raízes são {x1:F2} e {x2:F2}");
            }else{
                Console.WriteLine("A equação não possui raízes reais!");
            }

        }else{
            Console.WriteLine("\nA equação não é do segundo grau\n");
        }
    }
}