namespace HRM.GUI.Controls_Form
{
    partial class search_worker_controller
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_lable = new System.Windows.Forms.Label();
            this.email_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lable
            // 
            this.name_lable.AutoSize = true;
            this.name_lable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lable.Location = new System.Drawing.Point(4, 0);
            this.name_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(110, 45);
            this.name_lable.TabIndex = 0;
            this.name_lable.Text = "label1";
            this.name_lable.Click += new System.EventHandler(this.name_lable_Click);
            // 
            // email_lable
            // 
            this.email_lable.AutoSize = true;
            this.email_lable.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_lable.Location = new System.Drawing.Point(4, 40);
            this.email_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_lable.Name = "email_lable";
            this.email_lable.Size = new System.Drawing.Size(96, 37);
            this.email_lable.TabIndex = 1;
            this.email_lable.Text = "label1";
            this.email_lable.Click += new System.EventHandler(this.email_lable_Click);
            // 
            // search_worker_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.email_lable);
            this.Controls.Add(this.name_lable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "search_worker_controller";
            this.Size = new System.Drawing.Size(636, 85);
            this.Click += new System.EventHandler(this.search_worker_controller_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label email_lable;
    }
}
