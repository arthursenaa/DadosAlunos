using System;

namespace AlunosDadosCompleto {
    class Program {
        static void Main (string[] args) {
            bool sair = false;
            int contadorAluno = 0, contadorSala = 0;

            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[5];

            do {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine ("*** Bem-Vindo ***");
                Console.ResetColor ();
                System.Console.WriteLine ("1 - Cadastrar Aluno\n2 - Cadastrar Sala \n3 - Alocar Aluno\n4 - Remover Aluno\n5 - Verificar Salas\n6 - Verificar Alunos\n0 - Sair");
                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:

                        if (contadorAluno < 4) {
                            Aluno a = new Aluno ();
                            System.Console.Write ("Nome Do Aluno: ");
                            a.Nome = Console.ReadLine ();
                            System.Console.Write ("Digite a Data de Nascimento: ");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());
                            System.Console.Write ("Digite o nome do Curso: ");
                            a.Curso = Console.ReadLine ();

                            alunos[contadorAluno] = a;
                            contadorAluno++;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine ("Cadastro efetuado com sucesso!!!");
                            Console.ResetColor ();
                        } //Fim if

                        break;
                    case 2:
                        if (contadorSala < 5) {
                            Sala s = new Sala ();
                            System.Console.Write ("Digite o número da sala: ");
                            s.NumeroSala = int.Parse (Console.ReadLine ());
                            System.Console.Write ("Capacidade Total: ");
                            s.CapacidadeTotal = int.Parse (Console.ReadLine ());

                            s.CapacidadeAtual = s.CapacidadeTotal;
                            s.Alunos = new string[s.CapacidadeTotal];
                            salas[contadorSala] = s;
                            contadorSala++;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine ("Cadastro efetuado com sucesso!!!\nAperte a tecla enter para voltar ao menu");
                            Console.ResetColor ();
                        } //Fim If
                        break;
                    case 3:
                        if (contadorAluno == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há aluno cadastrado \n Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        if (contadorSala == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há sala cadastrada \n Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoAloc = Console.ReadLine ();

                        Aluno alunoRecuperadoAloc = null;

                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoAloc.Equals (item.Nome)) {
                                alunoRecuperadoAloc = item;
                                break;
                            } //Fim if    
                        }

                        if (alunoRecuperadoAloc == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há aluno cadastrado com o nome {nomeAlunoAloc}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                        continue;                            
                        }

                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaAloc = int.Parse(Console.ReadLine ());

                        Sala salaRecuperadaAloc = null;

                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaAloc.Equals (item.NumeroSala)){
                                salaRecuperadaAloc = item;
                                break;
                            } //Fim if    
                        }

                        if (salaRecuperadaAloc == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há sala cadastrada com o numero {numeroSalaAloc}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                        continue; 
                        }
                        
                        break;
                    case 4:
                        
                        if (contadorSala == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há sala cadastrada \n Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        System.Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaRem = int.Parse(Console.ReadLine ());
                        int SalaRem;
                        Sala salaRem = null;

                        foreach (Sala item in salas) {
                            if (item != null && salaRem.Equals (item.NumeroSala)) {
                                SalaRem = item;
                                break;
                            } //Fim if    
                        }

                        if (numeroSalaRem == 0){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há sala cadastrado com o número {numeroSalaRem}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                        continue;
                        }

                    break;
                    case 5:
                        foreach (var item in salas) {
                            if (item != null) {

                                System.Console.WriteLine ($"-----------------");
                                System.Console.WriteLine ($"Número da sala {item.NumeroSala}");
                                System.Console.WriteLine ($"Vagas Disponíveis {item.CapacidadeAtual}");
                            } //Fim If
                        } //Fim Foreach
                        System.Console.WriteLine ("Aperte enter para continuar");
                        Console.ReadLine ();
                        
                    break;
                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                Console.WriteLine ($"-----------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                System.Console.WriteLine ($"Curso do aluno: {item.Curso}");
                            }
                        }
                        System.Console.WriteLine ("Aperte enter para continuar");
                        Console.ReadLine ();
                        break;
                }

            } while (!sair);

        }
    }
}