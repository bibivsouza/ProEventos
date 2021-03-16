using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        public Palestrante()
        {
            
        }
        public Palestrante(int id, string nome, string miniCurriculo, string imagemURL, string telefone, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.MiniCurriculo = miniCurriculo;
            this.ImagemURL = imagemURL;
            this.Telefone = telefone;
            this.Email = email;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}