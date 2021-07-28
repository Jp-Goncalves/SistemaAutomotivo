namespace Domain.Model
{
    public class Modelo
    {
        public virtual int ModeloId { get; set; }
        public virtual string Nome { get; set; }
        public virtual Marca Marca { get; set; }
    }
}