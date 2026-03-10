using AlunosHexadecimalAPI.Application.ServiceApp;
using AlunosHexadecimalAPI.Domain.Entites;
using Microsoft.AspNetCore.Mvc;



namespace AlunosHexadecimalAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService _alunoService;

        public AlunoController(AlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> Enroll(Aluno aluno)
        {
            var result = await _alunoService.Enrrol(aluno);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<Aluno>>> GetAll()
        {
            var result = await _alunoService.ListingAluno();
            return Ok(result);
        }
    }
}
