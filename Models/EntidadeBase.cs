namespace CatalogoSerie.Models
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public EntidadeBase(int id)
        {
            this.Id = id;
        }
    }
}