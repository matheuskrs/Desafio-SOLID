using SOLID.ISP.Solucao.Interfaces;

namespace SOLID.ISP.Solucao.Models
{
    public class Geladeira : IRefrigerador
    {
        public void Esfriar()
        { 
           /* 
             Nesse caso, a geladeira está usando somente a função da qual ela depende para funcionar 
           */
        }
    }
}
