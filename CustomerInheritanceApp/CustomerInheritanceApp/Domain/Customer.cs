

using System;
using System.Data.Common;

namespace CustomerInheritanceApp.Domain
{
    class Customer : Object // ISA
    {

        private string _id;
        private string _name;
        private string _location;


        public Customer(string id, string name):this(id,name,"Nodia")
        {
           
           


        }

        public Customer(string id, string name, string _location)
        {

            _id = id;
            _name = name;
           this. _location = _location;
        }
      

        public string Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Location
        {

            get { return _location; }
        }

        public override string ToString()
        {
            return $"id is {_id} , name is {_name} ,location {_location},parent {base.ToString()}";
        }

    }
}
