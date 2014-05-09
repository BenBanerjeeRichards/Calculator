using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Calculator calc = new Calculator();
        private Point leftPanelLocation;
        private Point rightPanelLocation;

        private Panel leftPanel;
        private Panel rightPanel;

        private List<Button> buttonList = new List<Button>();
        private List<Function> functionList = new List<Function>();

        private string html = "";

        private PanelFactory panelFactory = new PanelFactory();

        public Form1()
        {
            InitializeComponent();

            panelFactory.variablePanel = panelVariables;
            panelFactory.functionPanel = panelFunctions;
            panelFactory.keypadPanel = panelKeypad;

            leftPanelLocation = panelFunctions.Location;
            rightPanelLocation = panelKeypad.Location;

            leftPanel = panelVariables;
            rightPanel = panelKeypad;

            writeHTMLToWebBrowser("<html> <body style=\"font-family:consolas; margin:10px;\">");
            webBrowser1.Document.Window.ScrollTo(0, Int16.MaxValue);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelView pv = new FunctionView();

            Console.WriteLine(pv.getLocation());
            pv.addButton("A Button");
            Console.WriteLine(pv.getLocation());
            pv.addButton("A Button");
            Console.WriteLine(pv.getLocation());
            pv.addButton("A Button");
            Console.WriteLine(pv.getLocation());
            pv.addButton("A Button");
            Console.WriteLine(pv.getLocation());

        }

        private void addDisplayEntry(DisplayEntry entry)
        {
            writeHTMLToWebBrowser(entry.getHTML());
        }

        private void writeHTMLToWebBrowser(string html)
        {
            this.html += html;

            webBrowser1.Navigate("about:blank");
            HtmlDocument doc = webBrowser1.Document;  
            doc.Write(String.Empty);
            webBrowser1.DocumentText = this.html;

            // Definitly a bad idea.
            // Will replace when  I have figured out how events and threading works in C#
            Application.DoEvents();

           webBrowser1.Document.Body.ScrollTop += 100000;



        }

        private void setLeftPanel(Panel panel)
        {
            if (panel.Equals(leftPanel))
            {
                return;
            }

            if (panel.Equals(rightPanel))
            {
                Panel temp = rightPanel;
                rightPanel = leftPanel;
                leftPanel = temp;

                leftPanel.Location = leftPanelLocation;
                rightPanel.Location = rightPanelLocation;
                return;
            }

            leftPanel.Visible = false;
            leftPanel = panel;
            leftPanel.Location = leftPanelLocation;
            leftPanel.Visible = true;
        }

        private void setRightPanel(Panel panel)
        {
            if (panel.Equals(rightPanel))
            {
                return;
            }

            if (panel.Equals(leftPanel))
            {
                Panel temp = rightPanel;
                rightPanel = leftPanel;
                leftPanel = temp;

                leftPanel.Location = leftPanelLocation;
                rightPanel.Location = rightPanelLocation;
                return;
            }

            rightPanel.Visible = false;
            rightPanel = panel;
            rightPanel.Location = rightPanelLocation;
            rightPanel.Visible = true;
        }

        private void leftPanelEventHandler(object sender, EventArgs e)
        {
            setLeftPanel(panelFactory.getInstance(sender.ToString()));
        }

        private void rightPanelEventHandler(object sender, EventArgs e)
        {
            setRightPanel(panelFactory.getInstance(sender.ToString()));
        }

        private void textEntrySubmittedHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string contents = textBox1.Text;
                textBox1.Text = "";

                CalculatorMessage cm = calc.evalulate(contents);
                Console.WriteLine(cm);

                DisplayEntry dm = new DisplayEntry((cm.getStatus() == Status.SUCCESS) ? DisplayType.RESULT : DisplayType.ERROR, cm.getBody());
                addDisplayEntry(dm);
            }
        }

        private void updateFunctionPane()
        {
           
        }


    }
}
