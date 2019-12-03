using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc2.Models;
using SalesWebMvc2.Models.Enums;

namespace SalesWebMvc2.Data
{
    public class SeedingService
    {
        //Injeção de dependências desta classe/serviço com a classe SalesWebMvc2Context
        //Quando um 'SeedingService' for criado, automaticamente ele vai receber uma
        //instância da Context também.
        private SalesWebMvc2Context _context;

        public SeedingService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        //Operação que será responsável por popular a base de dados.
        public void Seed()
        {
            //Testando se já existe algum registro nas seguintes tabelas, na base de dados:
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                //Se já existir algum registro, interromperá a execução do método 'Seed()'.
                //DB has been seeded (O banco de dados já foi populado.)
                return;
            }

            //Instanciando os objetos:
            //WorkFlow 'codeFirst':

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Luiz Marcello", "luizmarcello.vmo@hotmail.com", new DateTime(1961, 4, 10), 1000.00, d1);
            Seller s2 = new Seller(2, "Valeria Miranda de Oliveira", "valeriamo2008@hotmail.com", new DateTime(1981, 6, 18), 1500.00, d3);
            Seller s3 = new Seller(3, "Natalia Renata", "nataliaNefretiri@gmail.com", new DateTime(1996, 12, 3), 1200.00, d3);
            Seller s4 = new Seller(4, "Gabriel Issac", "GabrielIsaac@gmail.com", new DateTime(2012, 2, 20), 2000.00, d2);
            Seller s5 = new Seller(5, "Luiz Claudio da Silva", "luizclaudio@gmail.com", new DateTime(1986, 7, 13), 2500.00, d4);
            Seller s6 = new Seller(6, "José Gomes da Silva", "josesilva@gmail.com", new DateTime(1966, 10, 10), 1890.00, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Pending, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Canceled, s4);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Pending, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Canceled, s4);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s5);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);

            //Adicionando(incluindo) os objetos na base de dados:
            //Usando o Entity-Framework:

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17,
                r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            //Efetivando(salvando) as aletrações na base de dados:
            _context.SaveChanges();
        }
        
    }
}

    
