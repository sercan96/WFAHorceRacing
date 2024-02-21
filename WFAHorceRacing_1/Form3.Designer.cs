namespace WFAHorceRacing_1
{
    partial class Form3
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
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.lblHesap = new System.Windows.Forms.Label();
            this.lblCuzdan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(45, 91);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 0;
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(45, 146);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(111, 23);
            this.btnParaCek.TabIndex = 1;
            this.btnParaCek.Text = "Para Cek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(45, 194);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(111, 23);
            this.btnParaYatir.TabIndex = 1;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // lblHesap
            // 
            this.lblHesap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHesap.Location = new System.Drawing.Point(292, 91);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(316, 31);
            this.lblHesap.TabIndex = 2;
            this.lblHesap.Text = "Hesap:";
            // 
            // lblCuzdan
            // 
            this.lblCuzdan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCuzdan.Location = new System.Drawing.Point(292, 186);
            this.lblCuzdan.Name = "lblCuzdan";
            this.lblCuzdan.Size = new System.Drawing.Size(316, 31);
            this.lblCuzdan.TabIndex = 2;
            this.lblCuzdan.Text = "Cuzdan:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.lblCuzdan);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.txtMiktar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.Label lblCuzdan;
    }
}