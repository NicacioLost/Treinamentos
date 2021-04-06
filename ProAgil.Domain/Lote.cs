namespace ProAgil.Domain
{
    public class Lote
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public DataTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int Quantidade { get; set; }
        public int EventoId { get; set; }
        public 	Evento Evento { get; set; }
    }
}