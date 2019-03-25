using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime DataDaVenda { get; set; }
        public double Valor { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedores Vendedor { get; set; }

        public RegistroDeVendas()
        {
        }

        public RegistroDeVendas(int id, DateTime dataDaVenda, double valor, StatusVenda status, Vendedores vendedor)
        {
            Id = id;
            DataDaVenda = dataDaVenda;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
