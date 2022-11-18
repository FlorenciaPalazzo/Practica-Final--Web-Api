using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalPalazzoFlorencia.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public int IdHospital { get; set; }
        [ForeignKey("IdHospital")]
      

        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }


        //Navegacion
        public Hospital Hospital { get; set; }
    }
}
