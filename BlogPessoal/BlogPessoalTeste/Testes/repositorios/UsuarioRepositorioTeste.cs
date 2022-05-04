using System.Linq;
using BlogPessoal.src.data;
using BlogPessoal.src.dtos;
using BlogPessoal.src.repositorios;
using BlogPessoal.src.repositorios.implementacoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogPessoalTest.Testes.repositorios
{
    [TestClass]
    public class UsuarioRepositorioTeste
    {
        private BlogPessoalContexto _contexto;
        private IUsuario _repositorio;
        [TestInitialize]
        public void ConfiguracaoInicial()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
            .UseInMemoryDatabase(databaseName: "db_blogpessoal")
            .Options;
            _contexto = new BlogPessoalContexto(opt);
            _repositorio = new UsuarioRepositorio(_contexto);
        }
        [TestMethod]
        public void CriarQuatroUsuariosNoBancoRetornaQuatroUsuarios1()
        {
            //GIVEN - Dado que registro 4 usuarios no banco
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Guilherme Grillo",
            "guigs@email.com",
            "12343652",
            "URLFOTO"));
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Carol Polimeno",
            "cabs@email.com",
            "134652",
            "URLFOTO"));
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Pamela Alencar",
            "pamits@email.com",
            "134652",
            "URLFOTO"));
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Junior Tavarez",
            "juninho@email.com",
            "134652",
            "URLFOTO"));
            //WHEN - Quando pesquiso lista total
            //THEN - Então recebo 4 usuarios
            Assert.AreEqual(4, _contexto.Usuarios.Count());
        }
        [TestMethod]
        public void PegarUsuarioPeloEmailRetornaNaoNulo2()
        {
            //GIVEN - Dado que registro um usuario no banco
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Calleri",
            "tocanele@email.com",
            "134652",
            "URLFOTO"));
            //WHEN - Quando pesquiso pelo email deste usuario
            var user = _repositorio.PegarUsuarioPeloEmail("tocanele@email.com");
            //THEN - Então obtenho um usuario
            Assert.IsNotNull(user);
        }
        [TestMethod]
        public void PegarUsuarioPeloIdRetornaNaoNuloENomeDoUsuario3()
        {
            //GIVEN - Dado que registro um usuario no banco
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Jorel",
            "jojo@email.com",
            "134652",
            "URLFOTO"));
            //WHEN - Quando pesquiso pelo id 6
            var user = _repositorio.PegarUsuarioPeloId(_contexto.Usuarios.FirstOrDefault(u => u.Email == "jojo@email.com").Id);
            //THEN - Então, deve me retornar um elemento não nulo
            Assert.IsNotNull(user);
            //THEN - Então, o elemento deve ser Neusa Boaz
            Assert.AreEqual("Jorel", user.Nome);
        }
        [TestMethod]
        public void AtualizarUsuarioRetornaUsuarioAtualizado8()
        {
            //GIVEN - Dado que registro um usuario no banco
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Bruno",
            "brunin@email.com",
            "134652",
            "URLFOTO"));
            //WHEN - Quando atualizamos o usuario
            var antigo =
            _repositorio.PegarUsuarioPeloEmail("brunin@email.com");
            _repositorio.AtualizarUsuario(
            new AtualizarUsuarioDTO(
            _contexto.Usuarios.FirstOrDefault(u => u.Email == "brunin@email.com").Id,
            "lobinho",
            "123456",
            "URLFOTONOVA"));
            //THEN - Então, quando validamos pesquisa deve retornar nome Estefânia Moura
            Assert.AreEqual(
            "lobinho",
            _contexto.Usuarios.FirstOrDefault(u => u.Id == antigo.Id).Nome);
            //THEN - Então, quando validamos pesquisa deve retornar senha 123456
            Assert.AreEqual(
            "123456",
            _contexto.Usuarios.FirstOrDefault(u => u.Id ==
            antigo.Id).Senha);
        }
    }
}
