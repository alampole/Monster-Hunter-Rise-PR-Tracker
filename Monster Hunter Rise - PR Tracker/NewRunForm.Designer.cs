
namespace Monster_Hunter_Rise___PR_Tracker
{
    partial class NewRunForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WeaponDropdown = new System.Windows.Forms.ComboBox();
            this.RulesDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MinutesBox = new System.Windows.Forms.NumericUpDown();
            this.SecondsBox = new System.Windows.Forms.NumericUpDown();
            this.MillisecondsBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MillisecondsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(101, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Weapon";
            // 
            // WeaponDropdown
            // 
            this.WeaponDropdown.FormattingEnabled = true;
            this.WeaponDropdown.Location = new System.Drawing.Point(166, 22);
            this.WeaponDropdown.Name = "WeaponDropdown";
            this.WeaponDropdown.Size = new System.Drawing.Size(121, 23);
            this.WeaponDropdown.TabIndex = 9;
            // 
            // RulesDropDown
            // 
            this.RulesDropDown.FormattingEnabled = true;
            this.RulesDropDown.Location = new System.Drawing.Point(293, 22);
            this.RulesDropDown.Name = "RulesDropDown";
            this.RulesDropDown.Size = new System.Drawing.Size(121, 23);
            this.RulesDropDown.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rules";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(339, 63);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MinutesBox
            // 
            this.MinutesBox.Location = new System.Drawing.Point(3, 22);
            this.MinutesBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinutesBox.Name = "MinutesBox";
            this.MinutesBox.Size = new System.Drawing.Size(47, 23);
            this.MinutesBox.TabIndex = 13;
            // 
            // SecondsBox
            // 
            this.SecondsBox.Location = new System.Drawing.Point(56, 22);
            this.SecondsBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(47, 23);
            this.SecondsBox.TabIndex = 14;
            // 
            // MillisecondsBox
            // 
            this.MillisecondsBox.Location = new System.Drawing.Point(114, 22);
            this.MillisecondsBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MillisecondsBox.Name = "MillisecondsBox";
            this.MillisecondsBox.Size = new System.Drawing.Size(47, 23);
            this.MillisecondsBox.TabIndex = 15;
            // 
            // NewRunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 98);
            this.Controls.Add(this.MillisecondsBox);
            this.Controls.Add(this.SecondsBox);
            this.Controls.Add(this.MinutesBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RulesDropDown);
            this.Controls.Add(this.WeaponDropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(437, 137);
            this.MinimumSize = new System.Drawing.Size(437, 137);
            this.Name = "NewRunForm";
            this.Text = "New Run";
            ((System.ComponentModel.ISupportInitialize)(this.MinutesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MillisecondsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WeaponDropdown;
        private System.Windows.Forms.ComboBox RulesDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.NumericUpDown MinutesBox;
        private System.Windows.Forms.NumericUpDown SecondsBox;
        private System.Windows.Forms.NumericUpDown MillisecondsBox;
    }
}