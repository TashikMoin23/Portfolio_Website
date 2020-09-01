namespace Portfolio_Website.Models
{
    public class College 
    {
        private string College_Name { get; set; }
        private string College_Department { get; set; }
        private string About_College_Life { get; set; }
        private string Grades_In_College { get; set; }

        public College()
        {
            College_Name = "Govt. Dehli College, Karachi.";
            College_Department = "Pre-Engineering.";
            About_College_Life = "";
            Grades_In_College = "";
        }

    }
}
