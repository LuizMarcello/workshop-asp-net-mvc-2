using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc2.Models;

namespace SalesWebMvc2.Services
{
    public class SellerService
    {
        //Criando uma injeção de dependência desta classe/serviço com o dbContext:
        //Irá receber então, uma instância de dbContect.
        private readonly SalesWebMvc2Context _context;

        public SellerService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        //Operação para retornar uma lista com todos os vendedores do banco de dados.
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
