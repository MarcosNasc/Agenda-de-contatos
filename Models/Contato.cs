using Agenda.Dtos;

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

        public  Contato DtoToEntity(AdicionarContatoDTO dto)
        {
            Contato contato = new Contato();
            contato.Nome = dto.Nome;
            contato.Email = dto.Email;
            contato.Telefone = dto.Telefone;
            contato.Whatsapp = dto.Whatsapp;
            contato.Instagram  =  dto.Instagram;
            contato.Telegram =  dto.Telegram;
            contato.Status = dto.Status;
            return contato;
        }

        public  Contato DtoToEntity(EditarContatoDTO dto)
        {
            Contato contato = new Contato();
            contato.Id = dto.Id;
            contato.Nome = dto.Nome;
            contato.Email = dto.Email;
            contato.Telefone = dto.Telefone;
            contato.Whatsapp = dto.Whatsapp;
            contato.Instagram = dto.Instagram;
            contato.Telegram = dto.Telegram;
            contato.Status = dto.Status;
            return contato;
        }

    }
}
