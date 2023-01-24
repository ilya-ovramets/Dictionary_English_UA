using FirstApp.Custom;

namespace FirstApp.ControllPanel
{
    partial class Repeat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundButton1 = new FirstApp.Custom.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Word_Repeat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit_BTN = new FirstApp.Custom.RoundButton();
            this.I_Forget_btn = new FirstApp.Custom.RoundButton();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(494, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repeat";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Submit_BTN);
            this.panel1.Controls.Add(this.I_Forget_btn);
            this.panel1.Controls.Add(this.AnswerBox);
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 669);
            this.panel1.TabIndex = 3;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton1.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 40;
            this.roundButton1.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.Location = new System.Drawing.Point(828, 531);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(228, 54);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.Text = "Next";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Word_Repeat);
            this.panel2.Location = new System.Drawing.Point(253, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 205);
            this.panel2.TabIndex = 4;
            // 
            // Word_Repeat
            // 
            this.Word_Repeat.AutoSize = true;
            this.Word_Repeat.Font = new System.Drawing.Font("Times New Roman", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word_Repeat.Location = new System.Drawing.Point(96, 10);
            this.Word_Repeat.Name = "Word_Repeat";
            this.Word_Repeat.Size = new System.Drawing.Size(0, 40);
            this.Word_Repeat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pleace Write Translate";
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.BackColor = System.Drawing.Color.Gainsboro;
            this.Submit_BTN.BackColor2 = System.Drawing.Color.Silver;
            this.Submit_BTN.ButtonBorderColor = System.Drawing.Color.Black;
            this.Submit_BTN.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.Submit_BTN.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.Submit_BTN.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Submit_BTN.ButtonPressedColor = System.Drawing.Color.Red;
            this.Submit_BTN.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.Submit_BTN.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Submit_BTN.ButtonRoundRadius = 40;
            this.Submit_BTN.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit_BTN.Location = new System.Drawing.Point(480, 531);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(228, 54);
            this.Submit_BTN.TabIndex = 2;
            this.Submit_BTN.Text = "Submit";
            this.Submit_BTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // I_Forget_btn
            // 
            this.I_Forget_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.I_Forget_btn.BackColor2 = System.Drawing.Color.Silver;
            this.I_Forget_btn.ButtonBorderColor = System.Drawing.Color.Black;
            this.I_Forget_btn.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.I_Forget_btn.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.I_Forget_btn.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.I_Forget_btn.ButtonPressedColor = System.Drawing.Color.Red;
            this.I_Forget_btn.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.I_Forget_btn.ButtonPressedForeColor = System.Drawing.Color.White;
            this.I_Forget_btn.ButtonRoundRadius = 40;
            this.I_Forget_btn.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.I_Forget_btn.Location = new System.Drawing.Point(82, 531);
            this.I_Forget_btn.Name = "I_Forget_btn";
            this.I_Forget_btn.Size = new System.Drawing.Size(228, 54);
            this.I_Forget_btn.TabIndex = 1;
            this.I_Forget_btn.Text = "I Fogot";
            this.I_Forget_btn.Click += new System.EventHandler(this.I_Forget_btn_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBox.Location = new System.Drawing.Point(96, 319);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(960, 206);
            this.AnswerBox.TabIndex = 0;
            // 
            // Repeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Repeat";
            this.Size = new System.Drawing.Size(1143, 669);
            this.Load += new System.EventHandler(this.ExeptionControll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox AnswerBox;
        private RoundButton Submit_BTN;
        private RoundButton I_Forget_btn;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
        private Label label2;
        private Label Word_Repeat;
        private RoundButton roundButton1;
    }
}
