
namespace VS.Core
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Star { get; set; }
        public double Form { get; set; }

        public override string ToString()
        {
            return $"\n{Id}\t{Name}\t{Star}\t{Form}";
        }
    }
}
