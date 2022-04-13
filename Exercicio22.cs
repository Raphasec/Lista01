public class Exercicio22{
    public void Questao(){
        int numAno;

        Console.WriteLine("Digite um número correspondente a um ano: ");
        numAno = Convert.ToInt32(Console.ReadLine());

        if((numAno % 4 == 0 && numAno % 100 != 0) || (numAno % 100 == 0 && numAno % 400 == 0)){
            Console.WriteLine("O ano é bissexto"!);
        }else{
            Console.WriteLine("O ano não é bissexto");
        }
    }
}