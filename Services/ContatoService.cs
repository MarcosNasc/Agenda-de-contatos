using Agenda.Models;
using Agenda.Repository.Iterfaces;
using Agenda.Services.Interfaces;

namespace Agenda.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IGenericRepository<Contato> _repository;

        public ContatoService(IGenericRepository<Contato> repository)
        {
            _repository = repository;
        }

        public Contato Adicionar(Contato contato)
        {
            return _repository.Insert(contato);
        }

        public Contato Atualizar(Contato contato)
        {
             return _repository.Update(contato);
        }

        public Contato? BuscarPorId(int id)
        {
            var contato = _repository.Get(id).Result;
            return contato;
        }

        public IEnumerable<Contato>? ListarTodos()
        {
            var contatos = _repository.GetAll().Result;
            return contatos;
        }

        public void Remover(int id)
        {
            _repository.Delete(id);
        }
    }
}
