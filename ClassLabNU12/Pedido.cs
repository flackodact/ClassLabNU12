using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNU12
{
    internal class Pedido
    {
        //idped  data  status_ped  desconto  idcli_ped iduser_ped 
        // Atributos 

        // Propriedades
        public int Id { get; set; }
        public DateTime DatePed { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuarios Usuarios { get; set; }
        public List<ItemPedido> Itens { get; set; }

        // Construtores 
        public Pedido() { }

        public Pedido(DateTime datePed, double desconto, Cliente cliente, Usuarios usuarios, List<ItemPedido> itens)
        {
            DatePed = datePed;
            Desconto = desconto;
            Cliente = cliente;
            Usuarios = usuarios;
            Itens = itens;
        }

        public Pedido(int id, DateTime datePed, double desconto, Cliente cliente, Usuarios usuarios, List<ItemPedido> itens)
        {
            Id = id;
            DatePed = datePed;
            Desconto = desconto;
            Cliente = cliente;
            Usuarios = usuarios;
            Itens = itens;
        }
        // Métodos de classe - Operações/Ações/Funções
        public void Inserir() { }
        public bool Alterar (Pedido pedido)
        {
            return false;
        
        }
        public static Pedido ConsultarPorId(int _id)
        {
            Pedido pedido = new Pedido();
            // graça...conecta ao realiza a consulta  pelo id do pedido 
            return pedido;
        }
        public static List<Pedido> ConsultarPorClienteId(int _id)
        {  
            
            List<Pedido> pedido = new List<Pedido>();
            //grça...conecta ao e realiza a consulta pelo id do pedido 
            return pedido;

            
        } 
       
            


    }



}
