using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DisplayEntry
    {
        private DisplayType displayType;
        private string text;
        private string html;

        public DisplayEntry(DisplayType displayType, string text)
        {
            this.displayType = displayType;
            this.text = text;
        }

        public string getHTML()
        {
            return (html == null) ? generateHTML() : html;
        }

        private string generateHTML()
        {
            html = "<" + getTagName() + " style=\"color:" + getTagColor() + "\">" + text + "</" + getTagName() + "><br />";
            return html;
        }

        private string getTagName()
        {
            return (displayType == DisplayType.CALCULATION) ? "span" : "b";
        }

        private string getTagColor()
        {
            switch (displayType)
            {
                case DisplayType.CALCULATION:
                    return "#099"; // Light blue
                case DisplayType.RESULT:
                    return "4444FF";  // blue
                case DisplayType.ERROR:
                    return "F00";  // red
                default:
                    return "#000000"; // black
            }
        }
    }
}
