public class Exercicio19{
    public void Questao(){
        double nota1, nota2, media;

        Console.WriteLine("Digite a primeira nota parcial do aluno: ");
        nota1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite a segunda nota parcial do aluno: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2)/ 2;

        if(media >= 0 && media < 4){
            Console.WriteLine("\nE - REPROVADO!!!");
        }else if(media >= 4 && media < 6){
            Console.WriteLine("\nD - REPROVADO!!!");
        }else if(media >= 6 && media < 7.5){
            Console.WriteLine("\nC - APROVADO!!!");
        }else if(media >= 7.5 && media < 9){
            Console.WriteLine("\nB - APROVADO!!!");
        }else if(media >= 9 && media <= 10){
            Console.WriteLine("\nA - APROVADO!!!");
        }
    }
}