namespace Klinik_Kecantikan
{
    partial class Perawatan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perawatan));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDRS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJP = new System.Windows.Forms.TextBox();
            this.txtHRG = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxIDP = new System.Windows.Forms.ComboBox();
            this.cbxIDD = new System.Windows.Forms.ComboBox();
            this.txtPRWTN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perawatan";
            // 
            // txtDRS
            // 
            this.txtDRS.Location = new System.Drawing.Point(422, 299);
            this.txtDRS.Name = "txtDRS";
            this.txtDRS.Size = new System.Drawing.Size(186, 22);
            this.txtDRS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jenis Perawatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga";
            // 
            // txtJP
            // 
            this.txtJP.Location = new System.Drawing.Point(422, 252);
            this.txtJP.Name = "txtJP";
            this.txtJP.Size = new System.Drawing.Size(186, 22);
            this.txtJP.TabIndex = 7;
            // 
            // txtHRG
            // 
            this.txtHRG.Location = new System.Drawing.Point(422, 345);
            this.txtHRG.Name = "txtHRG";
            this.txtHRG.Size = new System.Drawing.Size(186, 22);
            this.txtHRG.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(665, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(665, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(665, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 33);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 388);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 32);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pasien";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dokter";
            // 
            // cbxIDP
            // 
            this.cbxIDP.FormattingEnabled = true;
            this.cbxIDP.Location = new System.Drawing.Point(422, 200);
            this.cbxIDP.Name = "cbxIDP";
            this.cbxIDP.Size = new System.Drawing.Size(186, 24);
            this.cbxIDP.TabIndex = 18;
            // 
            // cbxIDD
            // 
            this.cbxIDD.FormattingEnabled = true;
            this.cbxIDD.Location = new System.Drawing.Point(422, 152);
            this.cbxIDD.Name = "cbxIDD";
            this.cbxIDD.Size = new System.Drawing.Size(186, 24);
            this.cbxIDD.TabIndex = 19;
            // 
            // txtPRWTN
            // 
            this.txtPRWTN.Location = new System.Drawing.Point(422, 99);
            this.txtPRWTN.Name = "txtPRWTN";
            this.txtPRWTN.Size = new System.Drawing.Size(186, 22);
            this.txtPRWTN.TabIndex = 20;
            // 
            // Perawatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPRWTN);
            this.Controls.Add(this.cbxIDD);
            this.Controls.Add(this.cbxIDP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHRG);
            this.Controls.Add(this.txtJP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDRS);
            this.Controls.Add(this.label1);
            this.Name = "Perawatan";
            this.Text = "Perawatan";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDRS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJP;
        private System.Windows.Forms.TextBox txtHRG;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxIDP;
        private System.Windows.Forms.ComboBox cbxIDD;
        private System.Windows.Forms.TextBox txtPRWTN;
    }
}