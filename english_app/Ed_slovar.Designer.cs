
namespace english_app
{
    partial class Ed_slovar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.slovar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.slovar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 346);
            this.panel1.TabIndex = 0;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(591, 287);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(112, 56);
            this.del.TabIndex = 1;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 287);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 56);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // slovar
            // 
            this.slovar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slovar.Location = new System.Drawing.Point(0, 3);
            this.slovar.Multiline = true;
            this.slovar.Name = "slovar";
            this.slovar.PlaceholderText = "Пусто";
            this.slovar.ReadOnly = true;
            this.slovar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.slovar.Size = new System.Drawing.Size(703, 278);
            this.slovar.TabIndex = 2;
            // 
            // Ed_slovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 346);
            this.Controls.Add(this.panel1);
            this.Name = "Ed_slovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramz_ild";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ed_slovar_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        public System.Windows.Forms.TextBox slovar;
    }
}