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
            Certifications = new List<string>(new string[] { "Azure Fundamental AZ-900, Microsoft.", "Introduction To Python 98-381, Microsoft.", "Software Development Fundamentals 98-361, Microsoft.", "Cloud Computing Certifications, Oracle"  });
            Skills = new List<string>(new string[] { "Linux", "Docker", "C" , "C++" , "C#" , "Blazor", "Python" , "Microsoft Azure" , "AWS" , ".NET Framework", ".NET Core" , "Version Controlling With Git & GitHub" , "HTML" , "CSS" , "SQL" , "Postgresql"   });
        }

    }
}
