namespace _479414_Axel_Xaverius_Tamtama_ResponsiJuniorProject
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
            btnDelete = new Button();
            btnEdit = new Button();
            btnInsert = new Button();
            lbNama = new Label();
            lbDepKaryawan = new Label();
            pbLogo = new PictureBox();
            lbLogo = new Label();
            rtbIDDepartemen = new RichTextBox();
            dgvData = new DataGridView();
            tbNamaKaryawan = new TextBox();
            tbDepKaryawan = new TextBox();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(21, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 25);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(135, 193);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(72, 25);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(242, 193);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(72, 25);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Location = new Point(21, 118);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(99, 15);
            lbNama.TabIndex = 3;
            lbNama.Text = "Nama Karyawan :";
            // 
            // lbDepKaryawan
            // 
            lbDepKaryawan.AutoSize = true;
            lbDepKaryawan.Location = new Point(21, 148);
            lbDepKaryawan.Name = "lbDepKaryawan";
            lbDepKaryawan.Size = new Size(91, 15);
            lbDepKaryawan.TabIndex = 4;
            lbDepKaryawan.Text = "Dep. Karyawan :";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(50, 50);
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Location = new Point(81, 29);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(34, 15);
            lbLogo.TabIndex = 6;
            lbLogo.Text = "Logo";
            // 
            // rtbIDDepartemen
            // 
            rtbIDDepartemen.Location = new Point(655, 12);
            rtbIDDepartemen.Name = "rtbIDDepartemen";
            rtbIDDepartemen.Size = new Size(133, 102);
            rtbIDDepartemen.TabIndex = 7;
            rtbIDDepartemen.Text = "ID Departemen:\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Product M\nFIN : Finance\n";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(21, 236);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(767, 189);
            dgvData.TabIndex = 8;
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(126, 116);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(188, 23);
            tbNamaKaryawan.TabIndex = 9;
            // 
            // tbDepKaryawan
            // 
            tbDepKaryawan.Location = new Point(126, 145);
            tbDepKaryawan.Name = "tbDepKaryawan";
            tbDepKaryawan.Size = new Size(188, 23);
            tbDepKaryawan.TabIndex = 10;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(678, 193);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(110, 25);
            btnLoadData.TabIndex = 11;
            btnLoadData.Text = "LOAD DATA";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadData);
            Controls.Add(tbDepKaryawan);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(dgvData);
            Controls.Add(rtbIDDepartemen);
            Controls.Add(lbLogo);
            Controls.Add(pbLogo);
            Controls.Add(lbDepKaryawan);
            Controls.Add(lbNama);
            Controls.Add(btnInsert);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnInsert;
        private Label lbNama;
        private Label lbDepKaryawan;
        private PictureBox pbLogo;
        private Label lbLogo;
        private RichTextBox rtbIDDepartemen;
        private DataGridView dgvData;
        private TextBox tbNamaKaryawan;
        private TextBox tbDepKaryawan;
        private Button btnLoadData;
    }
}