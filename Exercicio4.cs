public class Exercicio4{
    public void Questao(){
        string vogais = "aeiou";
        string letra;

        Console.WriteLine("Digite uma letra");
        letra = Console.ReadLine();
        if(vogais.Contains(letra)){
            Console.WriteLine("A letra digitada é uma vogal");
        }else{
            Console.WriteLine("A letra digitada é uma consoante");
        }
    }
}