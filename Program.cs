class Program
{
    static void Main(string[] args){
        int repet = 0;
        do{
            Console.Clear();
            Console.WriteLine("Escolha qual exercício deseja abrir (1-24): ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch(x){
                case 1:
                    string resp;
                    Console.Clear();
                    repet = 0;
                    Exercicio1 ex1 = new Exercicio1();
                    ex1.Questao();
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    resp = resp.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                case 2:
                    break;
                default:
                    repet = 1;
                    Console.WriteLine("Erro!!! Tente novamente pressionando ENTER");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }while(repet != 0);
    }
}