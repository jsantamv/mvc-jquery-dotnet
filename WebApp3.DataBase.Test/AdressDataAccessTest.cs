using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApp3.DataBase;

namespace WebApp3.DataBase.Test
{
    [TestClass]
    public class AdressDataAccessTest
    {
        [TestMethod]
        public void AddressListTest()
        {
            DataAccess.AdressDataAccess addressAccessConnect = new DataAccess.AdressDataAccess();
            addressAccessConnect.AddressList();
        }
    }
}
