using System;
using System.Collections.Generic;
using System.Text;

namespace ClientService.Models
{
    public class DbUser
    {
        public const string TableName = "UsersService";
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
    }
}
