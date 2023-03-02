namespace HeChuyenGia_Nhom2
{
    partial class Main
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
            this.btnsukien = new System.Windows.Forms.Button();
            this.btnluat = new System.Windows.Forms.Button();
            this.btntuvan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsukien
            // 
            this.btnsukien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsukien.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsukien.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsukien.Location = new System.Drawing.Point(35, 108);
            this.btnsukien.Name = "btnsukien";
            this.btnsukien.Size = new System.Drawing.Size(134, 39);
            this.btnsukien.TabIndex = 0;
            this.btnsukien.Text = "Sự Kiện";
            this.btnsukien.UseVisualStyleBackColor = false;
            this.btnsukien.Click += new System.EventHandler(this.btnsukien_Click);
            // 
            // btnluat
            // 
            this.btnluat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnluat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnluat.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluat.Location = new System.Drawing.Point(35, 153);
            this.btnluat.Name = "btnluat";
            this.btnluat.Size = new System.Drawing.Size(134, 39);
            this.btnluat.TabIndex = 0;
            this.btnluat.Text = "Luật";
            this.btnluat.UseVisualStyleBackColor = false;
            this.btnluat.Click += new System.EventHandler(this.btnluat_Click);
            // 
            // btntuvan
            // 
            this.btntuvan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btntuvan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntuvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntuvan.Location = new System.Drawing.Point(35, 261);
            this.btntuvan.Name = "btntuvan";
            this.btntuvan.Size = new System.Drawing.Size(134, 39);
            this.btntuvan.TabIndex = 0;
            this.btntuvan.Text = "Tư Vấn";
            this.btntuvan.UseVisualStyleBackColor = false;
            this.btntuvan.Click += new System.EventHandler(this.btntuvan_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::HeChuyenGia_Nhom2.Properties.Resources.chon_nghe_phu_hop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.btntuvan);
            this.Controls.Add(this.btnluat);
            this.Controls.Add(this.btnsukien);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "HỆ CHUYÊN GIA TƯ VẤN CHỌN NGÀNH HỌC";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsukien;
        private System.Windows.Forms.Button btnluat;
        private System.Windows.Forms.Button btntuvan;
    }
}

