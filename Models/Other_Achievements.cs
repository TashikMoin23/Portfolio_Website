using System.Collections.Generic;

namespace Portfolio_Website.Models
{
    public class Other_Achievements
    {
        private List<string> Interested_Areas { get; set; }
        private List<string> Certifications { get; set; }
        private List<string> Skills { get; set; }
        public Other_Achievements()
        {
            Interested_Areas = new List<string>(new string[] { "Cloud Computing", "Artificial Intelligence", "Web Development", "Mobile Development", "Desktop Development" });
            Certifications = new List<string>(new string[] { "Microsoft Azure Fundamental AZ-900", "Microsoft Introduction To Python 98-381" });
            Skills = new List<string>(new string[] { "C" , "C++" , "C#" , "Python" , "Microsoft Azure" , "AWS" , ".NET" , "Xamarin" , "Version Controlling With Git & GitHub" , "HTML" , "CSS" , "SQL" , "Postgresql"   });
        }

    }
}
