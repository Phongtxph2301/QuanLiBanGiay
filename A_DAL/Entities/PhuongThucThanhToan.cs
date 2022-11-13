namespace A_DAL.Entities
{
    public class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ChiTietThanhToans = new HashSet<ChiTietThanhToan>();
        }
        public Guid Id { get; set; }
        public string MaNsx { get; set; } = null!;
        public string TenNsx { get; set; } = null!;
        public ICollection<ChiTietThanhToan> ChiTietThanhToans { get; set; }
    }
}
