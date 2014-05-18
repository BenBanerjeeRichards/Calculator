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
        private Stack<string> history = new Stack<string>();
        private Stack<string> reverseHistory = new Stack<string>();

        private string html = "";


        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("about:blank");

            writeHTMLToWebBrowser("<html> <body style=\"font-family:consolas; margin:10px;\">");
        }

        private void addDisplayEntry(DisplayEntry entry)
        {
            writeHTMLToWebBrowser(entry.getHTML());
        }

        private void writeHTMLToWebBrowser(string html)
        {
            this.html += html;

            HtmlDocument doc = webBrowser1.Document;
            doc.Write(String.Empty);
            webBrowser1.DocumentText = this.html;

            // Definitly a bad idea.
            // Will replace (read: never, as I will forget) when  I have figured out how events and threading works in C#
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

                history.Push(contents);

                DisplayEntry dmEntry = new DisplayEntry(DisplayType.CALCULATION, contents);
                addDisplayEntry(dmEntry);
                CalculatorMessage cm = calc.evalulate(contents);

                DisplayEntry dm = new DisplayEntry((cm.getStatus() == Status.SUCCESS) ? DisplayType.RESULT : DisplayType.ERROR, cm.getBody());
                addDisplayEntry(dm);

                while (reverseHistory.Count != 0)
                {
                    history.Push(reverseHistory.Pop());
                }

            } else if (e.KeyCode == Keys.Up)
            {
                // Revert to history

                if (history.Count > 0)
                {
                    reverseHistory.Push(textBox1.Text);
                    textBox1.Text = history.Pop();
                }

            } else if (e.KeyCode == Keys.Down)
            {
                if (!textBox1.Text.Trim().Equals("") && reverseHistory.Count > 0)
                {
                    string contents = textBox1.Text;
                    textBox1.Text = reverseHistory.Pop();

                    history.Push(contents);
                }
            }

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
