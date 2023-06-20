namespace ConversaoIEEE754
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
            this.gBoxEscrita = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtByteEscrita = new System.Windows.Forms.TextBox();
            this.btnEscrever = new System.Windows.Forms.Button();
            this.lblEscritaByte2 = new System.Windows.Forms.Label();
            this.txtEscritaByte2 = new System.Windows.Forms.TextBox();
            this.lblEscritaByte1 = new System.Windows.Forms.Label();
            this.txtEscritaByte1 = new System.Windows.Forms.TextBox();
            this.lblEscritaFloat = new System.Windows.Forms.Label();
            this.txtEscritaFloat = new System.Windows.Forms.TextBox();
            this.gBoxLeitura = new System.Windows.Forms.GroupBox();
            this.btnLeitura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeituraFloat = new System.Windows.Forms.TextBox();
            this.txtLeituraByte2 = new System.Windows.Forms.TextBox();
            this.txtLeituraByte1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxEscrita.SuspendLayout();
            this.gBoxLeitura.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxEscrita
            // 
            this.gBoxEscrita.Controls.Add(this.label4);
            this.gBoxEscrita.Controls.Add(this.txtByteEscrita);
            this.gBoxEscrita.Controls.Add(this.btnEscrever);
            this.gBoxEscrita.Controls.Add(this.lblEscritaByte2);
            this.gBoxEscrita.Controls.Add(this.txtEscritaByte2);
            this.gBoxEscrita.Controls.Add(this.lblEscritaByte1);
            this.gBoxEscrita.Controls.Add(this.txtEscritaByte1);
            this.gBoxEscrita.Controls.Add(this.lblEscritaFloat);
            this.gBoxEscrita.Controls.Add(this.txtEscritaFloat);
            this.gBoxEscrita.Location = new System.Drawing.Point(41, 66);
            this.gBoxEscrita.Name = "gBoxEscrita";
            this.gBoxEscrita.Size = new System.Drawing.Size(278, 248);
            this.gBoxEscrita.TabIndex = 0;
            this.gBoxEscrita.TabStop = false;
            this.gBoxEscrita.Text = "Escrita";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Byte Inteiro";
            // 
            // txtByteEscrita
            // 
            this.txtByteEscrita.Location = new System.Drawing.Point(74, 82);
            this.txtByteEscrita.Name = "txtByteEscrita";
            this.txtByteEscrita.Size = new System.Drawing.Size(100, 20);
            this.txtByteEscrita.TabIndex = 7;
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(180, 15);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(62, 21);
            this.btnEscrever.TabIndex = 6;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // lblEscritaByte2
            // 
            this.lblEscritaByte2.Location = new System.Drawing.Point(6, 134);
            this.lblEscritaByte2.Name = "lblEscritaByte2";
            this.lblEscritaByte2.Size = new System.Drawing.Size(62, 17);
            this.lblEscritaByte2.TabIndex = 5;
            this.lblEscritaByte2.Text = "Byte 2";
            // 
            // txtEscritaByte2
            // 
            this.txtEscritaByte2.Location = new System.Drawing.Point(74, 134);
            this.txtEscritaByte2.Name = "txtEscritaByte2";
            this.txtEscritaByte2.Size = new System.Drawing.Size(100, 20);
            this.txtEscritaByte2.TabIndex = 4;
            // 
            // lblEscritaByte1
            // 
            this.lblEscritaByte1.Location = new System.Drawing.Point(6, 108);
            this.lblEscritaByte1.Name = "lblEscritaByte1";
            this.lblEscritaByte1.Size = new System.Drawing.Size(62, 17);
            this.lblEscritaByte1.TabIndex = 3;
            this.lblEscritaByte1.Text = "Byte 1";
            // 
            // txtEscritaByte1
            // 
            this.txtEscritaByte1.Location = new System.Drawing.Point(74, 108);
            this.txtEscritaByte1.Name = "txtEscritaByte1";
            this.txtEscritaByte1.Size = new System.Drawing.Size(100, 20);
            this.txtEscritaByte1.TabIndex = 2;
            // 
            // lblEscritaFloat
            // 
            this.lblEscritaFloat.Location = new System.Drawing.Point(6, 19);
            this.lblEscritaFloat.Name = "lblEscritaFloat";
            this.lblEscritaFloat.Size = new System.Drawing.Size(62, 28);
            this.lblEscritaFloat.TabIndex = 1;
            this.lblEscritaFloat.Text = "Escrever";
            // 
            // txtEscritaFloat
            // 
            this.txtEscritaFloat.Location = new System.Drawing.Point(74, 16);
            this.txtEscritaFloat.Name = "txtEscritaFloat";
            this.txtEscritaFloat.Size = new System.Drawing.Size(100, 20);
            this.txtEscritaFloat.TabIndex = 0;
            // 
            // gBoxLeitura
            // 
            this.gBoxLeitura.Controls.Add(this.btnLeitura);
            this.gBoxLeitura.Controls.Add(this.label3);
            this.gBoxLeitura.Controls.Add(this.label1);
            this.gBoxLeitura.Controls.Add(this.txtLeituraFloat);
            this.gBoxLeitura.Controls.Add(this.txtLeituraByte2);
            this.gBoxLeitura.Controls.Add(this.txtLeituraByte1);
            this.gBoxLeitura.Controls.Add(this.label2);
            this.gBoxLeitura.Location = new System.Drawing.Point(411, 66);
            this.gBoxLeitura.Name = "gBoxLeitura";
            this.gBoxLeitura.Size = new System.Drawing.Size(278, 248);
            this.gBoxLeitura.TabIndex = 1;
            this.gBoxLeitura.TabStop = false;
            this.gBoxLeitura.Text = "Leitura";
            // 
            // btnLeitura
            // 
            this.btnLeitura.Location = new System.Drawing.Point(94, 73);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(62, 21);
            this.btnLeitura.TabIndex = 7;
            this.btnLeitura.Text = "Escrever";
            this.btnLeitura.UseVisualStyleBackColor = true;
            this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leitura";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Byte 2";
            // 
            // txtLeituraFloat
            // 
            this.txtLeituraFloat.Location = new System.Drawing.Point(94, 134);
            this.txtLeituraFloat.Name = "txtLeituraFloat";
            this.txtLeituraFloat.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraFloat.TabIndex = 2;
            // 
            // txtLeituraByte2
            // 
            this.txtLeituraByte2.Location = new System.Drawing.Point(94, 47);
            this.txtLeituraByte2.Name = "txtLeituraByte2";
            this.txtLeituraByte2.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraByte2.TabIndex = 8;
            // 
            // txtLeituraByte1
            // 
            this.txtLeituraByte1.Location = new System.Drawing.Point(94, 21);
            this.txtLeituraByte1.Name = "txtLeituraByte1";
            this.txtLeituraByte1.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraByte1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Byte 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxLeitura);
            this.Controls.Add(this.gBoxEscrita);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.gBoxEscrita.ResumeLayout(false);
            this.gBoxEscrita.PerformLayout();
            this.gBoxLeitura.ResumeLayout(false);
            this.gBoxLeitura.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtByteEscrita;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLeitura;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeituraFloat;

        private System.Windows.Forms.TextBox txtEscritaFloat;
        private System.Windows.Forms.Label lblEscritaByte2;
        private System.Windows.Forms.TextBox txtLeituraByte2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeituraByte1;

        private System.Windows.Forms.Label lblEscritaFloat;
        private System.Windows.Forms.Label lblEscritaByte1;
        private System.Windows.Forms.TextBox txtEscritaByte1;
        private System.Windows.Forms.TextBox txtEscritaByte2;

        private System.Windows.Forms.TextBox txtEscrita1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox gBoxEscrita;
        private System.Windows.Forms.GroupBox gBoxLeitura;

        #endregion
    }
}