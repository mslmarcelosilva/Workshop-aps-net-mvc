using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Servicos
{
    public class ServicoVendedores
    {
        private readonly SalesWebMvcContext _context;

        public ServicoVendedores(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedores> FindAll()
        {
            return _context.Vendedores.ToList();
        }
    }
}
