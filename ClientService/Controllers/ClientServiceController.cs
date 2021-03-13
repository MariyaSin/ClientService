using Broker.Models.Requests;
using Broker.Models.Responds;
using ClientService.Commands.Interfaces;
using ClientService.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClientService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientServiceController : ControllerBase
    {
        [HttpPost("postuser")]
        public Guid PostUserController(
            [FromServices] IRequestClient<PostUserRequest> requestClient,
            [FromBody] User user)
        {

            PostUserRequest userRquest = new PostUserRequest();
            userRquest.User = user;
            var response = requestClient.GetResponse<PostUserResponse>(userRquest);
            return response.Result.Message.Id;
            //return command.Exequte(user);
        }
    }
}
