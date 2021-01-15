using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_004.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public DateTime? TglPengembalian { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
    }
}
