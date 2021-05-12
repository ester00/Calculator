
using System;
using System.Windows.Forms;

namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculationResultsText = new System.Windows.Forms.Label();
            this.ButtonsPannel = new System.Windows.Forms.TableLayoutPanel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.DevisionButton = new System.Windows.Forms.Button();
            this.NIneButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.M2Button = new System.Windows.Forms.Button();
            this.M1Button = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.MCButton = new System.Windows.Forms.Button();
            this.MSButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.ButtonsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculationResultsText
            // 
            this.CalculationResultsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultsText.Location = new System.Drawing.Point(12, 46);
            this.CalculationResultsText.Name = "CalculationResultsText";
            this.CalculationResultsText.Size = new System.Drawing.Size(390, 61);
            this.CalculationResultsText.TabIndex = 0;
            this.CalculationResultsText.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonsPannel
            // 
            this.ButtonsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPannel.ColumnCount = 5;
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.Controls.Add(this.ZeroButton, 0, 5);
            this.ButtonsPannel.Controls.Add(this.DotButton, 0, 5);
            this.ButtonsPannel.Controls.Add(this.AdditionButton, 0, 5);
            this.ButtonsPannel.Controls.Add(this.EqualsButton, 0, 5);
            this.ButtonsPannel.Controls.Add(this.SubtractionButton, 3, 4);
            this.ButtonsPannel.Controls.Add(this.ThreeButton, 2, 4);
            this.ButtonsPannel.Controls.Add(this.TwoButton, 1, 4);
            this.ButtonsPannel.Controls.Add(this.OneButton, 0, 4);
            this.ButtonsPannel.Controls.Add(this.MultiplicationButton, 3, 3);
            this.ButtonsPannel.Controls.Add(this.SixButton, 2, 3);
            this.ButtonsPannel.Controls.Add(this.FiveButton, 1, 3);
            this.ButtonsPannel.Controls.Add(this.FourButton, 0, 3);
            this.ButtonsPannel.Controls.Add(this.DevisionButton, 3, 2);
            this.ButtonsPannel.Controls.Add(this.NIneButton, 2, 2);
            this.ButtonsPannel.Controls.Add(this.EightButton, 1, 2);
            this.ButtonsPannel.Controls.Add(this.SevenButton, 0, 2);
            this.ButtonsPannel.Controls.Add(this.DelButton, 3, 1);
            this.ButtonsPannel.Controls.Add(this.SquareRootButton, 2, 1);
            this.ButtonsPannel.Controls.Add(this.CButton, 1, 1);
            this.ButtonsPannel.Controls.Add(this.CEButton, 0, 1);
            this.ButtonsPannel.Controls.Add(this.M2Button, 3, 0);
            this.ButtonsPannel.Controls.Add(this.M1Button, 2, 0);
            this.ButtonsPannel.Controls.Add(this.MRButton, 1, 0);
            this.ButtonsPannel.Controls.Add(this.MCButton, 0, 0);
            this.ButtonsPannel.Controls.Add(this.MSButton, 4, 0);
            this.ButtonsPannel.Location = new System.Drawing.Point(1, 110);
            this.ButtonsPannel.Name = "ButtonsPannel";
            this.ButtonsPannel.RowCount = 6;
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.420293F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11595F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11595F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11595F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11595F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11594F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPannel.Size = new System.Drawing.Size(410, 397);
            this.ButtonsPannel.TabIndex = 2;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(85, 324);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(76, 70);
            this.ZeroButton.TabIndex = 23;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Location = new System.Drawing.Point(3, 324);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(76, 70);
            this.DotButton.TabIndex = 22;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdditionButton.Location = new System.Drawing.Point(249, 324);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(76, 70);
            this.AdditionButton.TabIndex = 21;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Location = new System.Drawing.Point(167, 324);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(76, 70);
            this.EqualsButton.TabIndex = 20;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtractionButton.Location = new System.Drawing.Point(249, 253);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(76, 65);
            this.SubtractionButton.TabIndex = 19;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(167, 253);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(76, 65);
            this.ThreeButton.TabIndex = 18;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(85, 253);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(76, 65);
            this.TwoButton.TabIndex = 17;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 253);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(76, 65);
            this.OneButton.TabIndex = 16;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplicationButton.Location = new System.Drawing.Point(249, 182);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(76, 65);
            this.MultiplicationButton.TabIndex = 15;
            this.MultiplicationButton.Text = "x";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(167, 182);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(76, 65);
            this.SixButton.TabIndex = 14;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(85, 182);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(76, 65);
            this.FiveButton.TabIndex = 13;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 182);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(76, 65);
            this.FourButton.TabIndex = 12;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // DevisionButton
            // 
            this.DevisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevisionButton.Location = new System.Drawing.Point(249, 111);
            this.DevisionButton.Name = "DevisionButton";
            this.DevisionButton.Size = new System.Drawing.Size(76, 65);
            this.DevisionButton.TabIndex = 11;
            this.DevisionButton.Text = "÷";
            this.DevisionButton.UseVisualStyleBackColor = true;
            this.DevisionButton.Click += new System.EventHandler(this.DevisionButton_Click);
            // 
            // NIneButton
            // 
            this.NIneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NIneButton.Location = new System.Drawing.Point(167, 111);
            this.NIneButton.Name = "NIneButton";
            this.NIneButton.Size = new System.Drawing.Size(76, 65);
            this.NIneButton.TabIndex = 10;
            this.NIneButton.Text = "9";
            this.NIneButton.UseVisualStyleBackColor = true;
            this.NIneButton.Click += new System.EventHandler(this.NIneButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(85, 111);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(76, 65);
            this.EightButton.TabIndex = 9;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 111);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(76, 65);
            this.SevenButton.TabIndex = 8;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(249, 40);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(76, 65);
            this.DelButton.TabIndex = 7;
            this.DelButton.Text = "⌫";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SquareRootButton.Location = new System.Drawing.Point(167, 40);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(76, 65);
            this.SquareRootButton.TabIndex = 6;
            this.SquareRootButton.Text = "√";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(85, 40);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(76, 65);
            this.CButton.TabIndex = 5;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 40);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(76, 65);
            this.CEButton.TabIndex = 4;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // M2Button
            // 
            this.M2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M2Button.Location = new System.Drawing.Point(249, 3);
            this.M2Button.Name = "M2Button";
            this.M2Button.Size = new System.Drawing.Size(76, 31);
            this.M2Button.TabIndex = 3;
            this.M2Button.Text = "M-";
            this.M2Button.UseVisualStyleBackColor = true;
            this.M2Button.Click += new System.EventHandler(this.M2Button_Click);
            // 
            // M1Button
            // 
            this.M1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M1Button.Location = new System.Drawing.Point(167, 3);
            this.M1Button.Name = "M1Button";
            this.M1Button.Size = new System.Drawing.Size(76, 31);
            this.M1Button.TabIndex = 2;
            this.M1Button.Text = "M+";
            this.M1Button.UseVisualStyleBackColor = true;
            this.M1Button.Click += new System.EventHandler(this.M1Button_Click);
            // 
            // MRButton
            // 
            this.MRButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MRButton.Enabled = false;
            this.MRButton.Location = new System.Drawing.Point(85, 3);
            this.MRButton.Name = "MRButton";
            this.MRButton.Size = new System.Drawing.Size(76, 31);
            this.MRButton.TabIndex = 1;
            this.MRButton.Text = "MR";
            this.MRButton.UseVisualStyleBackColor = true;
            this.MRButton.Click += new System.EventHandler(this.MRButton_Click);
            // 
            // MCButton
            // 
            this.MCButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MCButton.Enabled = false;
            this.MCButton.Location = new System.Drawing.Point(3, 3);
            this.MCButton.Name = "MCButton";
            this.MCButton.Size = new System.Drawing.Size(76, 31);
            this.MCButton.TabIndex = 0;
            this.MCButton.Text = "MC";
            this.MCButton.UseVisualStyleBackColor = true;
            this.MCButton.Click += new System.EventHandler(this.MCButton_Click);
            // 
            // MSButton
            // 
            this.MSButton.Location = new System.Drawing.Point(331, 3);
            this.MSButton.Name = "MSButton";
            this.MSButton.Size = new System.Drawing.Size(76, 31);
            this.MSButton.TabIndex = 24;
            this.MSButton.Text = "MS";
            this.MSButton.UseVisualStyleBackColor = true;
            this.MSButton.Click += new System.EventHandler(this.MSButton_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(3, 161);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 73);
            this.button8.TabIndex = 8;
            this.button8.Text = "CE";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(105, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 73);
            this.button9.TabIndex = 9;
            this.button9.Text = "CE";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(207, 161);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 73);
            this.button10.TabIndex = 10;
            this.button10.Text = "CE";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(309, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 73);
            this.button11.TabIndex = 11;
            this.button11.Text = "CE";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(3, 240);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 73);
            this.button12.TabIndex = 12;
            this.button12.Text = "CE";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(105, 240);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 73);
            this.button13.TabIndex = 13;
            this.button13.Text = "CE";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(207, 240);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(96, 73);
            this.button14.TabIndex = 14;
            this.button14.Text = "CE";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(309, 240);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(98, 73);
            this.button15.TabIndex = 15;
            this.button15.Text = "CE";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(3, 319);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(96, 75);
            this.button16.TabIndex = 16;
            this.button16.Text = "CE";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Location = new System.Drawing.Point(105, 319);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(96, 75);
            this.button17.TabIndex = 17;
            this.button17.Text = "CE";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(0, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(414, 509);
            this.button18.TabIndex = 3;
            this.button18.Text = "CE";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(414, 509);
            this.button3.TabIndex = 19;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(390, 31);
            this.UserInputText.TabIndex = 1;
            // 
            // Calculator
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(414, 509);
            this.Controls.Add(this.ButtonsPannel);
            this.Controls.Add(this.UserInputText);
            this.Controls.Add(this.CalculationResultsText);
            this.MinimumSize = new System.Drawing.Size(436, 565);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ButtonsPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label CalculationResultsText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPannel;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button DevisionButton;
        private System.Windows.Forms.Button NIneButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button M2Button;
        private System.Windows.Forms.Button M1Button;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button MCButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button button3;
        private TextBox UserInputText;
        private Button MSButton;
    }
}

