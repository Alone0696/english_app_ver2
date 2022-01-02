
namespace english_app
{
    partial class Main_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.setings_app = new System.Windows.Forms.Button();
            this.Start_app = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.setings_app);
            this.panel1.Controls.Add(this.Start_app);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 399);
            this.panel1.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(35, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(448, 45);
            this.name.TabIndex = 2;
            this.name.Text = "Тренажер запоминания слов";
            // 
            // setings_app
            // 
            this.setings_app.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setings_app.Location = new System.Drawing.Point(174, 243);
            this.setings_app.Name = "setings_app";
            this.setings_app.Size = new System.Drawing.Size(173, 76);
            this.setings_app.TabIndex = 1;
            this.setings_app.Text = "Настройка словаря";
            this.setings_app.UseVisualStyleBackColor = true;
            this.setings_app.Click += new System.EventHandler(this.setings_app_Click);
            // 
            // Start_app
            // 
            this.Start_app.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_app.Location = new System.Drawing.Point(200, 162);
            this.Start_app.Name = "Start_app";
            this.Start_app.Size = new System.Drawing.Size(112, 51);
            this.Start_app.TabIndex = 0;
            this.Start_app.Text = "Начать";
            this.Start_app.UseVisualStyleBackColor = true;
            this.Start_app.Click += new System.EventHandler(this.Start_app_Click);
            // 
            // Main_menu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 399);
            this.Controls.Add(this.panel1);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramz_ild";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button setings_app;
        private System.Windows.Forms.Button Start_app;
    }
}

