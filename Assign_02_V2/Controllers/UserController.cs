using Assign_02_V2.Data;
using Assign_02_V2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign_02_V2.Controllers {

    public class UserController : Controller {
        private readonly ApplicationDbContext _context;

        //public static UserManager<User> userManager;

        public UserController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        //public static UserManager<User> userManager { get; set; }

        public IActionResult CompoundInterest() {
            Calculator calc = new Calculator();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CompoundInterest(
            [Bind("Principal, Rate, Years, Compound")] Calculator calc) {

            ViewData["result"] = calc.CompoundInterestCalc();
            return View(calc);
        }

        // GET: Users
       public async Task<IActionResult> ListOfUsers() {
           return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id) {
            if(id == null) {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if(user == null) {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult Create() {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName, Email, MobileNumber, Password, " +
                                                        "FirstName, LastName, Street, City, Province, " +
                                                          " PostalCode, Country, IsAdmin, Password")] User user) {

            var result = _context.Users.Any(u => u.UserName == user.UserName);
            if(result) {
                ViewData["ErrorMessage"] = String.Format("UserName {0} already exists", user.UserName);
               return View();
            }

            string newStatus = "";

            newStatus = user.IsAdmin == true ? "Admin" : "Member";
          
            if(ModelState.IsValid) {
                _context.Add(user);
                
                //await userManager.AddToRoleAsync(user, newStatus);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id) {
            if(id == null) {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if(user == null) {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id, UserName, Email, MobileNumber, Password, " +
                                                        "FirstName, LastName, Street, City, Province, " +
                                                          " PostalCode, Country, IsAdmin")] User user) {
          
            if(id != user.Id) {
                return NotFound();
            }
            string memberStatus = "";
            string newStatus = "";

            if(user.IsAdmin) {
                newStatus = "Admin";
                memberStatus = "Member";
            }
            else if(user.UserName != "a") { //Prevents user "a"from being downgraded to "Member" 
                newStatus = "Member";
                memberStatus = "Admin";
            }
            else {
                return RedirectToAction("ListOfUsers");
            }

            if(ModelState.IsValid) {
                try {
                    var orgUser = await _context.Users.FindAsync(id);
                    _context.Entry(orgUser).CurrentValues.SetValues(user);

                    //await userManager.RemoveFromRoleAsync(user, memberStatus);
                    //await userManager.RemoveFromRoleAsync(user, newStatus);
                    //await userManager.AddToRoleAsync(user, newStatus);
                    //_context.AppRole.FirstOrDefault(c => c.Id == user.Id);

                    //await _context.SaveChangesAsync();
                    return RedirectToAction("ListOfUsers");
                }
                catch(DbUpdateConcurrencyException) {
                    if(!UserExists(user.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id) {
            if(id == null) {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if(user == null) {
                return NotFound();
            }
            //return RedirectToAction(nameof(DeleteConfirmed));
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            await DeleteConfirmed(id);

            return View(user);
        }


        private bool UserExists(string id) {
            return _context.Users.Any(e => e.Id == id);
        }

    }


}
