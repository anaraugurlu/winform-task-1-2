
namespace winform_task_1_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bakubtn = new System.Windows.Forms.Button();
            this.London = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bakubtn
            // 
            this.Bakubtn.Location = new System.Drawing.Point(644, 238);
            this.Bakubtn.Name = "Bakubtn";
            this.Bakubtn.Size = new System.Drawing.Size(77, 33);
            this.Bakubtn.TabIndex = 0;
            this.Bakubtn.Text = "Baku";
            this.Bakubtn.UseVisualStyleBackColor = true;
            this.Bakubtn.Click += new System.EventHandler(this.Bakubtn_Click);
            // 
            // London
            // 
            this.London.AutoSize = true;
            this.London.Location = new System.Drawing.Point(644, 277);
            this.London.Name = "London";
            this.London.Size = new System.Drawing.Size(77, 33);
            this.London.TabIndex = 1;
            this.London.Text = "London";
            this.London.UseVisualStyleBackColor = true;
            this.London.Click += new System.EventHandler(this.London_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::winform_task_1_2.Properties.Resources.london;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.London);
            this.Controls.Add(this.Bakubtn);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bakubtn;
        private System.Windows.Forms.Button London;
        private System.Windows.Forms.Label label1;
    }
}

