using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.View_Models
{
    public  class QLChieuCaoDeGiayView
    {
        public Guid Id { get; set; }
        public string MaKichCo { get; set; } = null!;
        public int KichCo { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;
    }
}
