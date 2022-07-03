using Microsoft.EntityFrameworkCore;
using Parky.Data;
using Parky.Models;
using Parky.Repositories.IRepositories;

namespace Parky.Repositories
{
    public class TrailRepository : ITrailRepository
    {
        private readonly ApplicationDbContext _db;
        public TrailRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateTrail(Trail trail)
        {
            _db.Trails.Add(trail);
            return Save();
        }

        public bool DeleteTrail(Trail trail)
        {
            _db.Trails.Remove(trail);
            return Save();
        }

        public Trail GetTrail(int trailId)
        {
            return _db.Trails.Find(trailId);
        }

        public ICollection<Trail> GetTrails()
        {
            return _db.Trails.Include(c => c.NationalPark).ToList();
        }

        public bool TrailExists(string name)
        {
            return _db.Trails.Any(n => n.Name.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool TrailExists(int id)
        {
            return _db.Trails.Any(n => n.Id == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateTrail(Trail trail)
        {
            _db.Trails.Update(trail);
            return Save();
        }

        public ICollection<Trail> GetTrailsInNationalPark(int pId)
        {
            return _db.Trails.Include(c => c.NationalPark).Where(c => c.NationalParkId == pId).ToList();
        }
    }
}
