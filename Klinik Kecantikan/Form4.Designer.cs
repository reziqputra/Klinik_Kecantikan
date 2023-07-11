namespace Klinik_Kecantikan
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxIDPR = new System.Windows.Forms.ComboBox();
            this.cbxIDP = new System.Windows.Forms.ComboBox();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.txtJP = new System.Windows.Forms.TextBox();
            this.txtHRG = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Produk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis_Produk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // cbxIDPR
            // 
            this.cbxIDPR.FormattingEnabled = true;
            this.cbxIDPR.Location = new System.Drawing.Point(385, 74);
            this.cbxIDPR.Name = "cbxIDPR";
            this.cbxIDPR.Size = new System.Drawing.Size(189, 24);
            this.cbxIDPR.TabIndex = 5;
            // 
            // cbxIDP
            // 
            this.cbxIDP.FormattingEnabled = true;
            this.cbxIDP.IntegralHeight = false;
            this.cbxIDP.Location = new System.Drawing.Point(385, 122);
            this.cbxIDP.Name = "cbxIDP";
            this.cbxIDP.Size = new System.Drawing.Size(189, 24);
            this.cbxIDP.TabIndex = 6;
            // 
            // txtNP
            // 
            this.txtNP.Location = new System.Drawing.Point(385, 165);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(189, 22);
            this.txtNP.TabIndex = 7;
            // 
            // txtJP
            // 
            this.txtJP.Location = new System.Drawing.Point(385, 204);
            this.txtJP.Name = "txtJP";
            this.txtJP.Size = new System.Drawing.Size(189, 22);
            this.txtJP.TabIndex = 8;
            // 
            // txtHRG
            // 
            this.txtHRG.Location = new System.Drawing.Point(385, 246);
            this.txtHRG.Name = "txtHRG";
            this.txtHRG.Size = new System.Drawing.Size(189, 22);
            this.txtHRG.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtHRG);
            this.Controls.Add(this.txtJP);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.cbxIDP);
            this.Controls.Add(this.cbxIDPR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Produk Kecantikan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxIDPR;
        private System.Windows.Forms.ComboBox cbxIDP;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.TextBox txtJP;
        private System.Windows.Forms.TextBox txtHRG;
        private System.Windows.Forms.Button btnBack;
    }
}