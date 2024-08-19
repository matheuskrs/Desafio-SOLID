namespace SOLID.LSP.Solucao.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public abstract bool ValidarDocumento();
    }
}
