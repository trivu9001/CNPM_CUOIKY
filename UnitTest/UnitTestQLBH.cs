using DAO;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTestQLBH
    {
        
        [TestMethod()]
        public void DeleteNVTest()
        {
            NhanVienDAO nhanvien = new NhanVienDAO();
            bool result = nhanvien.Delete("nv");
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void DeleteLLVTest()
        {
            LichLamViecDAO lichlamviec = new LichLamViecDAO();
            bool result = lichlamviec.Delete("nv");
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void DeleteTestNull()
        {
            LichLamViecDAO lichlamviec = new LichLamViecDAO();
            bool result = lichlamviec.Delete("");
            Assert.AreEqual(false, result);
        }

        
        

    }
}
