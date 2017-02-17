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
    public class NewsletterControllerTest
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Fact]
        public void NewsletterIndexReturnsView()
        {
            NewsletterController ctrl = new NewsletterController();

            Assert.IsType<ViewResult>(ctrl.Index());
        }

        [Fact]
        public void NewsletterEnrollReturnsView()
        {
            NewsletterController ctrl = new NewsletterController();

            Assert.IsType<ViewResult>(ctrl.Index());
        }

        [Fact]
        public void EnrollPostSavesToDB()
        {
            NewsletterController ctrl = new NewsletterController();
            NewsletterRecipient recipient = new NewsletterRecipient();
            recipient.Name = "Xunit Test";
            recipient.Email = "x@xunit@gmail.com";

            ctrl.Enroll(recipient);
            var retrieveRecipient = db.Recipients.FirstOrDefault(r => r.Id == recipient.Id);

            Assert.Equal(retrieveRecipient.Id, recipient.Id);
        }
    }
}
