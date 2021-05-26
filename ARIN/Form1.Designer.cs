
namespace ARIN
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DamageTextBox = new System.Windows.Forms.TextBox();
            this.PlayerDamageLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.HPTextBox = new System.Windows.Forms.TextBox();
            this.PercentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arinTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "25초";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(112, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "40초";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 39);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DamageTextBox
            // 
            this.DamageTextBox.Location = new System.Drawing.Point(22, 72);
            this.DamageTextBox.Name = "DamageTextBox";
            this.DamageTextBox.Size = new System.Drawing.Size(199, 23);
            this.DamageTextBox.TabIndex = 6;
            // 
            // PlayerDamageLabel
            // 
            this.PlayerDamageLabel.AutoSize = true;
            this.PlayerDamageLabel.Location = new System.Drawing.Point(22, 54);
            this.PlayerDamageLabel.Name = "PlayerDamageLabel";
            this.PlayerDamageLabel.Size = new System.Drawing.Size(43, 15);
            this.PlayerDamageLabel.TabIndex = 7;
            this.PlayerDamageLabel.Text = "데미지";
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Location = new System.Drawing.Point(22, 163);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(57, 15);
            this.HPLabel.TabIndex = 8;
            this.HPLabel.Text = "BOSS HP";
            // 
            // HPTextBox
            // 
            this.HPTextBox.Location = new System.Drawing.Point(22, 210);
            this.HPTextBox.Name = "HPTextBox";
            this.HPTextBox.Size = new System.Drawing.Size(199, 23);
            this.HPTextBox.TabIndex = 9;
            // 
            // PercentComboBox
            // 
            this.PercentComboBox.FormattingEnabled = true;
            this.PercentComboBox.Location = new System.Drawing.Point(22, 239);
            this.PercentComboBox.Name = "PercentComboBox";
            this.PercentComboBox.Size = new System.Drawing.Size(199, 23);
            this.PercentComboBox.TabIndex = 10;
            this.PercentComboBox.SelectedIndexChanged += new System.EventHandler(this.PercentComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "아린3 데미지 감소율(%)";
            // 
            // arinTextBox
            // 
            this.arinTextBox.Location = new System.Drawing.Point(22, 116);
            this.arinTextBox.Name = "arinTextBox";
            this.arinTextBox.Size = new System.Drawing.Size(199, 23);
            this.arinTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 317);
            this.Controls.Add(this.arinTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PercentComboBox);
            this.Controls.Add(this.HPTextBox);
            this.Controls.Add(this.HPLabel);
            this.Controls.Add(this.PlayerDamageLabel);
            this.Controls.Add(this.DamageTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox DamageTextBox;
        private System.Windows.Forms.Label PlayerDamageLabel;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.TextBox HPTextBox;
        private System.Windows.Forms.ComboBox PercentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arinTextBox;
    }
}

