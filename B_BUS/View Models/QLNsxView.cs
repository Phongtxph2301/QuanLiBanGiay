using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.View_Models
{
    public class QLNsxView
    {
        public Guid Id { get; set; }
        public string MaNsx { get; set; } = null!;
        public string TenNsx { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
    }
}
