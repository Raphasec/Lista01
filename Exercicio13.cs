public class Exercicio13{
    public void Questao(){
        int x, y, z;

        Console.WriteLine("Digite um valor para X: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite um valor para Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Antes os valores de X e Y eram, respectivamente: {x} e {y}\n");

        z = x;
        x = y;
        y = z;

        Console.WriteLine($"Agora os valores de X e Y são, respectivamente: {x} e {y}");
    }
}