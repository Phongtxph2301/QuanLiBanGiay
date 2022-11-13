using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.View_Models
{
    public class QLTheLoaiView
    {
        public Guid Id { get; set; }
        public string MaTheLoai { get; set; } = null!;
        public string TenTheLoai { get; set; } = null!;
        public Guid IdPhanCap { get; set; }
        public int TrangThai { get; set; } = 0!;
    }
}
