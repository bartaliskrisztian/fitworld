using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class GymService
    {
        private readonly ApplicationDbContext db;

        public GymService(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Gym> GetGyms()
        {
            var gymList = db.Gyms.ToList();
            return gymList;
        }

        public Gym GetGymById(int id)
        {
            Gym gym = db.Gyms.FirstOrDefault(g => g.Gym_id == id);
            return gym;
        }

        public string AddGym(Gym objGym)
        {
            db.Gyms.Add(objGym);
            db.SaveChanges();
            return "Gym added successfully";
        }

        public string DeleteGym(Gym objGym)
        {
            db.Gyms.Remove(objGym);
            db.SaveChanges();
            return "Delete succesfully";
        }
    }
}
