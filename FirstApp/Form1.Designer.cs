using FirstApp.Custom;



namespace FirstApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dictionary = new FirstApp.Custom.RoundButton();
            this.Add_Word = new FirstApp.Custom.RoundButton();
            this.Repeat = new FirstApp.Custom.RoundButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 655);
            this.panel1.TabIndex = 6;
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.Color.Gainsboro;
            this.Dictionary.BackColor2 = System.Drawing.Color.Silver;
            this.Dictionary.ButtonBorderColor = System.Drawing.Color.Black;
            this.Dictionary.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Dictionary.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Dictionary.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Dictionary.ButtonPressedColor = System.Drawing.Color.Red;
            this.Dictionary.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Dictionary.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Dictionary.ButtonRoundRadius = 30;
            this.Dictionary.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dictionary.Location = new System.Drawing.Point(0, 0);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(295, 65);
            this.Dictionary.TabIndex = 7;
            this.Dictionary.Text = "Dictionary";
            this.Dictionary.Click += new System.EventHandler(this.employe_btn_Click);
            // 
            // Add_Word
            // 
            this.Add_Word.BackColor = System.Drawing.Color.Gainsboro;
            this.Add_Word.BackColor2 = System.Drawing.Color.Silver;
            this.Add_Word.ButtonBorderColor = System.Drawing.Color.Black;
            this.Add_Word.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Add_Word.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Add_Word.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Add_Word.ButtonPressedColor = System.Drawing.Color.Red;
            this.Add_Word.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Add_Word.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Add_Word.ButtonRoundRadius = 30;
            this.Add_Word.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Word.Location = new System.Drawing.Point(301, 0);
            this.Add_Word.Name = "Add_Word";
            this.Add_Word.Size = new System.Drawing.Size(530, 65);
            this.Add_Word.TabIndex = 8;
            this.Add_Word.Text = "Add New Words";
            this.Add_Word.Click += new System.EventHandler(this.btn_RegularCustomer_Click);
            // 
            // Repeat
            // 
            this.Repeat.BackColor = System.Drawing.Color.Gainsboro;
            this.Repeat.BackColor2 = System.Drawing.Color.Silver;
            this.Repeat.ButtonBorderColor = System.Drawing.Color.Black;
            this.Repeat.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Repeat.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Repeat.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Repeat.ButtonPressedColor = System.Drawing.Color.Red;
            this.Repeat.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Repeat.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Repeat.ButtonRoundRadius = 30;
            this.Repeat.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Repeat.Location = new System.Drawing.Point(837, 0);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(306, 65);
            this.Repeat.TabIndex = 9;
            this.Repeat.Text = "Repeat Word";
            this.Repeat.Click += new System.EventHandler(this.ExeptionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 725);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.Add_Word);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private RoundButton employe_btn;
        private RoundButton btn_RegularCustomer;
        private RoundButton ExeptionButton;
        private Panel panel1;
        private RoundButton Dictionary;
        private RoundButton Add_Word;
        private RoundButton Repeat;
    }
}