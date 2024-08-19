using SOLID.ISP.Violacao.Interfaces;
using System;

namespace SOLID.ISP.Violacao.Models
{
    public class Geladeira : IEletrodomestico
    {
        public void Aquecer() { throw new NotImplementedException(); }
        public void Esfriar()
        {        
            /*
                (A geladeira está sendo forçada a depender de funções das quais ela não realmente necessita)
            */
        }
        public void Triturar() { throw new NotImplementedException(); }
    }
}
