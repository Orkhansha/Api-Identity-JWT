using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Account;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterDto user)
        {
            return Ok(await _accountService.RegisterAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto user)
        {
            return Ok(await _accountService.LoginAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleAsync([FromBody] RoleDto role)
        {
            await _accountService.CreateRoleAsync(role);
            return Ok();
        }
    }
}
