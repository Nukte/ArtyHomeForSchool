namespace ArtyHome
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
            this.components = new System.ComponentModel.Container();
            this.micButton = new System.Windows.Forms.Button();
            this.portSelectComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.portSelectComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portSelectComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // micButton
            // 
            this.micButton.BackColor = System.Drawing.Color.Black;
            this.micButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.micButton.FlatAppearance.BorderSize = 2;
            this.micButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.micButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.micButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.micButton.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.micButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.micButton.Image = global::ArtyHome.Properties.Resources.mic;
            this.micButton.Location = new System.Drawing.Point(189, 100);
            this.micButton.Name = "micButton";
            this.micButton.Size = new System.Drawing.Size(174, 158);
            this.micButton.TabIndex = 0;
            this.micButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.micButton.UseVisualStyleBackColor = false;
            this.micButton.Click += new System.EventHandler(this.micButton_Click);
            // 
            // portSelectComboBox1
            // 
            this.portSelectComboBox1.FormattingEnabled = true;
            this.portSelectComboBox1.ItemHeight = 23;
            this.portSelectComboBox1.Location = new System.Drawing.Point(31, 100);
            this.portSelectComboBox1.Name = "portSelectComboBox1";
            this.portSelectComboBox1.Size = new System.Drawing.Size(152, 29);
            this.portSelectComboBox1.TabIndex = 1;
            this.portSelectComboBox1.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(251, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(251, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 1);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(148, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Konuşmak için yukardaki Buttona basın.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arduino Portu Seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Arduino Portu Seçin";
            // 
            // portSelectComboBox2
            // 
            this.portSelectComboBox2.FormattingEnabled = true;
            this.portSelectComboBox2.ItemHeight = 23;
            this.portSelectComboBox2.Location = new System.Drawing.Point(31, 164);
            this.portSelectComboBox2.Name = "portSelectComboBox2";
            this.portSelectComboBox2.Size = new System.Drawing.Size(152, 29);
            this.portSelectComboBox2.TabIndex = 6;
            this.portSelectComboBox2.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(40, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Arduino Portu Seçin";
            // 
            // portSelectComboBox3
            // 
            this.portSelectComboBox3.FormattingEnabled = true;
            this.portSelectComboBox3.ItemHeight = 23;
            this.portSelectComboBox3.Location = new System.Drawing.Point(31, 229);
            this.portSelectComboBox3.Name = "portSelectComboBox3";
            this.portSelectComboBox3.Size = new System.Drawing.Size(152, 29);
            this.portSelectComboBox3.TabIndex = 8;
            this.portSelectComboBox3.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(558, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portSelectComboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portSelectComboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.portSelectComboBox1);
            this.Controls.Add(this.micButton);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Arty Home";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button micButton;
        private MetroFramework.Controls.MetroComboBox portSelectComboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox portSelectComboBox2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox portSelectComboBox3;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
    }
}

