using System;

namespace SOLID.SRP.Violacao
{
    public class Item
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        // Setor de reembolsos
        public void CriarOrdemDeServicoParaReembolso() { /*...*/ }

        // Contexto de pagamentos
        public void ConfirmarPagamento() { /*...*/ }
        public void GerarRelatorioDeLucro() { }

    }
}
