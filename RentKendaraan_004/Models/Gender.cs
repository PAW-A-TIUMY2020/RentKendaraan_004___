using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_004.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string NamaGender { get; set; }
    }
}
