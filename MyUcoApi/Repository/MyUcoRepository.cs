using MyUcoApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyUcoApi.Repository
{
    public class MyUcoRepository
    {
        private MyUcoContext _context;

        public MyUcoRepository(MyUcoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Classroom>> GetClassroomsAsync()
        {
            return await _context.Classrooms.ToArrayAsync();
        }

        public async Task<IEnumerable<Beacon>> GetBeaconsAsync()
        {
            return await _context.Beacons.ToArrayAsync();
        }

        public async Task<IEnumerable<Trajectory>> GetTrajectoriesAsync()
        {
            return await _context.Trajectories
                           .Include(x=> x.Groups)
                           .ThenInclude(x=>x.Elements)
                           .ToArrayAsync();
        }
    }
}
