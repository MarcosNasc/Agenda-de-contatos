namespace Agenda.Dtos
{
    public class EditarContatoDTO : DTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }
        public string Instagram { get; set; }
        public string Telegram { get; set; }
        public bool Status { get; set; }
    }
}
