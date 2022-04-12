class Program
{
    static void Main(string[] args){
        int repet = 0;
        do{
            Console.Clear();
            Console.WriteLine("Escolha qual exercício deseja abrir (1-24): ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch(x){
                //Exercício 1
                case 1:
                //Criação das variáveis
                    string resp1;
                    string fl1;
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio1 ex1 = new Exercicio1();
                    ex1.Questao1();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp1 = Console.ReadLine();
                    fl1 = resp1.Substring(0,1);
                    resp1 = fl1.ToUpper();
                    if(resp1 == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercício 2
                case 2:
                //Criação das variáveis
                    string resp2;
                    string fl2;
                    Console.Clear();
                    repet = 0;
                    
                //Chamada do procedimento
                    Exercicio2 ex2 = new Exercicio2();
                    ex2.Questao2();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp2 = Console.ReadLine();
                    fl2 = resp2.Substring(0,1);
                    resp2 = fl2.ToUpper();
                    if(resp2 == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercício 3
                case 3:
                //Criação das variáveis
                    string resp3;
                    string fl3;
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio3 ex3 = new Exercicio3();
                    ex3.Questao3();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp3 = Console.ReadLine();
                    fl3 = resp3.Substring(0,1);
                    resp3 = fl3.ToUpper();
                    if(resp3 == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercício 4
                case 4:
                //Criação das variáveis
                    string resp4;
                    string fl4;
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio4 ex4 = new Exercicio4();
                    ex4.Questao4();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp4 = Console.ReadLine();
                    fl4 = resp4.Substring(0,1);
                    resp4 = fl4.ToUpper();
                    if(resp4 == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 5
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