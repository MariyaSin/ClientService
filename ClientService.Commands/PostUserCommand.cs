using Broker.Models.Requests;
using Broker.Models.Responds;
using ClientService.Commands.Interfaces;
using ClientService.Models;
using MassTransit;
using System;

namespace ClientService.Commands
{
    /*public class PostUserCommand : IPostUserCommand
    {
        public IRequestClient<PostUserRequest> _request;
        public PostUserRequest userRquestData;
        public PostUserCommand(IRequestClient<PostUserRequest> request)
        {
            _request = request;
            userRquestData = new PostUserRequest();
        }
        public Guid Exequte(User user)
        {
            userRquestData.User = user;
            var response = _request.GetResponse<PostUserResponse>(userRquestData);

            return response.Result.Message.Id;
        }

    }*/
}
