using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class ClientMembershipService
    {
        private readonly ApplicationDbContext db;

        public ClientMembershipService(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<ClientMembership> GetClientMemberships()
        {
            var clientMembershipList = db.ClientMemberships.ToList();
            return clientMembershipList;
        }

        public string AddClientMembership(ClientMembership clientMembership)
        {
            db.ClientMemberships.Add(clientMembership);
            db.SaveChanges();
            return "Client membership added successfully";
        }
    }
}
