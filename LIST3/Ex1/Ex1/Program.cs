using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dog = new Cachorro("test1dog", "test1raca", true);
            Cachorro dog2 = new Cachorro("test2dog", "test2raca", false);
            Pessoa pessoa = new Pessoa("teste1pessoa", 40955973805);

            PetShop ptshop = new PetShop();

            ptshop.AddPessoa(pessoa);
            ptshop.AddCachorro(pessoa.Cpf, dog);
            ptshop.AddCachorro(pessoa.Cpf, dog2);

            Console.WriteLine("listar pessoas:");
            ptshop.Listar();
            Console.WriteLine("listar dogs:");
            ptshop.ListarCachorros();
            Console.WriteLine("listar dogs vacinados:");
            ptshop.ListarVacinados(true);
            Console.WriteLine("listar dogs não vacinados:");
            ptshop.ListarVacinados(false);
            ptshop.RmvCachorro(pessoa.Cpf, "test1dog");
            Console.WriteLine("listar dogs:");
            ptshop.ListarCachorros();

            Console.Read();
        }
    }
}
