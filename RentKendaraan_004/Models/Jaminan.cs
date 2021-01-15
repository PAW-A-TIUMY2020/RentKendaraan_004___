using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_004.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string NamaJaminan { get; set; }
    }
}
