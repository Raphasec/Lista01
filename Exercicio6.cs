public class Exercicio6{
    public void Questao(){
        double preco1, preco2, preco3;
        string prod1, prod2, prod3;

        Console.WriteLine("Digite o nome do primeiro produto: ");
        prod1 = Console.ReadLine();
        Console.WriteLine("Agora digite o preço: ");
        preco1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nDigite o nome do segundo produto: ");
        prod2 = Console.ReadLine();
        Console.WriteLine("Agora digite o preço: ");
        preco2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nDigite o nome do terceiro produto: ");
        prod3 = Console.ReadLine();
        Console.WriteLine("Agora digite o preço: ");
        preco3 = Convert.ToDouble(Console.ReadLine());

        if(preco1 < preco2 && preco1 < preco3){
            Console.WriteLine($"Compre o/a {prod1}");
        }
        else if(preco2 < preco1 && preco2 < preco3){
            Console.WriteLine($"Compre o/a {prod2}");
        }
        else if(preco3 < preco2 && preco3 < preco1){
            Console.WriteLine($"Compre o/a {prod3}");
        }
    }
}