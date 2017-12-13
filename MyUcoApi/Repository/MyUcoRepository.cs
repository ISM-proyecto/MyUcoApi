using MyUcoApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyUcoApi.Repository
{
    public class MyUcoRepository
    {
        private MyUcoContext _context;

        public MyUcoRepository(MyUcoContext context)
        {
            _context = context;
        }

        public IEnumerable<Classroom> GetClassrooms()
        {
            return _context.Classrooms.ToArray();
        }

        public IEnumerable<Beacon> GetBeacons()
        {
            return _context.Beacons.ToArray();
        }

        public IEnumerable<Trajectory> GetTrajectories()
        {
            return _context.Trajectories
                           .Include(x=> x.Groups)
                           .ThenInclude(x=>x.Elements)
                           .ToArray();
        }
    }
}
