public class Exercicio20{
    public void Questao(){
        double lado1, lado2, lado3;
        int tri = 0;

        Console.WriteLine("Digite o primeiro lado do triângulo: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo lado do triângulo: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro lado do triângulo: ");
        lado3 = Convert.ToDouble(Console.ReadLine());

        if((lado1 + lado2) > lado3 && (lado1 + lado3) > lado2 && (lado2 + lado3) > lado1){
            tri = 1;
        }
        
        if(tri == 1){
            if(lado1 == lado2 && lado1 == lado3){
                Console.WriteLine("O triângulo é equilátero");
            }else if((lado1 == lado2 && lado1 != lado3) || (lado2 == lado3 && lado2 != lado1) || (lado3 == lado1 && lado3 != lado2)){
                Console.WriteLine("O triângulo é isósceles");
            }else{
                Console.WriteLine("O triângulo é escaleno");
            }
        }else{
            Console.WriteLine("Esses lados não formam um triângulo");
        }
    }
}