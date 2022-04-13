public class Exercicio5{
    public void Questao(){
        double nota1, nota2, media;

        Console.WriteLine("Digite a primeira nota parcial do aluno: ");
        nota1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite a segunda nota parcial do aluno: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2)/ 2;

        if(media == 10){
            Console.WriteLine("Aprovado com louvor!!!");
        }else if(media < 10 && media >=7){
            Console.WriteLine("Aprovado!!!");
        }else {
            Console.WriteLine("Reprovado.");
        }
    }
}