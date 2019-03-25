using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Servicos;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly ServicoVendedores _servicoVendedores;

        public VendedoresController(ServicoVendedores servicoVendedores)
        {
            _servicoVendedores = servicoVendedores; 
        }

        public IActionResult Index()
        {
            var list = _servicoVendedores.FindAll();
            return View(list);
        }
    }
}