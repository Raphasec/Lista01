public class Exercicio11{
    public void Questao(){
        int idade;

        Console.WriteLine("Digite sua idade: ");
        idade = Convert.ToInt16(Console.ReadLine());

        if(idade >= 18 && idade <= 67){
            Console.WriteLine("Você pode doar sangue.");
        }else{
            Console.WriteLine("Você não pode doar sangue.");
        }
    }
}