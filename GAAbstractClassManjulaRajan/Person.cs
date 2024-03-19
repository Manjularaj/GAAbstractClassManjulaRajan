using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GAAbstractClassManjulaRajan
{
    public abstract class Person
    {

        public string Name { get; set; }
        public int ID { get; set; }

        protected Person(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public abstract string GetDetails();





    }//class










}//namespace
