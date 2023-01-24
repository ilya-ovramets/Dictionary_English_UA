namespace FirstApp
{
    partial class NewWord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.regularCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DownPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Word = new System.Windows.Forms.Label();
            this.Transcript = new System.Windows.Forms.Label();
            this.Translate = new System.Windows.Forms.Label();
            this.roundButton1 = new FirstApp.Custom.RoundButton();
            this.roundButton2 = new FirstApp.Custom.RoundButton();
            this.roundButton3 = new FirstApp.Custom.RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regularCustomerBindingSource)).BeginInit();
            this.DownPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Word";
            // 
            // DownPanel
            // 
            this.DownPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DownPanel.Controls.Add(this.label2);
            this.DownPanel.Controls.Add(this.roundButton3);
            this.DownPanel.Controls.Add(this.roundButton2);
            this.DownPanel.Controls.Add(this.roundButton1);
            this.DownPanel.Controls.Add(this.panel1);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 80);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(1143, 588);
            this.DownPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Translate);
            this.panel1.Controls.Add(this.Transcript);
            this.panel1.Controls.Add(this.Word);
            this.panel1.Location = new System.Drawing.Point(160, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 210);
            this.panel1.TabIndex = 0;
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Word.Location = new System.Drawing.Point(43, 23);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(82, 31);
            this.Word.TabIndex = 0;
            this.Word.Text = "label2";
            // 
            // Transcript
            // 
            this.Transcript.AutoSize = true;
            this.Transcript.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Transcript.Location = new System.Drawing.Point(43, 156);
            this.Transcript.Name = "Transcript";
            this.Transcript.Size = new System.Drawing.Size(82, 31);
            this.Transcript.TabIndex = 1;
            this.Transcript.Text = "label3";
            // 
            // Translate
            // 
            this.Translate.AutoSize = true;
            this.Translate.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Translate.Location = new System.Drawing.Point(43, 88);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(82, 31);
            this.Translate.TabIndex = 2;
            this.Translate.Text = "label4";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton1.BackColor2 = System.Drawing.Color.Red;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 30;
            this.roundButton1.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.Location = new System.Drawing.Point(146, 337);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(178, 71);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "Bead";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton2.BackColor2 = System.Drawing.Color.Yellow;
            this.roundButton2.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonRoundRadius = 30;
            this.roundButton2.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton2.Location = new System.Drawing.Point(474, 337);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(178, 71);
            this.roundButton2.TabIndex = 2;
            this.roundButton2.Text = "Middle";
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton3.BackColor2 = System.Drawing.Color.Lime;
            this.roundButton3.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton3.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton3.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton3.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton3.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton3.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton3.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton3.ButtonRoundRadius = 30;
            this.roundButton3.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton3.Location = new System.Drawing.Point(799, 337);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(178, 71);
            this.roundButton3.TabIndex = 3;
            this.roundButton3.Text = "Good";
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "How good you know this word";
            // 
            // NewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.label1);
            this.Name = "NewWord";
            this.Size = new System.Drawing.Size(1143, 668);
            ((System.ComponentModel.ISupportInitialize)(this.regularCustomerBindingSource)).EndInit();
            this.DownPanel.ResumeLayout(false);
            this.DownPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource regularCustomerBindingSource;
        private DataGridViewTextBoxColumn regularCustomerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Panel DownPanel;
        private Label label2;
        private RoundButton roundButton3;
        private RoundButton roundButton2;
        private RoundButton roundButton1;
        private Panel panel1;
        private Label Translate;
        private Label Transcript;
        private Label Word;
    }
}
