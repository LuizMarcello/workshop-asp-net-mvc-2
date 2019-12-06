using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2.Services;

namespace SalesWebMvc2.Controllers
{
    public class SellersController : Controller
    {
        //Criando uma injeção de dependência desta classe/serviço com o SellerService:
        //Irá receber então, uma instância de SellerService.
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            //Esta variável receberá uma lista de 'Sellers'
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}