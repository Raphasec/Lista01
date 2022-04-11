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
                    string resp1;
                    Console.Clear();
                    repet = 0;

                    Exercicio1 ex1 = new Exercicio1();
                    ex1.Questao1();

                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp1 = Console.ReadLine();
                    resp1 = resp1.ToUpper();
                    if(resp1 == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                case 2:
                    string resp2;
                    Console.Clear();
                    repet = 0;
                    
                    Exercicio2 ex2 = new Exercicio2();
                    ex2.Questao2();

                     Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp2 = Console.ReadLine();
                    resp2 = resp2.ToUpper();
                    if(resp2 == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
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