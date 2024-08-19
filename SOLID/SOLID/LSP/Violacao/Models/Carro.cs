namespace SOLID.LSP.Violacao.Models
{
    public class Carro : Automovel
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }

        public override decimal CombustivelPorKm(decimal distanciaEmQuilometros)
            => PrecoLitro * (distanciaEmQuilometros / QuilometrosPorLitro);

        /*
            Carro é um automóvel, e se encaixa no modelo corretamente, porém o modelo não é flexível o suficiente 
            para se adaptar em outros casos, como na bicicleta.
         */
    }
}
