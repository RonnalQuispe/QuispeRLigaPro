using System.ComponentModel.DataAnnotations;

namespace QuispeRLigaPro.Models
{
    public class Equipo
    {
            [Key]
            public int Id { get; set; }
        [Required]
        [MaxLength(20)]
            public String Nombre { get; set; }
        [Range(0,100)]
            public int PartidosJugados { get; set; }
        [Range(0, 100)]
            public int PartidosGanados { get; set; }
        [Range(0, 100)]
            public int PartidosEmpatados { get; set; }
            public int PartidosPerdidos { get; set; }
        public int TotalPuntos
        {
            get
            {
                return (PartidosGanados * 3) + PartidosEmpatados;
            }
        }




    }
}
