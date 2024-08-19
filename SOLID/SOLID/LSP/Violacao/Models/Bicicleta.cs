namespace SOLID.LSP.Violacao.Models
{
    public class Bicicleta : Automovel
    {
        public string Modelo { get; set; }

        public override decimal CombustivelPorKm(decimal distanciaEmQuilometros)
        {
            /*
                Bicicleta não é um automóvel, e não tem gasolina, então a herança não dá certo.
            */
            return 0;
        }
    }
}
