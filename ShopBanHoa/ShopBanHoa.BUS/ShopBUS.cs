
using ShopBanHoa.DAO;
using ShopBanHoa.DTO;


namespace ShopBanHoa.BUS
{
    public class ShopBUS
    {
        private ShopDAO shopDAO;
        public ShopBUS()
        {
            shopDAO = new ShopDAO();
        }
        public void Insert(SanPham sp)
        {
            shopDAO.Insert(sp);
        }
        public void Delete(string maSP)
        {
            shopDAO.Delete(maSP);
        }
        public void Update(string maSP, string tenSP, string loaiSP, int giaBan, int soLuong)
        {
            shopDAO.Update(maSP,tenSP,loaiSP,giaBan,soLuong);
        }
    }
    
}
