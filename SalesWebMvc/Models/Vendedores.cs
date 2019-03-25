using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Vendedores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamentos Departamento { get; set; }
        public ICollection<RegistroDeVendas> RegistroDeVendas { get; set; } = new List<RegistroDeVendas>();

        public Vendedores()
        {
        }

        public Vendedores(int id, string nome, string email, DateTime aniversario, double salarioBase, Departamentos departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(RegistroDeVendas registroVenda)
        {
            RegistroDeVendas.Add(registroVenda);
        }

        public void RemoveVenda(RegistroDeVendas registroVendas)
        {
            RegistroDeVendas.Add(registroVendas);
        }

        public double TotalDeVendas(DateTime inicio, DateTime final)
        {
            return RegistroDeVendas.Where(rg => rg.DataDaVenda >= inicio && rg.DataDaVenda <= final).Sum(rg => rg.Valor);
        }
    }
}
