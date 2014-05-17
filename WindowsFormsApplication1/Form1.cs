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

        private string html = "";


        public Form1()
        {
            InitializeComponent();

            writeHTMLToWebBrowser("<html> <body style=\"font-family:consolas; margin:10px;\">");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


        private void textEntrySubmittedHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string contents = textBox1.Text;

                textBox1.Text = "";

                if (contents.Trim().Equals(""))
                {
                    return;
                }

                CalculatorMessage cm = calc.evalulate(contents);
                Console.WriteLine(cm);

                DisplayEntry dm = new DisplayEntry((cm.getStatus() == Status.SUCCESS) ? DisplayType.RESULT : DisplayType.ERROR, cm.getBody());
                addDisplayEntry(dm);

            }
        }

    }
}
