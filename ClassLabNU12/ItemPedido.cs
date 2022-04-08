using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNU12
{
    internal class ItemPedido
    {
        //idped_ip idprod_ip valor quantidade desconto
        // Atributos
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;

        // propriedades 

        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
       
    
    
    
    
    }
}
