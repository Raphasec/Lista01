public class Exercicio2{
    public void Questao(){
        int valor;

        Console.WriteLine("Digite um valor: ");
        valor = Convert.ToInt32(Console.ReadLine());
        if(valor > 0){
            Console.WriteLine("O valor é positivo");
        }else if(valor < 0){
            Console.WriteLine("O valor é negativo");
        }else{
            Console.WriteLine("O valor é nulo");
        }
    }
}