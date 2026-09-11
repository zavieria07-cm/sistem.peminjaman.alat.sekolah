
namespace project1_ridho
{
    partial class FormApproval
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
            this.dgvApproval = new System.Windows.Forms.DataGridView();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnACC = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApproval
            // 
            this.dgvApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproval.Location = new System.Drawing.Point(13, 271);
            this.dgvApproval.Name = "dgvApproval";
            this.dgvApproval.Size = new System.Drawing.Size(788, 150);
            this.dgvApproval.TabIndex = 0;
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(24, 110);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(122, 20);
            this.txtCatatan.TabIndex = 1;
            // 
            // btnACC
            // 
            this.btnACC.BackColor = System.Drawing.Color.Lime;
            this.btnACC.Location = new System.Drawing.Point(38, 136);
            this.btnACC.Name = "btnACC";
            this.btnACC.Size = new System.Drawing.Size(75, 23);
            this.btnACC.TabIndex = 2;
            this.btnACC.Text = "Setujui";
            this.btnACC.UseVisualStyleBackColor = false;
            // 
            // btnTolak
            // 
            this.btnTolak.BackColor = System.Drawing.Color.Red;
            this.btnTolak.Location = new System.Drawing.Point(38, 165);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(75, 23);
            this.btnTolak.TabIndex = 3;
            this.btnTolak.Text = "Tolak";
            this.btnTolak.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(363, 214);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnACC);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.dgvApproval);
            this.Name = "FormApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormApproval";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApproval;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnACC;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Button btnLogout;
    }
}