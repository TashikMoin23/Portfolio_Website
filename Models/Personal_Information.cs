namespace Portfolio_Website.Models
{
    public class Personal_Information
    {
        private string Name { get; set; }
        private int Age { get; set; }
        public string Date_Of_Birth { get; set; }

        public Personal_Information()
        {
            Name = "Tashik Moin";
            Age = 21;
            Date_Of_Birth = "23rd October, 1999";
        }
    }
}
