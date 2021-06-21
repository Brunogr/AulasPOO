using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2.POO.Restaurante.Dominio
{
    public class Comanda
    {
        private Guid id;
        private List<Pedido> pedidos;
        private Atendente atendente;
        private int nrMesa;
        private decimal valorPago;
        private bool aberta;

        public Comanda(int nrMesa)
        {
            id = Guid.NewGuid();
            this.nrMesa = nrMesa;
            aberta = true;
            pedidos = new List<Pedido>();
            valorPago = 0.0M;
        }

        private bool ComandaEstaAberta()
        {
            if (!aberta)
            {
                Console.WriteLine("Não pode adicionar pedidos a uma comanda fechada!");
            }

            return aberta;
        }

        public void AdicionarPedido(Pedido pedido)
        {
            if (!ComandaEstaAberta())
                return;

            pedidos.Add(pedido);
        }

        public void RemoverPedido(Pedido pedido)
        {
            if (!ComandaEstaAberta())
                return;

            pedidos.Remove(pedido);
        }

        public void EfetuarPagamento(decimal valor)
        {
            if (valor > ValorRestanteASerPago())
            {
                Console.WriteLine("O valor pago está maior que o valor da comanda!");
                return;
            }

            valorPago += valor;
        }

        public decimal ValorTotal()
        {
            return pedidos.Sum(pedido => pedido.ValorPedido());
        }

        public decimal ValorRestanteASerPago()
        {
            return ValorTotal() - valorPago;
        }

        public bool FecharComanda()
        {
            if (valorPago >= ValorTotal())
                aberta = false;
            else
                Console.WriteLine("Não é possível fechar a comanda! O valor total não foi pago.");

            return !aberta;
        }

    }
}
