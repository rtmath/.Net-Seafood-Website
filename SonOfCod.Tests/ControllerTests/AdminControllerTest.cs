using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class AdminControllerTest
    {
        [Fact]
        public void MailingListReturnsView()
        {
            AdminController ctrl = new AdminController();

            Assert.IsType<ViewResult>(ctrl.MailingList());
        }

        [Fact]
        public void MailingListReturnsRecipientList()
        {
            AdminController ctrl = new AdminController();
            ViewResult result = ctrl.MailingList() as ViewResult;

            Assert.IsType<List<NewsletterRecipient>>(result.ViewData.Model);
        }
    }
}
