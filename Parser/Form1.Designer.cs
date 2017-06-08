namespace Parser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.settings = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.opac = new System.Windows.Forms.ToolStripMenuItem();
            this.two_five = new System.Windows.Forms.ToolStripMenuItem();
            this.five_zero = new System.Windows.Forms.ToolStripMenuItem();
            this.seven_five = new System.Windows.Forms.ToolStripMenuItem();
            this.hundred = new System.Windows.Forms.ToolStripMenuItem();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 58);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Folder Dialog";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(431, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(23, 89);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(501, 71);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 29);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Keyword File";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(141, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "...";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(141, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "...";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Black;
            this.metroButton3.Enabled = false;
            this.metroButton3.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton3.Location = new System.Drawing.Point(23, 166);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(501, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "View Findings";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // settings
            // 
            this.settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opac});
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(116, 26);
            this.settings.Style = MetroFramework.MetroColorStyle.Purple;
            this.settings.Text = "Settings";
            this.settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settings.UseStyleColors = true;
            // 
            // opac
            // 
            this.opac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.two_five,
            this.five_zero,
            this.seven_five,
            this.hundred});
            this.opac.Image = ((System.Drawing.Image)(resources.GetObject("opac.Image")));
            this.opac.Name = "opac";
            this.opac.Size = new System.Drawing.Size(115, 22);
            this.opac.Text = "Opacity";
            // 
            // two_five
            // 
            this.two_five.Image = ((System.Drawing.Image)(resources.GetObject("two_five.Image")));
            this.two_five.Name = "two_five";
            this.two_five.Size = new System.Drawing.Size(102, 22);
            this.two_five.Text = "25%";
            this.two_five.Click += new System.EventHandler(this.two_five_Click);
            // 
            // five_zero
            // 
            this.five_zero.Image = ((System.Drawing.Image)(resources.GetObject("five_zero.Image")));
            this.five_zero.Name = "five_zero";
            this.five_zero.Size = new System.Drawing.Size(102, 22);
            this.five_zero.Text = "50%";
            this.five_zero.Click += new System.EventHandler(this.five_zero_Click);
            // 
            // seven_five
            // 
            this.seven_five.Image = ((System.Drawing.Image)(resources.GetObject("seven_five.Image")));
            this.seven_five.Name = "seven_five";
            this.seven_five.Size = new System.Drawing.Size(102, 22);
            this.seven_five.Text = "75%";
            this.seven_five.Click += new System.EventHandler(this.seven_five_Click);
            // 
            // hundred
            // 
            this.hundred.Image = ((System.Drawing.Image)(resources.GetObject("hundred.Image")));
            this.hundred.Name = "hundred";
            this.hundred.Size = new System.Drawing.Size(102, 22);
            this.hundred.Text = "100%";
            this.hundred.Click += new System.EventHandler(this.hundred_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 208);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroContextMenu settings;
        private System.Windows.Forms.ToolStripMenuItem opac;
        private System.Windows.Forms.ToolStripMenuItem two_five;
        private System.Windows.Forms.ToolStripMenuItem five_zero;
        private System.Windows.Forms.ToolStripMenuItem seven_five;
        private System.Windows.Forms.ToolStripMenuItem hundred;
    }
}

