using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Variable
    {
        public string name { get; set; }
        public string value { get; set; }
        private bool constant;

        public Variable(string name, string value)
        {
            this.name = name;
            this.value = value;
            this.constant = false;
        }

        public Variable(string name, double value)
        {
            this.name = name;
            this.value = value.ToString();
            this.constant = false;
        }

        public Variable(string name, string value, bool constant)
        {
            this.name = name;
            this.value = value;
            this.constant = constant;
        }

        public Variable(string name, double value, bool constant)
        {
            this.name = name;
            this.value = value.ToString();
            this.constant = constant;
        }

        public string getName()
        {
            return name;
        }

        public string getValue()
        {
            return value;
        }

        public bool isConstant()
        {
            return constant;
        }

        public override string ToString()
        {
            return name + "=" + value;
        }
        
        

        
    }
}
