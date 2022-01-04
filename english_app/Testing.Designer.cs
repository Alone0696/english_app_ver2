
namespace english_app
{
    partial class Testing
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
            this.next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(143, 175);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(123, 70);
            this.next.TabIndex = 0;
            this.next.Text = "Даллее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(91, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 39);
            this.textBox1.TabIndex = 1;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counter.Location = new System.Drawing.Point(12, 105);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(27, 32);
            this.counter.TabIndex = 2;
            this.counter.Text = "0";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question.Location = new System.Drawing.Point(143, 49);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(93, 32);
            this.question.TabIndex = 3;
            this.question.Text = "Sample";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 286);
            this.Controls.Add(this.question);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.next);
            this.Name = "Testing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramz_ild";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Testing_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button next;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label counter;
        public System.Windows.Forms.Label question;
    }
}