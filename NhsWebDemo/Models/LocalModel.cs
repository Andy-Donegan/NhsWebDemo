namespace NhsWebDemo.Models
{
    public class LocalModel
    {
        private int _id;
        private int _regionalId;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int RegionalId
        {
            get { return _regionalId; }
            set { _regionalId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public LocalModel(int Id, int RegionalId, string Name) { _id = Id; _regionalId = RegionalId; _name = Name; }
    }
}
