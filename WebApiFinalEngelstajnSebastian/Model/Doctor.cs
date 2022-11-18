using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalEngelstajnSebastian.Model
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        [Required]
        public int DoctorId { get; set; }
        
        [Required]
        [ForeignKey("idHospital")]
        public int idHospital { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Apellido { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Especialidad { get; set; }

        #region Navegacion
        public Hospital hospital { get; set; }
        #endregion

    }
}
