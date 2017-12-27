using VS.Core;
using System.Collections.Generic;

namespace VS.Logic
{
    public class Logic
    {
        public readonly TeamsStore storage;

        //public VSLogic(TeamsStore storage)
        //{
        //    this.storage = storage;
        //}
        public IEnumerable<Team> List()
        {
            return storage.List();
        }

        public void Create(Team team)
        {
            storage.Create(team);
        }

        public void Delete(string id)
        {
            storage.Delete(int.Parse(id));
        }

    }
}

