
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
            this.status = new System.Windows.Forms.Label();
            this.ru_name = new System.Windows.Forms.Label();
            this.en_name = new System.Windows.Forms.Label();
            this.ru = new System.Windows.Forms.TextBox();
            this.en = new System.Windows.Forms.TextBox();
            this.add_in = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(3, 90);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(113, 32);
            this.status.TabIndex = 5;
            this.status.Text = "Успешно";
            this.status.Visible = false;
            // 
            // ru_name
            // 
            this.ru_name.AutoSize = true;
            this.ru_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ru_name.ForeColor = System.Drawing.Color.White;
            this.ru_name.Location = new System.Drawing.Point(3, 0);
            this.ru_name.Name = "ru_name";
            this.ru_name.Size = new System.Drawing.Size(111, 32);
            this.ru_name.TabIndex = 4;
            this.ru_name.Text = "Перевод";
            // 
            // en_name
            // 
            this.en_name.AutoSize = true;
            this.en_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.en_name.ForeColor = System.Drawing.Color.White;
            this.en_name.Location = new System.Drawing.Point(3, 0);
            this.en_name.Name = "en_name";
            this.en_name.Size = new System.Drawing.Size(83, 32);
            this.en_name.TabIndex = 3;
            this.en_name.Text = "Слово";
            // 
            // ru
            // 
            this.ru.BackColor = Program.box_color;
            this.ru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ru.ForeColor = System.Drawing.Color.White;
            this.ru.Location = new System.Drawing.Point(3, 48);
            this.ru.Name = "ru";
            this.ru.Size = new System.Drawing.Size(255, 32);
            this.ru.TabIndex = 2;
            // 
            // en
            // 
            this.en.BackColor = Program.box_color;
            this.en.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.en.Dock = System.Windows.Forms.DockStyle.Fill;
            this.en.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.en.ForeColor = System.Drawing.Color.White;
            this.en.Location = new System.Drawing.Point(3, 48);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(255, 32);
            this.en.TabIndex = 1;
            // 
            // add_in
            // 
            this.add_in.BackColor = Program.button_color;
            this.add_in.FlatAppearance.BorderSize = 0;
            this.add_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_in.ForeColor = System.Drawing.Color.White;
            this.add_in.Location = new System.Drawing.Point(3, 93);
            this.add_in.Name = "add_in";
            this.add_in.Size = new System.Drawing.Size(112, 34);
            this.add_in.TabIndex = 0;
            this.add_in.Text = "Добавить";
            this.add_in.UseVisualStyleBackColor = false;
            this.add_in.Click += new System.EventHandler(this.add_in_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.add_in, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ru, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ru_name, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 141);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.status, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.en, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.en_name, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(261, 141);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 147);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Program.main_color;
            this.ClientSize = new System.Drawing.Size(534, 147);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(556, 203);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramz_ild";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ru;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.Button add_in;
        private System.Windows.Forms.Label ru_name;
        private System.Windows.Forms.Label en_name;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}