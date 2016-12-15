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
            this.totalCostTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numberOfPeopleNumericUpDown
            // 
            this.numberOfPeopleNumericUpDown.Location = new System.Drawing.Point(13, 30);
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
            this.setFancyDecortaions.Location = new System.Drawing.Point(13, 57);
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
            this.setHealthyOptions.Location = new System.Drawing.Point(13, 81);
            this.setHealthyOptions.Name = "setHealthyOptions";
            this.setHealthyOptions.Size = new System.Drawing.Size(101, 17);
            this.setHealthyOptions.TabIndex = 3;
            this.setHealthyOptions.Text = "Healthy Options";
            this.setHealthyOptions.UseVisualStyleBackColor = true;
            this.setHealthyOptions.CheckedChanged += new System.EventHandler(this.setHealthyOptions_CheckedChanged);
            // 
            // totalCostTextbox
            // 
            this.totalCostTextbox.Location = new System.Drawing.Point(51, 104);
            this.totalCostTextbox.Name = "totalCostTextbox";
            this.totalCostTextbox.Size = new System.Drawing.Size(77, 20);
            this.totalCostTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalCostTextbox);
            this.Controls.Add(this.setHealthyOptions);
            this.Controls.Add(this.setFancyDecortaions);
            this.Controls.Add(this.numberOfPeopleNumericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfPeopleNumericUpDown;
        private System.Windows.Forms.CheckBox setFancyDecortaions;
        private System.Windows.Forms.CheckBox setHealthyOptions;
        private System.Windows.Forms.TextBox totalCostTextbox;
        private System.Windows.Forms.Label label2;
    }
}

