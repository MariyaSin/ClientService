using ClientService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Broker.Models.Requests
{
    public class PostUserRequest
    {
        public User User { get; set; }
    }
}
