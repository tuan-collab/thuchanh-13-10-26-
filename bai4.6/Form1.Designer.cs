namespace QuanLySinhVien
{
    partial class FormStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            //
            // dgv
            //
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.Location = new System.Drawing.Point(10, 10);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 360);
            this.dgv.TabIndex = 0;
            //
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(590, 14);
            this.lblId.Name = "lblId";
            this.lblId.Text = "Mã SV:";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(590, 49);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Họ tên:";
            //
            // lblAge
            //
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(590, 84);
            this.lblAge.Name = "lblAge";
            this.lblAge.Text = "Tuổi:";
            //
            // lblGender
            //
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(590, 118);
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Giới tính:";
            //
            // txtId
            //
            this.txtId.Location = new System.Drawing.Point(660, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 23);
            this.txtId.TabIndex = 1;
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(660, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 23);
            this.txtName.TabIndex = 2;
            //
            // txtAge
            //
            this.txtAge.Location = new System.Drawing.Point(660, 80);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 23);
            this.txtAge.TabIndex = 3;
            //
            // cboGender
            //
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGender.Location = new System.Drawing.Point(660, 114);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(180, 23);
            this.cboGender.TabIndex = 4;
            //
            // pic
            //
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(660, 150);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(140, 140);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabStop = false;
            //
            // btnPick
            //
            this.btnPick.Location = new System.Drawing.Point(660, 298);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(140, 28);
            this.btnPick.TabIndex = 5;
            this.btnPick.Text = "Chọn ảnh";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(10, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDel
            //
            this.btnDel.Location = new System.Drawing.Point(105, 385);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 30);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(200, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnCsv
            //
            this.btnCsv.Location = new System.Drawing.Point(295, 385);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(110, 30);
            this.btnCsv.TabIndex = 9;
            this.btnCsv.Text = "Xuất file CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            //
            // FormStudent
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCsv);
            this.Name = "FormStudent";
            this.Text = "Quản lý Sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCsv;
    }
}