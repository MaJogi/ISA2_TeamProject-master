﻿using System;
using System.Collections.Generic;
using System.Text;
using HospitalRegistry.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Mobile.Server.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeController = Microsoft.Azure.Mobile.Server.Controllers.HomeController;

namespace Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
       
    }
}




