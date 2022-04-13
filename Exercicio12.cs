using System;
    public class Exercicio12{
    public void Questao(){
        DateTime momento = DateTime.Now;
        int dia, mes, ano, anoatual;

        anoatual = momento.Year;

        Console.WriteLine("Digite o dia do seu nascimento");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o mes do seu nascimento");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o ano do seu nascimento");
        ano = Convert.ToInt32(Console.ReadLine());

        if((dia <= 30 && dia > 0) && (mes <= 12  && mes > 0) && (ano > 0 && ano < anoatual)){
            Console.WriteLine("A data é válida");
        }else if(dia > 30 || dia <= 0 ){
            Console.WriteLine("A data é inválida pois o valor do dia não é válido");
        }else if(mes > 12 || mes <= 0){
            Console.WriteLine("A data é inválida pois o valor do mês não é válido");
        }else if(ano > anoatual || ano <= 0){
            Console.WriteLine("A data é inválida pois o valor do ano não é válido");
        }
    }
}