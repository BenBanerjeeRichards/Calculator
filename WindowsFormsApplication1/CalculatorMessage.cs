using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     class CalculatorMessage
    {
        private Status status;
        private string body;
        public string meta;

        public CalculatorMessage(Status status, string body)
        {
            this.status = status;
            this.body = body;
        }

        public CalculatorMessage(Status status, string body, string meta)
        {
            this.status = status;
            this.body = body;
            this.meta = meta;
        }


        // I come from Java
        // TODO replace with {get;set}
        public Status getStatus()
        {
            return status;
        }

        public string getBody()
        {
            return body;
        }

       
        public override string ToString()
        {
            string str = "Status: ";

            switch(status)
            {
                case Status.ERROR:
                    str += "Error\n";
                    break;
                case Status.SUCCESS:
                    str += "Success\n";
                    break;
            }
            str += "Body: " + body;
            str += "\nMeta: " + meta;
            return str;
        }

    }
}
