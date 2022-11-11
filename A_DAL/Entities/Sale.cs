namespace A_DAL.Entities
{
    public class Sale
    {
        public Sale()
        {
            ChiTietSales = new HashSet<ChiTietSale>();
        }
        public Guid Id { get; set; }
        public string MaGiamGia { get; set; } = null!;
        public string TenChuongTrinh { get; set; } = null!;
        public int LuaChonGiamGia { get; set; } = 0!;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietSale> ChiTietSales { get; set; }
    }
}
