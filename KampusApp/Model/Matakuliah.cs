using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KampusApp.Model
{
    public class Matakuliah
    {
        [Key]
        public int IdMatakuliah { get; set; }

        [Required]
        public string Nama_Matakuliah { get; set; }

        public int NIM { get; set; }
    }
}
