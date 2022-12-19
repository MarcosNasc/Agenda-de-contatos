namespace Agenda.Models
{
    public class Entity
    {
        public int Id { get;  set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        public Entity()
        {
            DataCriacao = DateTime.Now;
            DataAtualizacao = DateTime.Now;
        }

        public void SetDataAtualizacao()
        {
            DataAtualizacao = DateTime.Now;
        }
    }
}
