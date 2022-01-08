
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
        public bool Insert(SanPham sp)
        {
            return shopDAO.Insert(sp);
        }
        public bool Delete(string maSP)
        {
            return shopDAO.Delete(maSP);
        }
        public bool Update(string maSP, string tenSP, string loaiSP, string giaBan, string soLuong)
        {
            return shopDAO.Update(maSP, tenSP, loaiSP, giaBan, soLuong);
        }
    }

}
