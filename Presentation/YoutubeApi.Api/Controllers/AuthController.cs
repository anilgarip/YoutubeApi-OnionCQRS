using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YoutubeApi.Application.Features.Auth.Command.Login;
using YoutubeApi.Application.Features.Auth.Command.RefreshToken;
using YoutubeApi.Application.Features.Auth.Command.Register;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            // await mediator.Send(request);
            // return StatusCode(StatusCodes.Status201Created);

         
                try
                {
                    await mediator.Send(request);
                    return StatusCode(StatusCodes.Status201Created);
                }
                catch (DbUpdateException ex)
                {
                    // İç hata mesajını dahil ederek dönebilirsiniz
                    return StatusCode(StatusCodes.Status500InternalServerError, new { Errors = new[] { ex.InnerException?.Message ?? ex.Message } });
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new { Errors = new[] { ex.Message } });
                }
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK,response);
        }

        [HttpPost]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

    }
}
