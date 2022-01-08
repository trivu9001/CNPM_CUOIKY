using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BUS.Tests
{
    [TestClass()]
    public class ChiTietGioHangBUSTests
    {
        [TestMethod()]
        public void themVaoGioHangTest()
        {
            int result = ChiTietGioHangBUS.Instance.themVaoGioHang("SP001", 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void xoaGioHangTest()
        {
            int result = ChiTietGioHangBUS.Instance.xoaGioHang("SP001");
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void updateGioHangTest()
        {
            int result = ChiTietGioHangBUS.Instance.updateGioHang("SP001", "20");
            Assert.AreNotSame(0, result);


        }

        [TestMethod()]
        public void themVaoGioHangTest1()
        {
            int result = ChiTietGioHangBUS.Instance.themVaoGioHang("SP001", 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void xoaGioHangTest1()
        {
            int result = ChiTietGioHangBUS.Instance.xoaGioHang("SP009");
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void updateGioHangTest1()
        {
            int result = ChiTietGioHangBUS.Instance.updateGioHang("SP001", "0");
            Assert.AreNotSame(0, result);
        }

    }
}