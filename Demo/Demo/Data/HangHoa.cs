﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Demo.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHh { get; set; }
        [Required]
        [MaxLength(250)]
        public string TenHh { get; set; }
        public string MoTa { get; set; }
        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
        public int? MaLoai { get; set; }

        [ForeignKey(nameof(MaLoai))]
        public Loai Loai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public HangHoa()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
