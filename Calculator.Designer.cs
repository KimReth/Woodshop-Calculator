
namespace WoodshopCalculator
{
    partial class Calculator
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
            this.LengthOpt1 = new System.Windows.Forms.RadioButton();
            this.LengthOpt2 = new System.Windows.Forms.RadioButton();
            this.WidthOpt1 = new System.Windows.Forms.RadioButton();
            this.WidthOpt2 = new System.Windows.Forms.RadioButton();
            this.ThickOpt1 = new System.Windows.Forms.RadioButton();
            this.ThickOpt2 = new System.Windows.Forms.RadioButton();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.ThicknessLabel = new System.Windows.Forms.Label();
            this.StockLengthLabel = new System.Windows.Forms.Label();
            this.StockWidthLabel = new System.Windows.Forms.Label();
            this.StockThickLabel = new System.Windows.Forms.Label();
            this.StockLengthEntry = new System.Windows.Forms.TextBox();
            this.StockWidthEntry = new System.Windows.Forms.TextBox();
            this.StockThickEntry = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.MinLengthOutLabel = new System.Windows.Forms.Label();
            this.MinThickOutLabel = new System.Windows.Forms.Label();
            this.UseButchBlockOutLabel = new System.Windows.Forms.Label();
            this.WholeButchBlockOutLabel = new System.Windows.Forms.Label();
            this.WideButchBlockOutLabel = new System.Windows.Forms.Label();
            this.RadioErrorLabel = new System.Windows.Forms.Label();
            this.InputErrorLabel = new System.Windows.Forms.Label();
            this.LengthPanel = new System.Windows.Forms.Panel();
            this.WidthPanel = new System.Windows.Forms.Panel();
            this.ThickPanel = new System.Windows.Forms.Panel();
            this.FullPanel = new System.Windows.Forms.Panel();
            this.LengthPanel.SuspendLayout();
            this.WidthPanel.SuspendLayout();
            this.ThickPanel.SuspendLayout();
            this.FullPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LengthOpt1
            // 
            this.LengthOpt1.AutoSize = true;
            this.LengthOpt1.Location = new System.Drawing.Point(50, 26);
            this.LengthOpt1.Name = "LengthOpt1";
            this.LengthOpt1.Size = new System.Drawing.Size(74, 29);
            this.LengthOpt1.TabIndex = 0;
            this.LengthOpt1.TabStop = true;
            this.LengthOpt1.Text = "19\"";
            this.LengthOpt1.UseVisualStyleBackColor = true;
            this.LengthOpt1.CheckedChanged += new System.EventHandler(this.LengthOpt1_CheckedChanged);
            // 
            // LengthOpt2
            // 
            this.LengthOpt2.AutoSize = true;
            this.LengthOpt2.Location = new System.Drawing.Point(50, 61);
            this.LengthOpt2.Name = "LengthOpt2";
            this.LengthOpt2.Size = new System.Drawing.Size(74, 29);
            this.LengthOpt2.TabIndex = 1;
            this.LengthOpt2.TabStop = true;
            this.LengthOpt2.Text = "22\"";
            this.LengthOpt2.UseVisualStyleBackColor = true;
            this.LengthOpt2.CheckedChanged += new System.EventHandler(this.LengthOpt2_CheckedChanged);
            // 
            // WidthOpt1
            // 
            this.WidthOpt1.AutoSize = true;
            this.WidthOpt1.Location = new System.Drawing.Point(75, 18);
            this.WidthOpt1.Name = "WidthOpt1";
            this.WidthOpt1.Size = new System.Drawing.Size(74, 29);
            this.WidthOpt1.TabIndex = 2;
            this.WidthOpt1.TabStop = true;
            this.WidthOpt1.Text = "12\"";
            this.WidthOpt1.UseVisualStyleBackColor = true;
            this.WidthOpt1.CheckedChanged += new System.EventHandler(this.WidthOpt1_CheckedChanged);
            // 
            // WidthOpt2
            // 
            this.WidthOpt2.AutoSize = true;
            this.WidthOpt2.Location = new System.Drawing.Point(75, 53);
            this.WidthOpt2.Name = "WidthOpt2";
            this.WidthOpt2.Size = new System.Drawing.Size(74, 29);
            this.WidthOpt2.TabIndex = 3;
            this.WidthOpt2.TabStop = true;
            this.WidthOpt2.Text = "14\"";
            this.WidthOpt2.UseVisualStyleBackColor = true;
            this.WidthOpt2.CheckedChanged += new System.EventHandler(this.WidthOpt2_CheckedChanged);
            // 
            // ThickOpt1
            // 
            this.ThickOpt1.AutoSize = true;
            this.ThickOpt1.Location = new System.Drawing.Point(61, 26);
            this.ThickOpt1.Name = "ThickOpt1";
            this.ThickOpt1.Size = new System.Drawing.Size(62, 29);
            this.ThickOpt1.TabIndex = 4;
            this.ThickOpt1.TabStop = true;
            this.ThickOpt1.Text = "2\"";
            this.ThickOpt1.UseVisualStyleBackColor = true;
            this.ThickOpt1.CheckedChanged += new System.EventHandler(this.ThickOpt1_CheckedChanged);
            // 
            // ThickOpt2
            // 
            this.ThickOpt2.AutoSize = true;
            this.ThickOpt2.Location = new System.Drawing.Point(61, 61);
            this.ThickOpt2.Name = "ThickOpt2";
            this.ThickOpt2.Size = new System.Drawing.Size(80, 29);
            this.ThickOpt2.TabIndex = 5;
            this.ThickOpt2.TabStop = true;
            this.ThickOpt2.Text = "2.5\"";
            this.ThickOpt2.UseVisualStyleBackColor = true;
            this.ThickOpt2.CheckedChanged += new System.EventHandler(this.ThickOpt2_CheckedChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LengthLabel.Location = new System.Drawing.Point(3, 111);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(304, 33);
            this.LengthLabel.TabIndex = 6;
            this.LengthLabel.Text = "Cutting Board Length";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.WidthLabel.Location = new System.Drawing.Point(396, 111);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(292, 33);
            this.WidthLabel.TabIndex = 7;
            this.WidthLabel.Text = "Cutting Board Width";
            // 
            // ThicknessLabel
            // 
            this.ThicknessLabel.AutoSize = true;
            this.ThicknessLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ThicknessLabel.Location = new System.Drawing.Point(769, 111);
            this.ThicknessLabel.Name = "ThicknessLabel";
            this.ThicknessLabel.Size = new System.Drawing.Size(344, 33);
            this.ThicknessLabel.TabIndex = 8;
            this.ThicknessLabel.Text = "Cutting Board Thickness";
            // 
            // StockLengthLabel
            // 
            this.StockLengthLabel.AutoSize = true;
            this.StockLengthLabel.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLengthLabel.Location = new System.Drawing.Point(59, 371);
            this.StockLengthLabel.Name = "StockLengthLabel";
            this.StockLengthLabel.Size = new System.Drawing.Size(191, 33);
            this.StockLengthLabel.TabIndex = 9;
            this.StockLengthLabel.Text = "Stock Length";
            // 
            // StockWidthLabel
            // 
            this.StockWidthLabel.AutoSize = true;
            this.StockWidthLabel.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold);
            this.StockWidthLabel.Location = new System.Drawing.Point(455, 371);
            this.StockWidthLabel.Name = "StockWidthLabel";
            this.StockWidthLabel.Size = new System.Drawing.Size(179, 33);
            this.StockWidthLabel.TabIndex = 10;
            this.StockWidthLabel.Text = "Stock Width";
            // 
            // StockThickLabel
            // 
            this.StockThickLabel.AutoSize = true;
            this.StockThickLabel.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold);
            this.StockThickLabel.Location = new System.Drawing.Point(823, 371);
            this.StockThickLabel.Name = "StockThickLabel";
            this.StockThickLabel.Size = new System.Drawing.Size(231, 33);
            this.StockThickLabel.TabIndex = 11;
            this.StockThickLabel.Text = "Stock Thickness";
            // 
            // StockLengthEntry
            // 
            this.StockLengthEntry.Location = new System.Drawing.Point(81, 416);
            this.StockLengthEntry.MaxLength = 5;
            this.StockLengthEntry.Name = "StockLengthEntry";
            this.StockLengthEntry.Size = new System.Drawing.Size(146, 31);
            this.StockLengthEntry.TabIndex = 12;
            // 
            // StockWidthEntry
            // 
            this.StockWidthEntry.Location = new System.Drawing.Point(471, 416);
            this.StockWidthEntry.MaxLength = 5;
            this.StockWidthEntry.Name = "StockWidthEntry";
            this.StockWidthEntry.Size = new System.Drawing.Size(146, 31);
            this.StockWidthEntry.TabIndex = 13;
            // 
            // StockThickEntry
            // 
            this.StockThickEntry.Location = new System.Drawing.Point(867, 416);
            this.StockThickEntry.MaxLength = 5;
            this.StockThickEntry.Name = "StockThickEntry";
            this.StockThickEntry.Size = new System.Drawing.Size(146, 31);
            this.StockThickEntry.TabIndex = 14;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CalculateButton.Font = new System.Drawing.Font("Tahoma", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(402, 518);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(286, 51);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MinLengthOutLabel
            // 
            this.MinLengthOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MinLengthOutLabel.Location = new System.Drawing.Point(4, 676);
            this.MinLengthOutLabel.Name = "MinLengthOutLabel";
            this.MinLengthOutLabel.Size = new System.Drawing.Size(800, 35);
            this.MinLengthOutLabel.TabIndex = 16;
            this.MinLengthOutLabel.Text = "Minimum Stock Length: ";
            // 
            // MinThickOutLabel
            // 
            this.MinThickOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MinThickOutLabel.Location = new System.Drawing.Point(3, 628);
            this.MinThickOutLabel.Name = "MinThickOutLabel";
            this.MinThickOutLabel.Size = new System.Drawing.Size(800, 35);
            this.MinThickOutLabel.TabIndex = 17;
            this.MinThickOutLabel.Text = "Minimum Stock Thickness: ";
            // 
            // UseButchBlockOutLabel
            // 
            this.UseButchBlockOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UseButchBlockOutLabel.Location = new System.Drawing.Point(3, 727);
            this.UseButchBlockOutLabel.Name = "UseButchBlockOutLabel";
            this.UseButchBlockOutLabel.Size = new System.Drawing.Size(800, 35);
            this.UseButchBlockOutLabel.TabIndex = 18;
            this.UseButchBlockOutLabel.Text = "Can it be used in a butcher block?";
            // 
            // WholeButchBlockOutLabel
            // 
            this.WholeButchBlockOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.WholeButchBlockOutLabel.Location = new System.Drawing.Point(4, 825);
            this.WholeButchBlockOutLabel.Name = "WholeButchBlockOutLabel";
            this.WholeButchBlockOutLabel.Size = new System.Drawing.Size(800, 35);
            this.WholeButchBlockOutLabel.TabIndex = 19;
            this.WholeButchBlockOutLabel.Text = "Can it make a whole butcher block?";
            // 
            // WideButchBlockOutLabel
            // 
            this.WideButchBlockOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.WideButchBlockOutLabel.Location = new System.Drawing.Point(4, 775);
            this.WideButchBlockOutLabel.Name = "WideButchBlockOutLabel";
            this.WideButchBlockOutLabel.Size = new System.Drawing.Size(800, 35);
            this.WideButchBlockOutLabel.TabIndex = 20;
            this.WideButchBlockOutLabel.Text = "Can it make up the width of a butcher block?";
            // 
            // RadioErrorLabel
            // 
            this.RadioErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RadioErrorLabel.Location = new System.Drawing.Point(76, 58);
            this.RadioErrorLabel.Name = "RadioErrorLabel";
            this.RadioErrorLabel.Size = new System.Drawing.Size(1000, 25);
            this.RadioErrorLabel.TabIndex = 21;
            this.RadioErrorLabel.Text = "Error: ";
            this.RadioErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RadioErrorLabel.Visible = false;
            // 
            // InputErrorLabel
            // 
            this.InputErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.InputErrorLabel.Location = new System.Drawing.Point(76, 313);
            this.InputErrorLabel.Name = "InputErrorLabel";
            this.InputErrorLabel.Size = new System.Drawing.Size(1000, 25);
            this.InputErrorLabel.TabIndex = 22;
            this.InputErrorLabel.Text = "Error: ";
            this.InputErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InputErrorLabel.Visible = false;
            // 
            // LengthPanel
            // 
            this.LengthPanel.Controls.Add(this.LengthOpt2);
            this.LengthPanel.Controls.Add(this.LengthOpt1);
            this.LengthPanel.Location = new System.Drawing.Point(65, 162);
            this.LengthPanel.Name = "LengthPanel";
            this.LengthPanel.Size = new System.Drawing.Size(178, 122);
            this.LengthPanel.TabIndex = 23;
            // 
            // WidthPanel
            // 
            this.WidthPanel.Controls.Add(this.WidthOpt2);
            this.WidthPanel.Controls.Add(this.WidthOpt1);
            this.WidthPanel.Location = new System.Drawing.Point(449, 171);
            this.WidthPanel.Name = "WidthPanel";
            this.WidthPanel.Size = new System.Drawing.Size(185, 113);
            this.WidthPanel.TabIndex = 24;
            // 
            // ThickPanel
            // 
            this.ThickPanel.Controls.Add(this.ThickOpt2);
            this.ThickPanel.Controls.Add(this.ThickOpt1);
            this.ThickPanel.Location = new System.Drawing.Point(848, 164);
            this.ThickPanel.Name = "ThickPanel";
            this.ThickPanel.Size = new System.Drawing.Size(206, 120);
            this.ThickPanel.TabIndex = 25;
            // 
            // FullPanel
            // 
            this.FullPanel.Controls.Add(this.ThickPanel);
            this.FullPanel.Controls.Add(this.WidthPanel);
            this.FullPanel.Controls.Add(this.LengthPanel);
            this.FullPanel.Controls.Add(this.InputErrorLabel);
            this.FullPanel.Controls.Add(this.RadioErrorLabel);
            this.FullPanel.Controls.Add(this.WideButchBlockOutLabel);
            this.FullPanel.Controls.Add(this.WholeButchBlockOutLabel);
            this.FullPanel.Controls.Add(this.UseButchBlockOutLabel);
            this.FullPanel.Controls.Add(this.MinThickOutLabel);
            this.FullPanel.Controls.Add(this.MinLengthOutLabel);
            this.FullPanel.Controls.Add(this.CalculateButton);
            this.FullPanel.Controls.Add(this.StockThickEntry);
            this.FullPanel.Controls.Add(this.StockWidthEntry);
            this.FullPanel.Controls.Add(this.StockLengthEntry);
            this.FullPanel.Controls.Add(this.StockThickLabel);
            this.FullPanel.Controls.Add(this.StockWidthLabel);
            this.FullPanel.Controls.Add(this.StockLengthLabel);
            this.FullPanel.Controls.Add(this.ThicknessLabel);
            this.FullPanel.Controls.Add(this.WidthLabel);
            this.FullPanel.Controls.Add(this.LengthLabel);
            this.FullPanel.Location = new System.Drawing.Point(101, 58);
            this.FullPanel.Name = "FullPanel";
            this.FullPanel.Size = new System.Drawing.Size(1116, 940);
            this.FullPanel.TabIndex = 26;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 1078);
            this.Controls.Add(this.FullPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Woodshop Calculator";
            this.LengthPanel.ResumeLayout(false);
            this.LengthPanel.PerformLayout();
            this.WidthPanel.ResumeLayout(false);
            this.WidthPanel.PerformLayout();
            this.ThickPanel.ResumeLayout(false);
            this.ThickPanel.PerformLayout();
            this.FullPanel.ResumeLayout(false);
            this.FullPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton LengthOpt1;
        private System.Windows.Forms.RadioButton LengthOpt2;
        private System.Windows.Forms.RadioButton WidthOpt1;
        private System.Windows.Forms.RadioButton WidthOpt2;
        private System.Windows.Forms.RadioButton ThickOpt1;
        private System.Windows.Forms.RadioButton ThickOpt2;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label ThicknessLabel;
        private System.Windows.Forms.Label StockLengthLabel;
        private System.Windows.Forms.Label StockWidthLabel;
        private System.Windows.Forms.Label StockThickLabel;
        private System.Windows.Forms.TextBox StockLengthEntry;
        private System.Windows.Forms.TextBox StockWidthEntry;
        private System.Windows.Forms.TextBox StockThickEntry;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label MinLengthOutLabel;
        private System.Windows.Forms.Label MinThickOutLabel;
        private System.Windows.Forms.Label UseButchBlockOutLabel;
        private System.Windows.Forms.Label WholeButchBlockOutLabel;
        private System.Windows.Forms.Label WideButchBlockOutLabel;
        private System.Windows.Forms.Label RadioErrorLabel;
        private System.Windows.Forms.Label InputErrorLabel;
        private System.Windows.Forms.Panel LengthPanel;
        private System.Windows.Forms.Panel WidthPanel;
        private System.Windows.Forms.Panel ThickPanel;
        private System.Windows.Forms.Panel FullPanel;
    }
}

