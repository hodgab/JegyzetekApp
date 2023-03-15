namespace JegyzetekApp
{
    partial class form_foablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_foablak));
            this.pnl_fejlec = new System.Windows.Forms.Panel();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.txt_uj_jegyzet = new System.Windows.Forms.TextBox();
            this.lbl_cim = new System.Windows.Forms.Label();
            this.pnl_fo = new System.Windows.Forms.Panel();
            this.btn_bezaras = new System.Windows.Forms.Button();
            this.pnl_fejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fejlec
            // 
            this.pnl_fejlec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(145)))), ((int)(((byte)(126)))));
            this.pnl_fejlec.Controls.Add(this.btn_bezaras);
            this.pnl_fejlec.Controls.Add(this.btn_hozzaad);
            this.pnl_fejlec.Controls.Add(this.txt_uj_jegyzet);
            this.pnl_fejlec.Controls.Add(this.lbl_cim);
            this.pnl_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_fejlec.Location = new System.Drawing.Point(0, 0);
            this.pnl_fejlec.Name = "pnl_fejlec";
            this.pnl_fejlec.Size = new System.Drawing.Size(485, 90);
            this.pnl_fejlec.TabIndex = 0;
            this.pnl_fejlec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_fejlec_Paint);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hozzaad.BackgroundImage")));
            this.btn_hozzaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hozzaad.FlatAppearance.BorderSize = 0;
            this.btn_hozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hozzaad.Location = new System.Drawing.Point(391, 42);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(33, 33);
            this.btn_hozzaad.TabIndex = 3;
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // txt_uj_jegyzet
            // 
            this.txt_uj_jegyzet.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uj_jegyzet.Location = new System.Drawing.Point(140, 42);
            this.txt_uj_jegyzet.Name = "txt_uj_jegyzet";
            this.txt_uj_jegyzet.Size = new System.Drawing.Size(245, 33);
            this.txt_uj_jegyzet.TabIndex = 2;
            // 
            // lbl_cim
            // 
            this.lbl_cim.AutoSize = true;
            this.lbl_cim.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cim.ForeColor = System.Drawing.Color.Black;
            this.lbl_cim.Location = new System.Drawing.Point(3, 42);
            this.lbl_cim.Name = "lbl_cim";
            this.lbl_cim.Size = new System.Drawing.Size(138, 28);
            this.lbl_cim.TabIndex = 1;
            this.lbl_cim.Text = "Jegyzetek:";
            // 
            // pnl_fo
            // 
            this.pnl_fo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fo.Location = new System.Drawing.Point(0, 90);
            this.pnl_fo.Name = "pnl_fo";
            this.pnl_fo.Size = new System.Drawing.Size(485, 360);
            this.pnl_fo.TabIndex = 1;
            // 
            // btn_bezaras
            // 
            this.btn_bezaras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bezaras.BackgroundImage")));
            this.btn_bezaras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bezaras.FlatAppearance.BorderSize = 0;
            this.btn_bezaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bezaras.Location = new System.Drawing.Point(448, 12);
            this.btn_bezaras.Name = "btn_bezaras";
            this.btn_bezaras.Size = new System.Drawing.Size(25, 25);
            this.btn_bezaras.TabIndex = 4;
            this.btn_bezaras.UseVisualStyleBackColor = true;
            this.btn_bezaras.Click += new System.EventHandler(this.btn_bezaras_Click);
            // 
            // form_foablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.pnl_fo);
            this.Controls.Add(this.pnl_fejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_foablak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_fejlec.ResumeLayout(false);
            this.pnl_fejlec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fejlec;
        private System.Windows.Forms.Label lbl_cim;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.TextBox txt_uj_jegyzet;
        private System.Windows.Forms.Panel pnl_fo;
        private System.Windows.Forms.Button btn_bezaras;
    }
}

