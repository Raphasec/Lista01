public class Exercicio17{
    public void Questao(){
        double peso, altura, imc;

        Console.WriteLine("Digite seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nDigite seu altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso/altura;
        
        Console.WriteLine($"O valor do seu imc é {imc}\n");

        if(imc < 18.5){
            Console.WriteLine("Peso Baixo");
        }else if(imc >= 18.5 && imc < 25){
            Console.WriteLine("Peso Normal");
        }else if(imc >= 25 && imc < 30){
            Console.WriteLine("Sobrepeso");
        }else if(imc >= 30 && imc < 35){
            Console.WriteLine("Obesidade");
        }else if(imc >= 35 && imc < 40){
            Console.WriteLine("Obesidade severa");
        }else if(imc >= 40){
            Console.WriteLine("Obesidade mórbida");
        }
    }
}