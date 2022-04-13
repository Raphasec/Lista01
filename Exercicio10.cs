public class Exercicio10{
    public void Questao(){
        double raio, diametro, pi = 3.1415926535897931, comprimento, area;

        Console.WriteLine("Digite o raio da circunferência (em metros): ");
        raio = Convert.ToDouble(Console.ReadLine());

        diametro = 2 * raio;
        comprimento = 2 * pi * raio;
        area = pi * (raio * raio);

        Console.WriteLine($"O diametro da circunferência mede {diametro} metros");
        Console.WriteLine($"O comprimento da circunferência é de {comprimento:F2} metros");
        Console.WriteLine($"A área da circunferência é de {area:F2} metros");
    }
}