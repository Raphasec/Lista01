public class Exercicio24{
    public void Questao(){
        double valorh, qtdh, ir = 0, bruto, fgts = 0.11, liquido, sindicato = 0.03, totalDescontos;

        Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
        qtdh = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da hora: ");
        valorh = Convert.ToDouble(Console.ReadLine());

        bruto = qtdh * valorh;

        if(bruto >= 0 && bruto < 1903.98){
            ir = 0;
        }else if(bruto >= 1903.98 && bruto < 2826.65){
            ir = 0.075;
        }else if(bruto >= 2826.65 && bruto < 3751.05){
            ir = 0.15;
        }else if(bruto >= 3751.05 && bruto < 4664.68){
            ir = 0.225;
        }else if(bruto >= 4664.68){
            ir = 0.275;
        }

        totalDescontos = (bruto * ir) + (bruto * sindicato);
        liquido = bruto - totalDescontos;

        Console.WriteLine($"\nHoras Trabalhadas:         {qtdh:F2}");
        Console.WriteLine($"Valor da hora:            R$ {valorh:F2}");
        Console.WriteLine($"Salário Bruto:            R$ {bruto:F2}");
        Console.WriteLine($"Sálario IR:               R$ {bruto * ir:F2}");
        Console.WriteLine($"Salário Sindicato:        R$ {bruto * sindicato:F2}");
        Console.WriteLine($"FGTS:                     R$ {bruto * fgts:F2}");
        Console.WriteLine($"Total de descontos:       R$ {totalDescontos:F2}");
        Console.WriteLine($"Salário Líquido:          R$ {liquido:F2}");
    }
}