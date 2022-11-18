using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalEngelstajnSebastian.Model
{
    [Table("Hospital")]
    public class Hospital
    {
        [Required]
        [Key]
        public int HospitalId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Direccion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Telefono { get; set; }
        public int? Num_Cama { get; set; }

        #region Navegacion  
        public List<Doctor> Doctors { get; set; }
        #endregion

    }
}
