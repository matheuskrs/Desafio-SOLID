using System;

public class Calculadora
{
    public double Calcular(double a, double b, string operacao)
    {
        if (operacao == "soma")
            return a + b;
        else if (operacao == "subtracao")
            return a - b;
        else
            throw new InvalidOperationException("Operação não suportada");
    }
}