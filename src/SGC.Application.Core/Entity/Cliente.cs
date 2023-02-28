namespace SGC.Application.Core.Entity
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }

        public Cliente()
        {
        }
    }
}