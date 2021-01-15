using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_004.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh di isi angka")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage ="No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage ="No HP maksimal 13 angka")]
        public string NoHp { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? IdGender { get; set; }
    }
}
