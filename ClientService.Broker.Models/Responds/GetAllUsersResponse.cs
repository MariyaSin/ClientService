using ClientService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Broker.Models.Responses
{
    public class GetAllUsersResponse
    {
        public List<DbUser> Users { get; set; }
    }
}
