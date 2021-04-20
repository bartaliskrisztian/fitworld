using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class EntryService
    {
        private readonly ApplicationDbContext db;

        public EntryService(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Entry> GetEntries()
        {
            var entryList = db.Entries.ToList();
            return entryList;
        }

        public string AddEntry(Entry entry)
        {
            db.Entries.Add(entry);
            db.SaveChanges();
            return "Entry added successfully";
        }
    }
}
