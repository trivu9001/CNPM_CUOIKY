using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopBanHoa.DAO;
using ShopBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHoa.DAO.Tests
{
    [TestClass()]
    public class ShopDAOTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            SanPham sp = new SanPham("SP123", "Hoa Hong", "A", 1000000, 100);
            ShopDAO shop = new ShopDAO();
            bool result = shop.Insert(sp);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            ShopDAO shop = new ShopDAO();
            bool result = shop.Delete("sp");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void DeleteTestNull()
        {
            ShopDAO shop = new ShopDAO();
            bool result = shop.Delete("");
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void UpdateTest()
        {
            ShopDAO shop = new ShopDAO();
            bool result = shop.Update("SP12", "Hoa Hong", "A", "1000000", "10");
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void UpdateTestfail()
        {
            ShopDAO shop = new ShopDAO();
            bool result = shop.Update("SP12", "", "A", "1000000", "10");
            Assert.AreEqual(false, result);
        }
    }
}