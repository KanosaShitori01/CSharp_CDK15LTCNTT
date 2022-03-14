namespace WindowsFormsApplication1
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
            this.trv_da = new System.Windows.Forms.TreeView();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tsnvtg = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_tsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_mada = new System.Windows.Forms.ComboBox();
            this.txt_tenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sgtg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIOTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // trv_da
            // 
            this.trv_da.Location = new System.Drawing.Point(12, 12);
            this.trv_da.Name = "trv_da";
            this.trv_da.Size = new System.Drawing.Size(176, 412);
            this.trv_da.TabIndex = 0;
            this.trv_da.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_da_AfterSelect);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADA,
            this.TENDA,
            this.MaNV,
            this.TenNV,
            this.SOGIOTG});
            this.dataGV.Location = new System.Drawing.Point(197, 12);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(512, 189);
            this.dataGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng số nhân viên tham gia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_tsnvtg
            // 
            this.txt_tsnvtg.Location = new System.Drawing.Point(350, 211);
            this.txt_tsnvtg.Name = "txt_tsnvtg";
            this.txt_tsnvtg.Size = new System.Drawing.Size(100, 20);
            this.txt_tsnvtg.TabIndex = 3;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(498, 297);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(93, 39);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tsg
            // 
            this.txt_tsg.Location = new System.Drawing.Point(576, 211);
            this.txt_tsg.Name = "txt_tsg";
            this.txt_tsg.Size = new System.Drawing.Size(100, 20);
            this.txt_tsg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng số giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông Tin Nhân Viên Tham Gia Dự Án";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(498, 342);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 39);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã Dự Án";
            // 
            // cb_mada
            // 
            this.cb_mada.FormattingEnabled = true;
            this.cb_mada.Location = new System.Drawing.Point(288, 283);
            this.cb_mada.Name = "cb_mada";
            this.cb_mada.Size = new System.Drawing.Size(121, 21);
            this.cb_mada.TabIndex = 11;
            this.cb_mada.SelectedIndexChanged += new System.EventHandler(this.cb_mahd_SelectedIndexChanged);
            // 
            // txt_tenda
            // 
            this.txt_tenda.Location = new System.Drawing.Point(288, 316);
            this.txt_tenda.Name = "txt_tenda";
            this.txt_tenda.Size = new System.Drawing.Size(121, 20);
            this.txt_tenda.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên Dự Án";
            // 
            // txt_sgtg
            // 
            this.txt_sgtg.Location = new System.Drawing.Point(288, 385);
            this.txt_sgtg.Name = "txt_sgtg";
            this.txt_sgtg.Size = new System.Drawing.Size(121, 20);
            this.txt_sgtg.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số Giờ Tham Gia";
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(288, 352);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(121, 21);
            this.cb_manv.TabIndex = 15;
            this.cb_manv.SelectedIndexChanged += new System.EventHandler(this.cb_manv_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên Nhân Viên";
            // 
            // MADA
            // 
            this.MADA.DataPropertyName = "MADA";
            this.MADA.HeaderText = "Mã Dự Án";
            this.MADA.Name = "MADA";
            // 
            // TENDA
            // 
            this.TENDA.DataPropertyName = "TENDA";
            this.TENDA.HeaderText = "Tên Dự Án";
            this.TENDA.Name = "TENDA";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MANV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "HOTEN";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // SOGIOTG
            // 
            this.SOGIOTG.DataPropertyName = "SOGIOLAMVIEC";
            this.SOGIOTG.HeaderText = "Số Giờ Tham Gia";
            this.SOGIOTG.Name = "SOGIOTG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 436);
            this.Controls.Add(this.txt_sgtg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_manv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_mada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_tsnvtg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.trv_da);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trv_da;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tsnvtg;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_tsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_mada;
        private System.Windows.Forms.TextBox txt_tenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sgtg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIOTG;
    }
}

