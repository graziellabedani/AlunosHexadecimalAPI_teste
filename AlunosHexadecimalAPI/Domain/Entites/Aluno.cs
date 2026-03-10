namespace AlunosHexadecimalAPI.Domain.Entites
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Email { get; set;}

        internal bool IsNullOrWhiteSapece(object name)
        {
            throw new NotImplementedException();
        }
    }
}
