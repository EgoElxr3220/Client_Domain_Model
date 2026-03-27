using System;
using System.Collections.Generic;
using System.Text;
using CompanyManagement.Models;

namespace CompanyManagement.Services
{
    internal class ClientRepository
    {
        public Dictionary<Guid, Client> clientRepo = new Dictionary<Guid, Client>();

        public void AddClient(Client client)
        {

        }
        public Client? GetClientById(Guid id)
        {
            return clientRepo[id];
        }

    }
}
