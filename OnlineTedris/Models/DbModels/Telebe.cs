using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class Telebe
    {
        public int ID { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email Address Səhvdir")]
        public string Email { get; set; }
        [Required]
        public string Shifre { get; set; }
        [Required]
        public string Soyadi { get; set; }
        [Required]
        public string Adi { get; set; }
        public string Ata_adi { get; set; }
        public bool? Cins { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tevellud { get; set; }
        public string Shekil { get; set; }
        public string TelebeKodu { get; set; }
        public List<TelebeSebet> telebeSebets { get; set; }
        public List<TelebeHesab> telebeHesabs { get; set; }
        public List<Odenisfenn> odenisfenns { get; set; }
        public List<TelebeninKursu> telebeninKursus { get; set; }
    }
}