using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class PanelFactory
    {
        public Panel functionPanel { get; set; }
        public Panel variablePanel { get; set; }
        public Panel keypadPanel { get; set; }

        public Panel getInstance(string name)
        {
            switch (name.ToLower())
            {
                case "functions":
                    return functionPanel;
                case "variables":
                    return variablePanel;
                case "keypad":
                    return keypadPanel;
                default:
                    return null;
            }
        }
    }
}
