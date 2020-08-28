namespace Portfolio_Website.Models
{
    public class Profile : Portfolio
    {
        private School _School { get; set; }
        private College _College { get; set; }
        private University _University { get; set; }
        private Other_Achievements _Other_Achievements { get; set; }
        private Personal_Information _Personal_Information { get; set; }

        public Profile()
        {
            _School = new School();
            _College = new College();
            _University = new University();
            _Other_Achievements = new Other_Achievements();
            _Personal_Information = new Personal_Information();
        }

        public void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}
