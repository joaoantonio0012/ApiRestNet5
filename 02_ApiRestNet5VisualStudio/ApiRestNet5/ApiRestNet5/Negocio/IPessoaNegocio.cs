using ApiRestNet5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestNet5.Negocio
{
    public interface IPessoaNegocio
    {
        PessoaModel Cadastrar(PessoaModel Pessoa);
        PessoaModel PesquisarPorId(long Id);
        List <PessoaModel> PesquisarTodos();
        PessoaModel Alterar(PessoaModel pessoa);
        void  Deletar(long Id);
         
    }
}
