using Microsoft.EntityFrameworkCore;
using BlogPessoal.src.data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlogPessoal.src.modelos;
using System.Linq;

namespace BlogPessoalTeste.Testes.data
{
    [TestClass]
    public class BlogPessoalContextoTeste
    {
        private BlogPessoalContexto _contexto;

        [TestInitialize]
        public void inicio()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
                .UseInMemoryDatabase(databaseName: "db_blogpessoal")
                .Options;

            _contexto = new BlogPessoalContexto(opt);
        }

        [TestMethod]
        [Ignore]
        public void InserirNovoUsuarioNoBancoRetornaUsuario()
        {
            UsuarioModelo Usuario = new UsuarioModelo();

            Usuario.Nome = "Caroline Polimeno";
            Usuario.Email = "cabs26@email.com";
            Usuario.Senha = "050500";
            Usuario.Foto = "LINKDAFOTO";

            _contexto.Usuarios.Add(Usuario);

            _contexto.SaveChanges();

            Assert.IsNotNull(_contexto.Usuarios.FirstOrDefault(u => u.Email == "cabs26@email.com"));
        }
    }
}
