namespace SOLID.OCP.Solucao
{
    public class Calculadora
    {
        public double Calcular(double a, double b, Operacao operacao) => operacao.Calcular(a, b);
    }
}
