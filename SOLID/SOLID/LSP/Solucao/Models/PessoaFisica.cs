namespace SOLID.LSP.Solucao.Models
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public override bool ValidarDocumento()
        {
            /*
             A pessoa física ainda é uma pessoa, só que dessa vez tem CPF
             então é possível validar o documento, e ela ainda pode ser substituída pela classe pai (ou o contrário)
            */
            return true;
        }
    }
}
