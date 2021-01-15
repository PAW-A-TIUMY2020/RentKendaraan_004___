using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_004.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string NoPolisi { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string NoStnk { get; set; }


        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
    }
}
