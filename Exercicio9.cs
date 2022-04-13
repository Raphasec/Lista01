public class Exercicio9{
    public void Questao(){
        Console.WriteLine("----------------------");
        Console.WriteLine("Investigação Criminal!");
        Console.WriteLine("-----------------------");

        int respSim = 0;
        string resposta;
        string pl;

        Console.WriteLine("Telefonou para a vítima? S/N");
        resposta = Console.ReadLine();
        pl = resposta.Substring(0, 1);
        resposta = pl;
        if(resposta == "S"){
            respSim++;
        }

        Console.WriteLine("Esteve no local do crime? S/N");
        resposta = Console.ReadLine();
        pl = resposta.Substring(0, 1);
        resposta = pl;
        if(resposta == "S"){
            respSim++;
        }

        Console.WriteLine("Mora perto da vítima? S/N");
        resposta = Console.ReadLine();
        pl = resposta.Substring(0, 1);
        resposta = pl;
        if(resposta == "S"){
            respSim++;
        }

        Console.WriteLine("Devia para a vítima? S/N");
        resposta = Console.ReadLine();
        pl = resposta.Substring(0, 1);
        resposta = pl;
        if(resposta == "S"){
            respSim++;
        }

        Console.WriteLine("Já trabalhou com a vítima? S/N");
        resposta = Console.ReadLine();
        pl = resposta.Substring(0, 1);
        resposta = pl;
        if(resposta == "S"){
            respSim++;
        }

        if (respSim == 2){
            Console.WriteLine("A pessoa é SUSPEITA!");
        }else if((respSim == 3) || (respSim == 4)){
            Console.WriteLine("A pessoa é cúmplice!!!");
        }else if(respSim == 5){
            Console.WriteLine("A pessoa é uma ASSASSINA!!!!!!!");
        }else{
            System.Console.WriteLine("A pessoa é inocente");
        }
    }
}