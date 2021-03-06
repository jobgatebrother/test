﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using JOBGATE.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using JOBGATE.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using JOBGATE.Models;
using System.IO;

namespace JOBGATE.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel_CPN : PageModel
    {
        private readonly SignInManager<UserAccount> _signInManager;
        private readonly UserManager<UserAccount> _userManager;
        private readonly ILogger<RegisterModel_CPN> _logger;
        private readonly IEmailSender _emailSender;
        private readonly JOBGATEDataContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel_CPN(
            UserManager<UserAccount> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<UserAccount> signInManager,
            ILogger<RegisterModel_CPN> logger,
            IEmailSender emailSender,
            JOBGATEDataContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }


            [Required]
            [EmailAddress]
            [Display(Name = "Confirm Email")]
            [Compare("Email", ErrorMessage = "The Email do not match.")]
            public string ConfirmEmail { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "CompanyName")]
            public string CompanyName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Industry")]
            public string Industry { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "ContratPerson")]
            public string ContratPerson { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Telephone")]
            public string Telephone { get; set; }
        }

        public void IndustryCodeList()
        {
            Array aa;
            List<CEN_IndustryCodeList> industryCodeList = new List<CEN_IndustryCodeList>();
            var List = _context.CEN_IndustryCodeList.ToList();
            foreach (var data in List)
            {
                industryCodeList.Add(new CEN_IndustryCodeList {
                Code = data.Code,
                IndustryNameEN = data.IndustryNameEN
                });
            }
            aa = industryCodeList.ToArray();
            ViewData["IndustryCodeList"] = aa;
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                Input.Username = Input.Username.ToLower();
                var user = new UserAccount { UserName = Input.Username, Email = Input.Email };
                
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    await _userManager.AddToRoleAsync(user, "Company");

                    var CompanyIntroduction = new CPN_CompanyIntroduction { UserID = user.Id, CompanyName = Input.CompanyName, Industry = Input.Industry, Contract = Input.ContratPerson, Telephone = Input.Telephone };
                    _context.Add(CompanyIntroduction);
                    await _context.SaveChangesAsync();

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);
                    string FilePath = Directory.GetCurrentDirectory() + "/wwwroot/TemplateEmail/VerifyEmail.html";
                    StreamReader str = new StreamReader(FilePath);
                    string MailText = str.ReadToEnd();
                    str.Close();
                    MailText = MailText.Replace("[ConfirmLink]", HtmlEncoder.Default.Encode(callbackUrl));
                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email", MailText);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: true);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
