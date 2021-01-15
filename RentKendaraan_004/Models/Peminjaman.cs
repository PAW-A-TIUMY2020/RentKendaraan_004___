using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_004.Models
{
    public partial class Peminjaman
    {
        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? IdKendaraan { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? IdCustomer { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? Biaya { get; set; }
    }
}
