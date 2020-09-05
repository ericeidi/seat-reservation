using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace WpfApp2
{
    public class Seat
    {

        private string name;
        private string number;

        public Seat()
        {
            name = "";
            number = "";

        }

        public Seat(string name, string number)
        {
            this.name = name;
            this.number = number;

        }
     

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Number
        {
            get => number;
            set => number = value;
        }

   


    }
}
