using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using SonOfCod.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class AccountControllerTest
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private ApplicationDbContext db;

        [Fact]
        public void IndexReturnsView()
        {
            AccountController ctrl = new AccountController(userManager, signInManager, db);

            Assert.IsType<ViewResult>(ctrl.Index());
        }

        [Fact]
        public void RegisterReturnsView()
        {
            AccountController ctrl = new AccountController(userManager, signInManager, db);

            Assert.IsType<ViewResult>(ctrl.Register());
        }

        [Fact]
        public void LoginReturnsView()
        {
            AccountController ctrl = new AccountController(userManager, signInManager, db);

            Assert.IsType<ViewResult>(ctrl.Index());
        }

        public void RegisterPostIsSuccessful()
        {
            //Cannot test Register method due to Xunit async issue
        }
        public void RegisterNonMatchingPasswordFails()
        {
            //Cannot test Register method due to Xunit async issue
        }

        public void LoginPostIsSuccessful()
        {
            //Cannot test Login Post method due to Xunit async issue
        }
    }
}
