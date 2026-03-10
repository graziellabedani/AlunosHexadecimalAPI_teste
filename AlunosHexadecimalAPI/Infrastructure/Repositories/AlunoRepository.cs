using AlunosHexadecimalAPI.Domain.Entites;
using AlunosHexadecimalAPI.Domain.Interfaces;
using static AlunosHexadecimalAPI.Infrastructure.Repositories.AlunoRepository;

namespace AlunosHexadecimalAPI.Infrastructure.Repositories { 

        public class AlunoRepository : IAlunoRepository
        {
            private static List<Aluno> _alunos = new List<Aluno>();
            public Task<Aluno?> GetByEmail(string email)
            {
                var aluno = _alunos.FirstOrDefault(s => s.Email == email);
                return Task.FromResult(aluno);
            }

            public Task<List<Aluno>> ListingAluno()
            {
                return Task.FromResult(_alunos);
            }

            public Task<Aluno> SaveAluno(Aluno aluno)
            {
                _alunos.Add(aluno);
                return Task.FromResult(aluno);
            }
        }
    
}
