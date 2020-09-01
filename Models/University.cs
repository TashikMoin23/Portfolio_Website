namespace Portfolio_Website.Models
{
    public class University
    {
        private string University_Name { get; set; }
        private string University_Department { get; set; }
        private string About_University_Life { get; set; }
        private double CGPA_In_University { get; set; }

        public University()
        {
            University_Name = "National University Of Computer & Emerging Sciences, Karachi.";
            University_Department = "Computer Science.";
            About_University_Life = "";
            CGPA_In_University = 3.38;
        }

    }
}
