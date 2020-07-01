using Application.Accounts.Commands.Login;
using Application.Accounts.Commands.Register;
using Infrastructure.Identity;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost("[action]")]
        public async Task<ActionResult<UserDto>> Login(LoginCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> Register(RegisterCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }
    }
}
