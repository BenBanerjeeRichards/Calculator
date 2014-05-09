namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veiwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel1Keypad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel1Functions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel1Variables = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel2Keypad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel2Functions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel2Variables = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelKeypad = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.panelVariables = new System.Windows.Forms.Panel();
            this.button32 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelKeypad.SuspendLayout();
            this.panelFunctions.SuspendLayout();
            this.panelVariables.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiwToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veiwToolStripMenuItem
            // 
            this.veiwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.veiwToolStripMenuItem.Name = "veiwToolStripMenuItem";
            this.veiwToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.veiwToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPanel1Keypad,
            this.menuPanel1Functions,
            this.menuPanel1Variables});
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.standardToolStripMenuItem.Text = "Left Panel";
            // 
            // menuPanel1Keypad
            // 
            this.menuPanel1Keypad.Name = "menuPanel1Keypad";
            this.menuPanel1Keypad.Size = new System.Drawing.Size(126, 22);
            this.menuPanel1Keypad.Text = "Keypad";
            this.menuPanel1Keypad.Click += new System.EventHandler(this.leftPanelEventHandler);
            // 
            // menuPanel1Functions
            // 
            this.menuPanel1Functions.Name = "menuPanel1Functions";
            this.menuPanel1Functions.Size = new System.Drawing.Size(126, 22);
            this.menuPanel1Functions.Text = "Functions";
            this.menuPanel1Functions.Click += new System.EventHandler(this.leftPanelEventHandler);
            // 
            // menuPanel1Variables
            // 
            this.menuPanel1Variables.Name = "menuPanel1Variables";
            this.menuPanel1Variables.Size = new System.Drawing.Size(126, 22);
            this.menuPanel1Variables.Text = "Variables";
            this.menuPanel1Variables.Click += new System.EventHandler(this.leftPanelEventHandler);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPanel2Keypad,
            this.menuPanel2Functions,
            this.menuPanel2Variables});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.functionsToolStripMenuItem.Text = "Right Panel";
            // 
            // menuPanel2Keypad
            // 
            this.menuPanel2Keypad.Name = "menuPanel2Keypad";
            this.menuPanel2Keypad.Size = new System.Drawing.Size(126, 22);
            this.menuPanel2Keypad.Text = "Keypad";
            this.menuPanel2Keypad.Click += new System.EventHandler(this.rightPanelEventHandler);
            // 
            // menuPanel2Functions
            // 
            this.menuPanel2Functions.Name = "menuPanel2Functions";
            this.menuPanel2Functions.Size = new System.Drawing.Size(126, 22);
            this.menuPanel2Functions.Text = "Functions";
            this.menuPanel2Functions.Click += new System.EventHandler(this.rightPanelEventHandler);
            // 
            // menuPanel2Variables
            // 
            this.menuPanel2Variables.Name = "menuPanel2Variables";
            this.menuPanel2Variables.Size = new System.Drawing.Size(126, 22);
            this.menuPanel2Variables.Text = "Variables";
            this.menuPanel2Variables.Click += new System.EventHandler(this.rightPanelEventHandler);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(566, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEntrySubmittedHandler);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(566, 101);
            this.webBrowser1.TabIndex = 3;
            // 
            // panelKeypad
            // 
            this.panelKeypad.Controls.Add(this.button24);
            this.panelKeypad.Controls.Add(this.button25);
            this.panelKeypad.Controls.Add(this.button26);
            this.panelKeypad.Controls.Add(this.button11);
            this.panelKeypad.Controls.Add(this.button10);
            this.panelKeypad.Controls.Add(this.button23);
            this.panelKeypad.Controls.Add(this.button22);
            this.panelKeypad.Controls.Add(this.button21);
            this.panelKeypad.Controls.Add(this.button29);
            this.panelKeypad.Controls.Add(this.button28);
            this.panelKeypad.Controls.Add(this.button27);
            this.panelKeypad.Controls.Add(this.button20);
            this.panelKeypad.Controls.Add(this.button19);
            this.panelKeypad.Controls.Add(this.button18);
            this.panelKeypad.Controls.Add(this.button17);
            this.panelKeypad.Controls.Add(this.button9);
            this.panelKeypad.Controls.Add(this.button16);
            this.panelKeypad.Controls.Add(this.button8);
            this.panelKeypad.Controls.Add(this.button7);
            this.panelKeypad.Controls.Add(this.button6);
            this.panelKeypad.Controls.Add(this.button15);
            this.panelKeypad.Controls.Add(this.button5);
            this.panelKeypad.Controls.Add(this.button4);
            this.panelKeypad.Controls.Add(this.button3);
            this.panelKeypad.Controls.Add(this.button14);
            this.panelKeypad.Controls.Add(this.button13);
            this.panelKeypad.Controls.Add(this.button12);
            this.panelKeypad.Controls.Add(this.button2);
            this.panelKeypad.Location = new System.Drawing.Point(298, 183);
            this.panelKeypad.Name = "panelKeypad";
            this.panelKeypad.Size = new System.Drawing.Size(280, 301);
            this.panelKeypad.TabIndex = 5;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(176, 13);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 2;
            this.button24.Text = "log";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(176, 42);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 3;
            this.button25.Text = "ln";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(176, 71);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 4;
            this.button26.Text = "sqrt";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 172);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(55, 172);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(95, 13);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 1;
            this.button23.Text = "asin";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(95, 42);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 1;
            this.button22.Text = "acos";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(95, 71);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "atan";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(176, 123);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 1;
            this.button29.Text = "phi";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(95, 123);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 1;
            this.button28.Text = "e";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(14, 123);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 1;
            this.button27.Text = "pi";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(14, 71);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 1;
            this.button20.Text = "tan";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(14, 42);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 1;
            this.button19.Text = "cos";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(14, 13);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 1;
            this.button18.Text = "sin";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(135, 172);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 1;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(95, 172);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(135, 201);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(95, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(55, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(135, 230);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 1;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(95, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(135, 259);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 0;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(15, 259);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(34, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(217, 172);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(34, 110);
            this.button12.TabIndex = 0;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Controls.Add(this.button34);
            this.panelFunctions.Controls.Add(this.button33);
            this.panelFunctions.Controls.Add(this.button31);
            this.panelFunctions.Location = new System.Drawing.Point(12, 183);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(280, 301);
            this.panelFunctions.TabIndex = 6;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(191, 275);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(86, 23);
            this.button30.TabIndex = 9;
            this.button30.Text = "Next";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(3, 275);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(86, 23);
            this.button31.TabIndex = 10;
            this.button31.Text = "Prev";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // panelVariables
            // 
            this.panelVariables.Controls.Add(this.button30);
            this.panelVariables.Controls.Add(this.button32);
            this.panelVariables.Controls.Add(this.button40);
            this.panelVariables.Location = new System.Drawing.Point(12, 183);
            this.panelVariables.Name = "panelVariables";
            this.panelVariables.Size = new System.Drawing.Size(280, 301);
            this.panelVariables.TabIndex = 7;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(3, 3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(86, 23);
            this.button32.TabIndex = 9;
            this.button32.Text = "New Variable";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(3, 275);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(86, 23);
            this.button40.TabIndex = 8;
            this.button40.Text = "Prev";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(191, 275);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(86, 23);
            this.button33.TabIndex = 11;
            this.button33.Text = "Next";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(3, 3);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(86, 23);
            this.button34.TabIndex = 10;
            this.button34.Text = "New Function";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 496);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelKeypad);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panelFunctions);
            this.Controls.Add(this.panelVariables);
            this.Location = new System.Drawing.Point(1, 1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelKeypad.ResumeLayout(false);
            this.panelFunctions.ResumeLayout(false);
            this.panelVariables.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veiwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPanel1Keypad;
        private System.Windows.Forms.ToolStripMenuItem menuPanel1Functions;
        private System.Windows.Forms.ToolStripMenuItem menuPanel1Variables;
        private System.Windows.Forms.ToolStripMenuItem menuPanel2Functions;
        private System.Windows.Forms.ToolStripMenuItem menuPanel2Variables;
        private System.Windows.Forms.ToolStripMenuItem menuPanel2Keypad;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panelKeypad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Panel panelVariables;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;

    }
}

