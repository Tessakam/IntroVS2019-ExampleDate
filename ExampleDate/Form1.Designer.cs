
namespace ExampleDate
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
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnWeekday = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToday.Location = new System.Drawing.Point(74, 52);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(125, 40);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Vandaag";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYear.Location = new System.Drawing.Point(74, 98);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(125, 40);
            this.btnYear.TabIndex = 0;
            this.btnYear.Text = "Jaar";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNumber.Location = new System.Drawing.Point(215, 98);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(125, 40);
            this.btnNumber.TabIndex = 0;
            this.btnNumber.Text = "Nummer";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnWeekday
            // 
            this.btnWeekday.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWeekday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWeekday.Location = new System.Drawing.Point(363, 98);
            this.btnWeekday.Name = "btnWeekday";
            this.btnWeekday.Size = new System.Drawing.Size(125, 40);
            this.btnWeekday.TabIndex = 0;
            this.btnWeekday.Text = "Weekdag";
            this.btnWeekday.UseVisualStyleBackColor = false;
            this.btnWeekday.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnName.Location = new System.Drawing.Point(215, 158);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(125, 40);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShort.Location = new System.Drawing.Point(215, 221);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(125, 40);
            this.btnShort.TabIndex = 0;
            this.btnShort.Text = "Afkorting";
            this.btnShort.UseVisualStyleBackColor = false;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnAge
            // 
            this.btnAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAge.Location = new System.Drawing.Point(74, 329);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(125, 40);
            this.btnAge.TabIndex = 0;
            this.btnAge.Text = "Leeftijd";
            this.btnAge.UseVisualStyleBackColor = false;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBirthday.Location = new System.Drawing.Point(80, 282);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(88, 17);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Geboren op:";
            this.lblBirthday.Click += new System.EventHandler(this.lblBirthday_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonth.Location = new System.Drawing.Point(229, 64);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(51, 17);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Maand";
            this.lblMonth.Click += new System.EventHandler(this.lblMonth_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(215, 282);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(262, 22);
            this.dateTimePickerBirthday.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOutput.Location = new System.Drawing.Point(619, 64);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 17);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.btnWeekday);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnToday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnWeekday;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label lblOutput;
    }
}

