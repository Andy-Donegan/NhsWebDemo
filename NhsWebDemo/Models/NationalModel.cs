using System.Collections;
using System.Collections.Generic;

namespace NhsWebDemo.Models
{
    public class NationalModel
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public NationalModel(int Id, string Name) 
        {
            _id = Id; 
            _name = Name;
        }
    }
}
