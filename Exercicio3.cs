public class Exercicio3{

    public void Questao3(){
        string sexo;

        Console.WriteLine("Digite uma letra: ");
        sexo = Console.ReadLine();
        sexo = sexo.ToUpper();
        if(sexo == "M"){
            Console.WriteLine("M - Masculino");
        }else if(sexo == "F"){
            Console.WriteLine("F - Feminino");
        }else{
            Console.WriteLine("Sexo Inválido");
        }
    }
}