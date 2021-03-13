using Broker.Models.Requests;
using Broker.Models.Responds;
using Broker.Models.Responses;
using ClientService.Commands.Interfaces;
using ClientService.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

            PostUserRequest rquest = new PostUserRequest();
            rquest.User = user;
            var response = requestClient.GetResponse<PostUserResponse>(rquest);
            return response.Result.Message.Id;
            //return command.Exequte(user);
        }

        [HttpGet("getallusers")]
        public List<DbUser> GetAllUsersController(
            [FromServices] IRequestClient<GetAllUsersRequest> requestClient)
        {
            GetAllUsersRequest request = new GetAllUsersRequest();
            var response = requestClient.GetResponse<GetAllUsersResponse>(request);
            return response.Result.Message.Users;
        }
    }
}
