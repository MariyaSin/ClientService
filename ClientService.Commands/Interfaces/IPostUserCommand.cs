using ClientService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientService.Commands.Interfaces
{
    public interface IPostUserCommand
    {
        public Guid Exequte(User user);
    }
}
