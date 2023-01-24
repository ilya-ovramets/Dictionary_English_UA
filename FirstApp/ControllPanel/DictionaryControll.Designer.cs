using FirstApp.Custom;

namespace FirstApp.ControllPanel
{
    partial class DictionaryControll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StrongWords = new FirstApp.Custom.SmoothProgressBar();
            this.MiddleWords = new FirstApp.Custom.SmoothProgressBar();
            this.WeakWords = new FirstApp.Custom.SmoothProgressBar();
            this.DictionDGV = new System.Windows.Forms.DataGridView();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundButton1 = new FirstApp.Custom.RoundButton();
            this.roundButton2 = new FirstApp.Custom.RoundButton();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DictionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dictionary";
            // 
            // UpPanel
            // 
            this.UpPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpPanel.Controls.Add(this.label6);
            this.UpPanel.Controls.Add(this.label5);
            this.UpPanel.Controls.Add(this.label4);
            this.UpPanel.Controls.Add(this.StrongWords);
            this.UpPanel.Controls.Add(this.MiddleWords);
            this.UpPanel.Controls.Add(this.WeakWords);
            this.UpPanel.Controls.Add(this.DictionDGV);
            this.UpPanel.Location = new System.Drawing.Point(0, 63);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1143, 602);
            this.UpPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(893, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Strong Words";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(893, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Middle Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(893, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weak Words";
            // 
            // StrongWords
            // 
            this.StrongWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StrongWords.Location = new System.Drawing.Point(893, 400);
            this.StrongWords.Maximum = 100;
            this.StrongWords.Minimum = 0;
            this.StrongWords.Name = "StrongWords";
            this.StrongWords.ProgressBarColor = System.Drawing.Color.Lime;
            this.StrongWords.Size = new System.Drawing.Size(216, 59);
            this.StrongWords.TabIndex = 4;
            this.StrongWords.Value = 0;
            // 
            // MiddleWords
            // 
            this.MiddleWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MiddleWords.Location = new System.Drawing.Point(893, 271);
            this.MiddleWords.Maximum = 100;
            this.MiddleWords.Minimum = 0;
            this.MiddleWords.Name = "MiddleWords";
            this.MiddleWords.ProgressBarColor = System.Drawing.Color.Yellow;
            this.MiddleWords.Size = new System.Drawing.Size(216, 59);
            this.MiddleWords.TabIndex = 3;
            this.MiddleWords.Value = 0;
            // 
            // WeakWords
            // 
            this.WeakWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeakWords.Location = new System.Drawing.Point(893, 144);
            this.WeakWords.Maximum = 100;
            this.WeakWords.Minimum = 0;
            this.WeakWords.Name = "WeakWords";
            this.WeakWords.ProgressBarColor = System.Drawing.Color.Red;
            this.WeakWords.Size = new System.Drawing.Size(216, 59);
            this.WeakWords.TabIndex = 2;
            this.WeakWords.Value = 0;
            // 
            // DictionDGV
            // 
            this.DictionDGV.AllowUserToAddRows = false;
            this.DictionDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DictionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DictionDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DictionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DictionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DictionDGV.Location = new System.Drawing.Point(27, 26);
            this.DictionDGV.Name = "DictionDGV";
            this.DictionDGV.ReadOnly = true;
            this.DictionDGV.RowHeadersWidth = 45;
            this.DictionDGV.RowTemplate.Height = 27;
            this.DictionDGV.Size = new System.Drawing.Size(848, 544);
            this.DictionDGV.TabIndex = 0;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataSource = typeof(FirstApp.DataBase.Word);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTB.Location = new System.Drawing.Point(328, 28);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(202, 32);
            this.UserNameTB.TabIndex = 3;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTB.Location = new System.Drawing.Point(556, 28);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(202, 32);
            this.PasswordTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(329, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(556, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
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
            this.roundButton1.ButtonRoundRadius = 30;
            this.roundButton1.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.Location = new System.Drawing.Point(805, 12);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(159, 48);
            this.roundButton1.TabIndex = 7;
            this.roundButton1.Text = "Login";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton2.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton2.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonRoundRadius = 30;
            this.roundButton2.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundButton2.Location = new System.Drawing.Point(970, 12);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(159, 48);
            this.roundButton2.TabIndex = 8;
            this.roundButton2.Text = "Sing Up";
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // DictionaryControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.label1);
            this.Name = "DictionaryControll";
            this.Size = new System.Drawing.Size(1143, 668);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DictionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel UpPanel;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shopIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn corpEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn positionIdDataGridViewTextBoxColumn;
        private DataGridView DictionDGV;
        private TextBox UserNameTB;
        private TextBox PasswordTB;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private SmoothProgressBar StrongWords;
        private SmoothProgressBar MiddleWords;
        private SmoothProgressBar WeakWords;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private DataGridViewTextBoxColumn wordsdictionariesDataGridViewTextBoxColumn;
        private BindingSource wordBindingSource;
    }
}
