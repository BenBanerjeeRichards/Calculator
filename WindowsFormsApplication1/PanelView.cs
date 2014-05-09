using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class PanelView
    {
        public List<Button> buttons = new List<Button>();
        public Point[] buttonLocations;

        public int numButtons = 0;

        public int getFreeSpaces()
        {
            return 24 - numButtons;
        }

        public bool addButton(string text)
        {
            if (getFreeSpaces() == 0)
            {
                return false;
            }
            numButtons++;

            Button btn = new Button();

            btn.Size = new Size(86, 23);
            btn.Location = getLocation();
            btn.Text = text;
            btn.Name = text;
            buttons.Add(btn);


            return true;
        }

        public bool removeButton(string name)
        {
            // TODO optimise with LINQ

            foreach (Button btn in buttons)
            {
                if (btn.Name.Equals(name))
                {
                    buttons.Remove(btn);
                    return true;
                }
            }

            return false;
        }

        public Point getLocation()
        {
            if (buttonLocations == null)
            {
                // Genertate Locations
                buttonLocations = new Point[24];

                int i = 0;

                for (int height = 1; height <= 8; height++)
                {

                    for (int width = 1; width <= 3; width++)
                    {
                        Point point = new Point();
                        point.X = 94 * (width - 1) + 3;
                        point.Y = 29 * (height - 1) + 42;

                        buttonLocations[i++] = point;
                    }
                }

            }

            return buttonLocations[numButtons - 1];
        }

        public List<Button> getButtons()
        {
            return buttons;
        }

    }
}
