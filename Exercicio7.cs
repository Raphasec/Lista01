public class Exercicio7{
    public void Questao(){
        string turno, pl;

        Console.WriteLine("Digite o seu turno: ");
        turno = Console.ReadLine();

        pl = turno.Substring(0,1);
        turno = pl.ToUpper();

        if(turno == "M"){
            Console.WriteLine("Bom dia!");
        }else if(turno == "V"){
            Console.WriteLine("Boa tarde");
        }else if(turno == "N"){
            Console.WriteLine("Boa Noite");
        }else{
            Console.WriteLine("Valor Inválido");
        }
    }
}