using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KampusApp.Model
{
    public class Mahasiswa
    {
        [Key]
        public int NIM { get; set; }

        [Required]
        public string Nama { get; set; }

        public string Alamat { get; set; }
    }
}
