using AlunosHexadecimalAPI.Domain.Entites;
using AlunosHexadecimalAPI.Domain.Interfaces;
using System.Globalization;

namespace AlunosHexadecimalAPI.Application.ServiceApp
{
    public class AlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<Aluno> Enrrol(Aluno aluno)
        {

            if (string.IsNullOrWhiteSpace(aluno.Name))
            {
                throw new Exception("O nome do estudante é obrigatório.");
            }

            if (aluno.Name.Length > 50)
            {
                throw new Exception("O nome do estudante não pode exceder 50 caracteres.");
            }

            if (!aluno.Email.EndsWith("@faculdade.edu"))
            {
                throw new Exception("E-mail invalido.");
            }

            var existingAluno = await _alunoRepository.GetByEmail(aluno.Email);
            if (existingAluno != null)
            {
                throw new Exception("Já existe estudante com esse e-mail.");
            }
            return await _alunoRepository.SaveAluno(aluno);

            
        }

        public async Task<List<Aluno>> ListingAluno()
        {
            return await _alunoRepository.ListingAluno();
        }

    }
}
