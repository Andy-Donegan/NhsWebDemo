namespace NhsWebDemo.Models
{
    public class RegionalModel
    {
        private int _id;
        private int _nationalId;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int NationalId
        {
            get { return _nationalId; }
            set { _nationalId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public RegionalModel(int Id, int NationalId, string Name) { _id = Id; _nationalId = NationalId; _name = Name;}
    }
}
