namespace SOLID.LSP.Violacao
{
    public abstract class Automovel
    {
        public string Nome { get; set; }
        public decimal PrecoLitro { get; set; }
        public decimal QuilometrosPorLitro { get; set; }
        public abstract decimal CombustivelPorKm(decimal distanciaEmQuilometros);
    }
}