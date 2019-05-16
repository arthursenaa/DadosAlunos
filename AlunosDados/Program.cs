using System;

namespace AlunosDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //SalaDados[] sala = new SalaDados[5];
            Classe[] aluno = new Classe[i];
            //Classe[] sala = new Classe[3];
            
            Console.WriteLine("*** BEM-VINDO ***");
            for (i = 0 ; i <= 2; i++)
            {
                System.Console.WriteLine("1 - Cadastrar Aluno\n2 - Cadastrar Sala \n3 - Alocar Aluno\n4 - Remover Aluno\n5 - Verificar Salas\n6 - Verificar Alunos\n0 - Sair");

                System.Console.Write("Escolha o número de uma opção:");
                int opcao = int.Parse(Console.ReadLine());
                System.Console.WriteLine(" ");
                switch(opcao){

                    case 1:
                        Classe alunos = new Classe();
                        System.Console.Write("Nome do Aluno:");
                        alunos.nome = Console.ReadLine();
                        System.Console.Write($"Digite o Curso:");
                        alunos.curso = Console.ReadLine();
                        System.Console.Write($"Número da Sala do {alunos.nome}:");
                        int numSala = alunos.numSala = int.Parse(Console.ReadLine());                                           
                    
                        aluno[0] = alunos;
                        
                    break;
                    case 2:
                        Classe DadosSala = new Classe();
                        System.Console.Write("Número da Sala:");
                        DadosSala.numSala = int.Parse(Console.ReadLine());
                        System.Console.Write("Capacidade da Sala:");
                        DadosSala.capacidadeTotal = int.Parse(Console.ReadLine());

                        aluno[i] = DadosSala; 
                    break;
                    // case 6:
                    //     System.Console.WriteLine("Qual  nome do Aluno?");
                    //     string xxx = Console.ReadLine();
                    // break;
                    case 5:
                        System.Console.Write("Qual o Número da Sala:");
                        Console.ReadLine();

                        System.Console.WriteLine(aluno[0]); 
                    break;
                    case 6:
                        System.Console.WriteLine("Nome do aluno a ser verificado");
                        string nome = Console.ReadLine();
                        if(nome)
                        
                        System.Console.WriteLine(aluno[]);
                    break;
                    case 0:
                    
                    break;
                }
            }
        }
    }
}
