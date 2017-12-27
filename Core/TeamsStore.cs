using System.Collections.Generic;


namespace VS.Core
{
    public interface TeamsStore
    {
       IEnumerable<Team> List();
       Team Create(Team team);
       void Delete(int id);
       void Update(int id, Team team);
    }
}
