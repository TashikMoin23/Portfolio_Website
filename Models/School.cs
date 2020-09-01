namespace Portfolio_Website.Models
{
    public class School
    {
        private string School_Name { get; set; }
        private string School_Department { get; set; }
        private string About_School_Life { get; set; }
        private string Grades_In_School { get; set; }

        public School()
        {
            School_Name = "Blue Horizon School, Karachi.";
            School_Department = "Pre-Engineering.";
            About_School_Life = "";
            Grades_In_School = "";
        }

    }
}
