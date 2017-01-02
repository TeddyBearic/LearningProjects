namespace DinnerPartyApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfPeopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setFancyDecortaions = new System.Windows.Forms.CheckBox();
            this.setHealthyOptions = new System.Windows.Forms.CheckBox();
            this.dinnerPartyCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.TextBox();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numberOfPeopleNumericUpDown
            // 
            this.numberOfPeopleNumericUpDown.Location = new System.Drawing.Point(10, 21);
            this.numberOfPeopleNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numberOfPeopleNumericUpDown.Name = "numberOfPeopleNumericUpDown";
            this.numberOfPeopleNumericUpDown.Size = new System.Drawing.Size(92, 20);
            this.numberOfPeopleNumericUpDown.TabIndex = 1;
            this.numberOfPeopleNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleNumericUpDown.ValueChanged += new System.EventHandler(this.numberOfPeopleNumericUpDown_ValueChanged);
            // 
            // setFancyDecortaions
            // 
            this.setFancyDecortaions.AutoSize = true;
            this.setFancyDecortaions.Checked = true;
            this.setFancyDecortaions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setFancyDecortaions.Location = new System.Drawing.Point(10, 47);
            this.setFancyDecortaions.Name = "setFancyDecortaions";
            this.setFancyDecortaions.Size = new System.Drawing.Size(115, 17);
            this.setFancyDecortaions.TabIndex = 2;
            this.setFancyDecortaions.Text = "Fancy Decorations";
            this.setFancyDecortaions.UseVisualStyleBackColor = true;
            this.setFancyDecortaions.CheckedChanged += new System.EventHandler(this.setFancyDecortaions_CheckedChanged);
            // 
            // setHealthyOptions
            // 
            this.setHealthyOptions.AutoSize = true;
            this.setHealthyOptions.Location = new System.Drawing.Point(10, 70);
            this.setHealthyOptions.Name = "setHealthyOptions";
            this.setHealthyOptions.Size = new System.Drawing.Size(101, 17);
            this.setHealthyOptions.TabIndex = 3;
            this.setHealthyOptions.Text = "Healthy Options";
            this.setHealthyOptions.UseVisualStyleBackColor = true;
            this.setHealthyOptions.CheckedChanged += new System.EventHandler(this.setHealthyOptions_CheckedChanged);
            // 
            // dinnerPartyCost
            // 
            this.dinnerPartyCost.Location = new System.Drawing.Point(45, 94);
            this.dinnerPartyCost.Name = "dinnerPartyCost";
            this.dinnerPartyCost.Size = new System.Drawing.Size(77, 20);
            this.dinnerPartyCost.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(167, 165);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numberOfPeopleNumericUpDown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dinnerPartyCost);
            this.tabPage1.Controls.Add(this.setFancyDecortaions);
            this.tabPage1.Controls.Add(this.setHealthyOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(159, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(159, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of People";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(10, 19);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 8;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(10, 45);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 9;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cake Writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooLongLabel.ForeColor = System.Drawing.Color.Black;
            this.tooLongLabel.Location = new System.Drawing.Point(81, 65);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(71, 13);
            this.tooLongLabel.TabIndex = 11;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cost";
            // 
            // birthdayCost
            // 
            this.birthdayCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.birthdayCost.Location = new System.Drawing.Point(52, 107);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(100, 20);
            this.birthdayCost.TabIndex = 13;
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(10, 81);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(142, 20);
            this.cakeWriting.TabIndex = 14;
            this.cakeWriting.Text = "Happy Burfdey";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 170);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfPeopleNumericUpDown;
        private System.Windows.Forms.CheckBox setFancyDecortaions;
        private System.Windows.Forms.CheckBox setHealthyOptions;
        private System.Windows.Forms.TextBox dinnerPartyCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.TextBox birthdayCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label3;
    }
}

