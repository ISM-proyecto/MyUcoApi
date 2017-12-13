using MyUcoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUcoApi.Repository
{
    public static class MyUcoRepositorySeeder
    {
        public static void Initialize(MyUcoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Classrooms.Any() && context.Beacons.Any() && context.Trajectories.Any())
            {
                return;   // DB has been seeded
            }

            var beacons = new Beacon[]
            {
                new Beacon
                {
                    Name="DESKTOP-NB",
                    Left = 1530,
                    Top = 650
                }
            }; 

            var classrooms = new Classroom[] {
                new Classroom
                    {
                        Name ="S2",
                        Left = 1380,
                        Top = 1250
                    }
            };

            var trajectories = new Trajectory[]
            {
                new Trajectory
                {
                    Name = "DESKTOP-NB-S2",
                    Groups = new Group[]
                    {new Group{Elements =
                        new Element[]
                        {
                            new Element {Left=1510,Top=670 },
                            new Element {Left=1492,Top=670 },
                            new Element {Left=1465,Top=800 },
                            new Element {Left=1500,Top=1020 },
                            new Element {Left=1465,Top=1020 },
                            new Element {Left=1465,Top=975 }
                        } },new Group{Elements =
                        new Element[]
                        {
                            new Element {Left=1500,Top=1540 },
                            new Element {Left=1500,Top=1585 },
                            new Element {Left=1465,Top=1585 },
                            new Element {Left=1465,Top=1340 },
                            new Element {Left=1400,Top=1340 },
                            new Element {Left=1400,Top=1310 }
                        } }
                    }
                }
            };

            context.Classrooms.AddRange(classrooms);
            context.Beacons.AddRange(beacons);
            context.Trajectories.AddRange(trajectories);

            context.SaveChanges();
        }
    }
}
