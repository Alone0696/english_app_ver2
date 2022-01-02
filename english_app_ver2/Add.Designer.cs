
namespace english_app
{
    partial class Add
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
            this.ru_name = new System.Windows.Forms.Label();
            this.en_name = new System.Windows.Forms.Label();
            this.ru = new System.Windows.Forms.TextBox();
            this.en = new System.Windows.Forms.TextBox();
            this.add_in = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.ru_name);
            this.panel1.Controls.Add(this.en_name);
            this.panel1.Controls.Add(this.ru);
            this.panel1.Controls.Add(this.en);
            this.panel1.Controls.Add(this.add_in);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 147);
            this.panel1.TabIndex = 0;
            // 
            // ru_name
            // 
            this.ru_name.AutoSize = true;
            this.ru_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ru_name.Location = new System.Drawing.Point(266, 17);
            this.ru_name.Name = "ru_name";
            this.ru_name.Size = new System.Drawing.Size(111, 32);
            this.ru_name.TabIndex = 4;
            this.ru_name.Text = "Перевод";
            // 
            // en_name
            // 
            this.en_name.AutoSize = true;
            this.en_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.en_name.Location = new System.Drawing.Point(12, 17);
            this.en_name.Name = "en_name";
            this.en_name.Size = new System.Drawing.Size(83, 32);
            this.en_name.TabIndex = 3;
            this.en_name.Text = "Слово";
            // 
            // ru
            // 
            this.ru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ru.Location = new System.Drawing.Point(266, 52);
            this.ru.Name = "ru";
            this.ru.Size = new System.Drawing.Size(150, 39);
            this.ru.TabIndex = 2;
            // 
            // en
            // 
            this.en.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.en.Location = new System.Drawing.Point(12, 52);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(150, 39);
            this.en.TabIndex = 1;
            // 
            // add_in
            // 
            this.add_in.Location = new System.Drawing.Point(385, 101);
            this.add_in.Name = "add_in";
            this.add_in.Size = new System.Drawing.Size(112, 34);
            this.add_in.TabIndex = 0;
            this.add_in.Text = "Добавить";
            this.add_in.UseVisualStyleBackColor = true;
            this.add_in.Click += new System.EventHandler(this.add_in_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.Location = new System.Drawing.Point(12, 106);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(113, 32);
            this.status.TabIndex = 5;
            this.status.Text = "Успешно";
            this.status.Visible = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 147);
            this.Controls.Add(this.panel1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramz_ild";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ru;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.Button add_in;
        private System.Windows.Forms.Label ru_name;
        private System.Windows.Forms.Label en_name;
        private System.Windows.Forms.Label status;
    }
}