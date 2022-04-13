public class Exercicio1{
    public void Questao(){
        int x, y;

        Console.WriteLine("Digite o primeiro número: ");
        x = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Digite o segundo número: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (x > y){
            Console.WriteLine($"O número {x} é o maior.");
        }else if(y > x){
            Console.WriteLine($"O número {y} é o maior.");
        }else{
            Console.WriteLine("Os números são iguais.");
        }
    }
}