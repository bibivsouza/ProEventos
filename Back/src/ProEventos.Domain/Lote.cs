using System;

namespace ProEventos.Domain
{
    public class Lote
    {

        public Lote()
        {

        }
        public Lote(int id, string nome, decimal preco, int quantidade, int eventoId)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.EventoId = eventoId;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int Quantidade { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}