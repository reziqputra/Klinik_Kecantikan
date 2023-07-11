namespace Klinik_Kecantikan
{
    partial class DataPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPasien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPasien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.txtNamaP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxJP = new System.Windows.Forms.ComboBox();
            this.cbxRK = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJK = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(315, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(397, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pasien";
            // 
            // txtIdPasien
            // 
            this.txtIdPasien.Location = new System.Drawing.Point(524, 40);
            this.txtIdPasien.Name = "txtIdPasien";
            this.txtIdPasien.Size = new System.Drawing.Size(203, 22);
            this.txtIdPasien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(397, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(397, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(397, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(397, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Umur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(397, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(524, 207);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(203, 22);
            this.txtAlamat.TabIndex = 8;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(524, 173);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(203, 22);
            this.txtNoTelp.TabIndex = 9;
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(524, 109);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(203, 22);
            this.txtUmur.TabIndex = 11;
            // 
            // txtNamaP
            // 
            this.txtNamaP.Location = new System.Drawing.Point(524, 74);
            this.txtNamaP.Name = "txtNamaP";
            this.txtNamaP.Size = new System.Drawing.Size(203, 22);
            this.txtNamaP.TabIndex = 12;
            this.txtNamaP.TextChanged += new System.EventHandler(this.txtNamaP_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 32);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(483, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(698, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(137, 379);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(81, 32);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(586, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(397, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Staff";
            // 
            // cbxStaff
            // 
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(524, 239);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(203, 24);
            this.cbxStaff.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(397, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Jenis Perawatan";
            // 
            // cbxJP
            // 
            this.cbxJP.FormattingEnabled = true;
            this.cbxJP.Location = new System.Drawing.Point(524, 272);
            this.cbxJP.Name = "cbxJP";
            this.cbxJP.Size = new System.Drawing.Size(203, 24);
            this.cbxJP.TabIndex = 23;
            // 
            // cbxRK
            // 
            this.cbxRK.FormattingEnabled = true;
            this.cbxRK.Location = new System.Drawing.Point(524, 306);
            this.cbxRK.Name = "cbxRK";
            this.cbxRK.Size = new System.Drawing.Size(203, 24);
            this.cbxRK.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(397, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Riwayat";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtJK
            // 
            this.txtJK.Location = new System.Drawing.Point(524, 140);
            this.txtJK.Name = "txtJK";
            this.txtJK.Size = new System.Drawing.Size(203, 22);
            this.txtJK.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(387, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DataPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtJK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxRK);
            this.Controls.Add(this.cbxJP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNamaP);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPasien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataPasien";
            this.Text = "Data Pasien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPasien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtNamaP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxJP;
        private System.Windows.Forms.ComboBox cbxRK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJK;
        private System.Windows.Forms.Button btnUpdate;
    }
}