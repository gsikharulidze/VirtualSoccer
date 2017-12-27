using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VS.Core;


namespace VS.Data
{
    public class Storage : TeamsStore
    {
        public string conncetionstring = @"Data.db";


        public Team Create(Team team)
        {
            using (var db = new LiteDatabase(conncetionstring))
            {
                var teams = db.GetCollection<Team>("teams");
                var newteam = new Team
                {
                    Name = team.Name,
                    Star = team.Star,
                    Form = team.Form,
                    IsCountry = team.IsCountry
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
