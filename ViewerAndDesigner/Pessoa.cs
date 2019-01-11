using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewerAndDesigner
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //public string  TesteOutro { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public Pessoa()
        {
            Enderecos = new List<Endereco>();
        }
    }

    public class Help
    {
        public static List<Pessoa> RetornarPessoas()
        {
            var pessoas = new List<Pessoa>();

            for (int i = 0; i < 5000; i++)
            {
                var pessoa = new Pessoa()
                {
                    Id = i,
                    Nome = $"Nome pessoa {i}",
                    //Enderecos = BuscarEndereco(i)
                };
                pessoas.Add(pessoa);
            }
            return pessoas;
        }

        private static List<Endereco> BuscarEndereco(int pessoa)
        {
            var enderecos = new List<Endereco>();
            for (int i = 0; i < 5; i++)
            {
                enderecos.Add(new Endereco()
                {
                    Id = i,
                    Logradouro = $"Av. Paraná {i} {pessoa}",
                    Numero = pessoa
                });
            }
            return enderecos;
        }
    }

    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}