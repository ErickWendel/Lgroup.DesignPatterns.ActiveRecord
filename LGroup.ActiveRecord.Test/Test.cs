using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using LGroup.ActiveRecord.Model;


namespace LGroup.ActiveRecord.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Cadastrar() {
            var novoContato = new ContatoModel();
            novoContato.Nome = "Zeh";
            novoContato.Email = "Zeh@ig.com.br";
            novoContato.DataNascimento = DateTime.Now ;
            novoContato.Telefone = "012345678901234";
            novoContato.CodigoSexo = 1;
            novoContato.CodigoEstadoCivil = 2;

            novoContato.Cadastrar();
        }

        [Test]
        public void Listar()
        {
            var contato = new ContatoModel();
            var listado = contato.Listar();

            string x = "";
        }
    }
}
