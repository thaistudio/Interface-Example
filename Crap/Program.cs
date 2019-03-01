using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> list = new List<Team>();
            list.Add(Team.ManchesterUnited);
            list.Add(Team.Juve);
            list.Add(Team.Barca);
            list.Add(Team.Bayern);

            Program program = new Program();

            foreach (Team team in list)
            {
                program.Method(team);
            }
            Console.ReadLine();
        }

        public IFootball GetTeam(Team team)
        {
            switch (team)
            {
                case Team.ManchesterUnited:
                    return new PL();
                case Team.Juve:
                    return new SA();
                case Team.Bayern:
                    return new BL();
                case Team.Barca:
                    return new LL();

                default:
                    return null;
            }
        }

        public void Method(Team team)
        {
            IFootball method = GetTeam(team);
            method.Name = team.ToString();
            method.Champion(team, "s");
        }
    }

    public enum Team
    {
        ManchesterUnited,
        Juve,
        Bayern,
        Barca,
    }

    public interface IFootball
    {
        string Name { get; set; }
        void Champion(Team team, string st);
    }


    public class PL : IFootball
    {
        public string Name { get ; set ; }

        public void Champion(Team team, string st)
        {
            Console.WriteLine($"{Name} is the champion"); 
        }
    }

    public class SA : IFootball
    {
        public string Name { get; set; }

        public void Champion(Team team, string st)
        {
            Console.WriteLine($"{Name} is the champion");
        }
    }

    public class LL : IFootball
    {
        public string Name { get; set; }

        public void Champion(Team team, string st)
        {
            Console.WriteLine($"{Name} is the champion");
        }
    }

    public class BL : IFootball
    {
        public string Name { get; set; }

        public void Champion(Team team, string st)
        {
            Console.WriteLine($"{Name} is the champion");
        }
    }
}
