using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; } = new List<Vendedores>();

        public Departamentos()
        {
        }

        public Departamentos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedores vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalDeVendas(DateTime inicio, DateTime final)
        {
            return Vendedores.Sum(vend => vend.TotalDeVendas(inicio, final));
        }
    }
}
