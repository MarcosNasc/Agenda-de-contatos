using Agenda.Models;

namespace Agenda.Services.Interfaces
{
    public interface IContatoService
    {
        IEnumerable<Contato>? ListarTodos();
        Contato? BuscarPorId(int id);
        Contato Adicionar(Contato contato);
        Contato Atualizar(Contato contato);
        void Remover(int id);
    }
}
