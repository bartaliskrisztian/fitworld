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

        public List<ClientMembership> GetClientMembershipsByBarCode(String bar_code)
        {
            var clientMembershipList = db.ClientMemberships.Where(m => m.Bar_Code == bar_code).ToList();
            return clientMembershipList;
        }

        public string AddClientMembership(ClientMembership clientMembership)
        {
            db.ClientMemberships.Add(clientMembership);
            db.SaveChanges();
            return "Client membership added successfully";
        }

        public void UpdateClientMembership(ClientMembership clientMembership)
        {
            db.ClientMemberships.Update(clientMembership);
            db.SaveChanges();
        }
    }
}
