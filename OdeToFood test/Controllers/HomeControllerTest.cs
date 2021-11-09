using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OdeToFood_test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {   
        [TestMethod]
        public void About()
        {
            HomeController Controller = new HomeController();
            ViewResult result = Controller.About() as ViewResult;
            Assert.IsNotNull(result.Model);
        }


    }
}
