public class Exercicio23{
    public void Questao(){
        double salario, salarionovo;//a1 = 0.2, a2 = 0.15, a3 = 0.1, a4 = 0.05;

        Console.WriteLine("Digite o salário: ");
        salario = Convert.ToDouble(Console.ReadLine());

        if(salario <= 280){
            salarionovo = salario + (salario * 0.2);

            Console.WriteLine($"\nO salário antes era de: {salario:F2}");
            Console.WriteLine("O percentual aplicado foi 20%");
            Console.WriteLine($"O aumento foi de {salario * 0.2:F2}");
            Console.WriteLine($"O salario novo é de: {salarionovo:F2}");
        }else if(salario > 280 && salario < 700){
            salarionovo = salario + (salario * 0.15);
            
            Console.WriteLine($"\nO salário antes era de: {salario:F2}");
            Console.WriteLine("O percentual aplicado foi 15%");
            Console.WriteLine($"O aumento foi de {salario * 0.15:F2}");
            Console.WriteLine($"O salario novo é de: {salarionovo:F2}");
        }else if(salario >= 700 && salario < 1500){
            salarionovo = salario + (salario * 0.1);
            
            Console.WriteLine($"\nO salário antes era de: {salario:F2}");
            Console.WriteLine("O percentual aplicado foi 10%");
            Console.WriteLine($"O aumento foi de {salario * 0.1:F2}");
            Console.WriteLine($"O salario novo é de: {salarionovo:F2}");
        }else if(salario >= 1500){
            salarionovo = salario + (salario * 0.05);
            
            Console.WriteLine($"\nO salário antes era de: {salario:F2}");
            Console.WriteLine("O percentual aplicado foi 5%");
            Console.WriteLine($"O aumento foi de {salario * 0.05:F2}");
            Console.WriteLine($"O salario novo é de: {salarionovo:F2}");
        }
    }
}