namespace SOLID.OCP.Solucao.Models
{
    public class Soma : Operacao
    {
        public override double Calcular(double a, double b) => a + b;
    }
}
