namespace BullshitRPG
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
            this.monsterHP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.heroHP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monsterHP
            // 
            this.monsterHP.AutoSize = true;
            this.monsterHP.Location = new System.Drawing.Point(42, 45);
            this.monsterHP.Name = "monsterHP";
            this.monsterHP.Size = new System.Drawing.Size(35, 13);
            this.monsterHP.TabIndex = 0;
            this.monsterHP.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "HERO";
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(114, 10);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 2;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(114, 40);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(75, 23);
            this.healButton.TabIndex = 3;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // heroHP
            // 
            this.heroHP.AutoSize = true;
            this.heroHP.Location = new System.Drawing.Point(218, 45);
            this.heroHP.Name = "heroHP";
            this.heroHP.Size = new System.Drawing.Size(35, 13);
            this.heroHP.TabIndex = 4;
            this.heroHP.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "MONSTER";
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(17, 69);
            this.reportBox.Multiline = true;
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(249, 151);
            this.reportBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 236);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heroHP);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monsterHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monsterHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.Label heroHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reportBox;
    }
}

