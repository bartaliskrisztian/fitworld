using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class MembershipService
    {
        private readonly ApplicationDbContext db;

        public MembershipService(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Membership> GetMemberships()
        {
            var membershipList = db.Memberships.ToList();
            return membershipList;
        }

        public string AddMembership(Membership membership)
        {
            db.Memberships.Add(membership);
            db.SaveChanges();
            return "Membership added successfully";
        }

        public Membership GetMembershipById(int id)
        {
            Membership membership = db.Memberships.FirstOrDefault(c => c.Id == id);
            return membership;
        }

        public string UpdateMembership(Membership membership)
        {
            db.Memberships.Update(membership);
            db.SaveChanges();
            return "Update succesfully";
        }

        public string DeleteMembership(Membership membership)
        {
            db.Memberships.Remove(membership);
            db.SaveChanges();
            return "Delete succesfully";
        }
    }
}
