using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VS.Core;


namespace VS.Data
{
    public class Storage 
    {
        public string conncetionstring = @"MyData.db";


        public Team Create(Team team)
        {
            using (var db = new LiteDatabase(conncetionstring))
            {
                var teams = db.GetCollection<Team>("teams");
                var newtask = new Team
                {
                    Name = teams.Name,
                    Star = 5.0D,
                    Form = 5.0D
                };

                teams.Insert(team);
            }
            return team;
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(conncetionstring))
            {
                var teams = db.GetCollection<Team>("teams");
                teams.Delete(x => x.Id == id);
            }
        }

        public IEnumerable<Team> List()
        {

            using (var db = new LiteDatabase(conncetionstring))
            {
                var teams = db.GetCollection<Team>("teams");
                var results = teams.Find(x => x.Id > 0);
                return results.ToList();
            }
        }

        public void Update(int id, Team team)
        {
            using (var db = new LiteDatabase(conncetionstring))
            {
                var teams = db.GetCollection<Team>("teams");
                var Upteams = teams.Find(x => x.Id == id).First();
                Upteams.Name = teams.Name;
                teams.Update(Upteams);

            }
        }


    }
}
