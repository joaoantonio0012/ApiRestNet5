using ApiRestNet5.Model;
using ApiRestNet5.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ApiRestNet5.Repositorio.Implementations
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private MySqlContext _context;
        public PessoaRepositorio(MySqlContext context)
        {
            _context = context;
        }
        public PessoaModel Alterar(PessoaModel pessoa)
        {
            if (!Exite(pessoa.Id))
                return new PessoaModel();

            var result = _context.pessoas.SingleOrDefault(p => p.Id.Equals(pessoa.Id));

            if (result != null)
            {


                try
                {
                    _context.Entry(result).CurrentValues.SetValues(pessoa);
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return pessoa;
        }

        public PessoaModel Cadastrar(PessoaModel Pessoa)
        {
            try
            {
                _context.Add(Pessoa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Pessoa;
        }

        public void Deletar(long Id)
        {
            var result = _context.pessoas.SingleOrDefault(p => p.Id.Equals(Id));
            if (result != null)
            {
                try
                {
                    _context.pessoas.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        public PessoaModel PesquisarPorId(long Id)
        {
            return _context.pessoas.SingleOrDefault(p => p.Id == Id);

        }

        public List<PessoaModel> PesquisarTodos()
        {
            return _context.pessoas.ToList();
        }
        public bool Exite(long Id)
        {
            return _context.pessoas.Any(p => p.Id == Id);
        }
    }
}
