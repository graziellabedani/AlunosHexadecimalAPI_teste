using AlunosHexadecimalAPI.Domain.Entites; 

namespace AlunosHexadecimalAPI.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Task<Aluno?> GetByEmail(string email);
        Task<Aluno> SaveAluno(Aluno aluno);

        Task<List<Aluno>> ListingAluno();
        Task GetById(int id);
    }
}
