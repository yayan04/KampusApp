using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KampusApp.Model
{
    public class Akademik
    {
        [Key]
        public int IDAkademik { get; set; }

        public int NIM { get; set; }

        public string NamaMahasiswa { get; set; }

        public int IDMatakuliah { get; set; }

        public string NamaMatakuliah { get; set; }


    }
}
