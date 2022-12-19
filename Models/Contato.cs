using Agenda.ViewModels;

namespace Agenda.Models
{
    public class Contato : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Whatsapp { get; private set; }
        public string Instagram { get; private set; }
        public string Telegram { get; private set; }
        public bool Status { get; private set; }

        public Contato(
            string nome,
            string email,
            string telefone,
            string whatsapp,
            string instagram,
            string telegram
            )
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Whatsapp = whatsapp;
            Instagram = instagram;
            Telegram = telegram;
            Status = Status;
        }

        public Contato() { }

        public  Contato ViewModelToEntity(AdicionarContatoViewModel viewModel)
        {
            Contato contato = new Contato();
            contato.Nome = viewModel.Nome;
            contato.Email = viewModel.Email;
            contato.Telefone = viewModel.Telefone;
            contato.Whatsapp = viewModel.Whatsapp;
            contato.Instagram  =  viewModel.Instagram;
            contato.Telegram =  viewModel.Telegram;
            contato.Status = viewModel.Status;
            return contato;
        }

        public  Contato ViewModelToEntity(EditarContatoViewModel viewModel)
        {
            Contato contato = new Contato();
            contato.Id = viewModel.Id;
            contato.Nome = viewModel.Nome;
            contato.Email = viewModel.Email;
            contato.Telefone = viewModel.Telefone;
            contato.Whatsapp = viewModel.Whatsapp;
            contato.Instagram = viewModel.Instagram;
            contato.Telegram = viewModel.Telegram;
            contato.Status = viewModel.Status;
            return contato;
        }

    }
}
