
namespace english_app
{
    partial class Del
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
            this.ruen = new System.Windows.Forms.TextBox();
            this.del_in = new System.Windows.Forms.Button();
            this.name_ruen = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ruen
            // 
            this.ruen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ruen.Location = new System.Drawing.Point(12, 58);
            this.ruen.Name = "ruen";
            this.ruen.Size = new System.Drawing.Size(185, 39);
            this.ruen.TabIndex = 0;
            // 
            // del_in
            // 
            this.del_in.Location = new System.Drawing.Point(226, 101);
            this.del_in.Name = "del_in";
            this.del_in.Size = new System.Drawing.Size(112, 34);
            this.del_in.TabIndex = 1;
            this.del_in.Text = "Удалить";
            this.del_in.UseVisualStyleBackColor = true;
            this.del_in.Click += new System.EventHandler(this.del_in_Click);
            // 
            // name_ruen
            // 
            this.name_ruen.AutoSize = true;
            this.name_ruen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_ruen.Location = new System.Drawing.Point(12, 23);
            this.name_ruen.Name = "name_ruen";
            this.name_ruen.Size = new System.Drawing.Size(83, 32);
            this.name_ruen.TabIndex = 2;
            this.name_ruen.Text = "Слово";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.Location = new System.Drawing.Point(226, 23);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(113, 32);
            this.status.TabIndex = 3;
            this.status.Text = "Успешно";
            this.status.Visible = false;
            // 
            // Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 147);
            this.Controls.Add(this.status);
            this.Controls.Add(this.name_ruen);
            this.Controls.Add(this.del_in);
            this.Controls.Add(this.ruen);
            this.Name = "Del";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramz_ild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ruen;
        private System.Windows.Forms.Button del_in;
        private System.Windows.Forms.Label name_ruen;
        private System.Windows.Forms.Label status;
    }
}