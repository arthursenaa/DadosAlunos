namespace AlunosDadosCompleto
{
    public class Sala
    {
        public int NumeroSala{get;set;}
        public int CapacidadeAtual{get;set;}
        public int CapacidadeTotal{get;set;}
        public string[] Alunos{get;set;}

        public string AlocarAluno(string nomeAluno){
            if (CapacidadeAtual != 0){
                CapacidadeAtual--;
                Alunos[CapacidadeAtual] = nomeAluno;
                return $"Aluno {nomeAluno} cadastrado com sucesso!";
            } else {
                return "Não há vagas!";
            }
        }
    }
}