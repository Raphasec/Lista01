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
                    string resp;
                    string fl;
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio1 ex1 = new Exercicio1();
                    ex1.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercício 2
                case 2:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;
                    
                //Chamada do procedimento
                    Exercicio2 ex2 = new Exercicio2();
                    ex2.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercício 3
                case 3:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio3 ex3 = new Exercicio3();
                    ex3.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercício 4
                case 4:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio4 ex4 = new Exercicio4();
                    ex4.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 5
                case 5:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio5 ex5 = new Exercicio5();
                    ex5.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 6
                case 6:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio6 ex6 = new Exercicio6();
                    ex6.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 7
                case 7:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio7 ex7 = new Exercicio7();
                    ex7.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 8
                case 8:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio8 ex8 = new Exercicio8();
                    ex8.Questao();

                 //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 9
                case 9:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;
                
                //Chamada do procedimento
                    Exercicio9 ex9 = new Exercicio9();
                    ex9.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 10
                case 10:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio10 ex10 = new Exercicio10();
                    ex10.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 11
                case 11:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio11 ex11 = new Exercicio11();
                    ex11.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 12
                case 12:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;
                
                //Chamada do procedimento
                    Exercicio12 ex12 = new Exercicio12();
                    ex12.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 13                
                case 13:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio13 ex13 = new Exercicio13();
                    ex13.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 14
                case 14:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;
                
                //Chamada do procedimento
                    Exercicio14 ex14 = new Exercicio14();
                    ex14.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 15
                case 15:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio15 ex15 = new Exercicio15();
                    ex15.Questao();
                
                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 16
                case 16:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;
                
                //Chamada do procedimento
                    Exercicio16 ex16 = new Exercicio16();
                    ex16.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 17
                case 17:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;
                
                //Chamada do procedimento
                    Exercicio17 ex17 = new Exercicio17();
                    ex17.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 18
                case 18:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio18 ex18 = new Exercicio18();
                    ex18.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 19
                case 19:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio19 ex19 = new Exercicio19();
                    ex19.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
                    break;
                //Exercicio 20
                case 20:
                //Criação das variáveis
                    Console.Clear();
                    repet = 0;

                //Chamada do procedimento
                    Exercicio20 ex20 = new Exercicio20();
                    ex20.Questao();

                //Repetição do programa
                    Console.WriteLine("Deseja tentar novamente? [S/N]");
                    resp = Console.ReadLine();
                    fl = resp.Substring(0,1);
                    resp = fl.ToUpper();
                    if(resp == "S"){
                        repet = 1;
                        Console.Clear();
                    }else{
                        break;
                    }
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