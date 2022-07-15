using ApiRestNet5.Model; 
using ApiRestNet5.Repositorio; 
using System.Collections.Generic; 

namespace ApiRestNet5.Negocio.Implementations
{
    public class PessoaNegocio : IPessoaNegocio
    {
        private readonly IPessoaRepositorio ipessoarepositorio;
        public PessoaNegocio(IPessoaRepositorio _ipessoarepositorio)
        {
            ipessoarepositorio = _ipessoarepositorio;
        }
       public PessoaModel  Alterar(PessoaModel pessoa)
        {
            return ipessoarepositorio.Alterar(pessoa);
        }

        public PessoaModel Cadastrar(PessoaModel Pessoa)
        {
            return ipessoarepositorio.Cadastrar(Pessoa);
        }

        public void Deletar(long Id)
        {
            ipessoarepositorio.Deletar(Id);
        }

        public PessoaModel PesquisarPorId(long Id)
        {
            return ipessoarepositorio.PesquisarPorId(Id);

        }

        public List<PessoaModel> PesquisarTodos()
        {
            return ipessoarepositorio.PesquisarTodos();
        }
     
    }
}
