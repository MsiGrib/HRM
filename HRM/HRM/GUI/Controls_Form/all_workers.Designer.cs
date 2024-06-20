namespace HRM.GUI.Controls_Form
{
    partial class all_workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(all_workers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.month_combobox = new HRM.GUI.Controls.rj_combobox();
            this.parameter_combobox = new HRM.GUI.Controls.rj_combobox();
            this.rj_button2 = new HRM.GUI.Controls.rj_button();
            this.rj_button1 = new HRM.GUI.Controls.rj_button();
            this.all_works_btn = new HRM.GUI.Controls.rj_button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table_combobox = new HRM.GUI.Controls.rj_combobox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table_combobox);
            this.panel1.Controls.Add(this.month_combobox);
            this.panel1.Controls.Add(this.parameter_combobox);
            this.panel1.Controls.Add(this.rj_button2);
            this.panel1.Controls.Add(this.rj_button1);
            this.panel1.Controls.Add(this.all_works_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1660, 127);
            this.panel1.TabIndex = 0;
            // 
            // month_combobox
            // 
            this.month_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.month_combobox.Border_radius = 0;
            this.month_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.month_combobox.BorderSize = 2;
            this.month_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_combobox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month_combobox.ForeColor = System.Drawing.Color.Black;
            this.month_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.month_combobox.Items.AddRange(new object[] {
            "qwe",
            "asd",
            "zxc",
            "rty",
            "vnb"});
            this.month_combobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.month_combobox.ListTextColor = System.Drawing.Color.Black;
            this.month_combobox.Location = new System.Drawing.Point(1238, 23);
            this.month_combobox.Margin = new System.Windows.Forms.Padding(6);
            this.month_combobox.MinimumSize = new System.Drawing.Size(200, 58);
            this.month_combobox.Name = "month_combobox";
            this.month_combobox.Padding = new System.Windows.Forms.Padding(4);
            this.month_combobox.Size = new System.Drawing.Size(408, 75);
            this.month_combobox.TabIndex = 5;
            this.month_combobox.Texts = "";
            // 
            // parameter_combobox
            // 
            this.parameter_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.parameter_combobox.Border_radius = 0;
            this.parameter_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.parameter_combobox.BorderSize = 2;
            this.parameter_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parameter_combobox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parameter_combobox.ForeColor = System.Drawing.Color.Black;
            this.parameter_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.parameter_combobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.parameter_combobox.ListTextColor = System.Drawing.Color.Black;
            this.parameter_combobox.Location = new System.Drawing.Point(818, 23);
            this.parameter_combobox.Margin = new System.Windows.Forms.Padding(6);
            this.parameter_combobox.MinimumSize = new System.Drawing.Size(200, 58);
            this.parameter_combobox.Name = "parameter_combobox";
            this.parameter_combobox.Padding = new System.Windows.Forms.Padding(4);
            this.parameter_combobox.Size = new System.Drawing.Size(408, 75);
            this.parameter_combobox.TabIndex = 4;
            this.parameter_combobox.Texts = "";
            // 
            // rj_button2
            // 
            this.rj_button2.BackColor = System.Drawing.Color.White;
            this.rj_button2.Background_color = System.Drawing.Color.White;
            this.rj_button2.Border_color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.rj_button2.Border_radius = 26;
            this.rj_button2.Border_size = 1;
            this.rj_button2.FlatAppearance.BorderSize = 0;
            this.rj_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rj_button2.Fore_color = System.Drawing.Color.Black;
            this.rj_button2.ForeColor = System.Drawing.Color.Black;
            this.rj_button2.Location = new System.Drawing.Point(162, 6);
            this.rj_button2.Margin = new System.Windows.Forms.Padding(6);
            this.rj_button2.Name = "rj_button2";
            this.rj_button2.Size = new System.Drawing.Size(224, 50);
            this.rj_button2.TabIndex = 2;
            this.rj_button2.Text = "По возрастанию";
            this.rj_button2.UseVisualStyleBackColor = false;
            this.rj_button2.Click += new System.EventHandler(this.rj_button2_Click);
            // 
            // rj_button1
            // 
            this.rj_button1.BackColor = System.Drawing.Color.White;
            this.rj_button1.Background_color = System.Drawing.Color.White;
            this.rj_button1.Border_color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.rj_button1.Border_radius = 26;
            this.rj_button1.Border_size = 1;
            this.rj_button1.FlatAppearance.BorderSize = 0;
            this.rj_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rj_button1.Fore_color = System.Drawing.Color.Black;
            this.rj_button1.ForeColor = System.Drawing.Color.Black;
            this.rj_button1.Location = new System.Drawing.Point(162, 67);
            this.rj_button1.Margin = new System.Windows.Forms.Padding(6);
            this.rj_button1.Name = "rj_button1";
            this.rj_button1.Size = new System.Drawing.Size(224, 50);
            this.rj_button1.TabIndex = 1;
            this.rj_button1.Text = "По убыванию";
            this.rj_button1.UseVisualStyleBackColor = false;
            this.rj_button1.Click += new System.EventHandler(this.rj_button1_Click);
            // 
            // all_works_btn
            // 
            this.all_works_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.all_works_btn.Background_color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.all_works_btn.Border_color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(72)))), ((int)(((byte)(150)))));
            this.all_works_btn.Border_radius = 40;
            this.all_works_btn.Border_size = 0;
            this.all_works_btn.FlatAppearance.BorderSize = 0;
            this.all_works_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_works_btn.Fore_color = System.Drawing.Color.White;
            this.all_works_btn.ForeColor = System.Drawing.Color.White;
            this.all_works_btn.Image = ((System.Drawing.Image)(resources.GetObject("all_works_btn.Image")));
            this.all_works_btn.Location = new System.Drawing.Point(0, 0);
            this.all_works_btn.Margin = new System.Windows.Forms.Padding(6);
            this.all_works_btn.Name = "all_works_btn";
            this.all_works_btn.Size = new System.Drawing.Size(150, 119);
            this.all_works_btn.TabIndex = 0;
            this.all_works_btn.UseVisualStyleBackColor = false;
            this.all_works_btn.Click += new System.EventHandler(this.all_works_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1660, 879);
            this.dataGridView1.TabIndex = 1;
            // 
            // table_combobox
            // 
            this.table_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.table_combobox.Border_radius = 0;
            this.table_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.table_combobox.BorderSize = 2;
            this.table_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table_combobox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_combobox.ForeColor = System.Drawing.Color.Black;
            this.table_combobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.table_combobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.table_combobox.ListTextColor = System.Drawing.Color.Black;
            this.table_combobox.Location = new System.Drawing.Point(398, 23);
            this.table_combobox.Margin = new System.Windows.Forms.Padding(6);
            this.table_combobox.MinimumSize = new System.Drawing.Size(200, 58);
            this.table_combobox.Name = "table_combobox";
            this.table_combobox.Padding = new System.Windows.Forms.Padding(4);
            this.table_combobox.Size = new System.Drawing.Size(408, 75);
            this.table_combobox.TabIndex = 6;
            this.table_combobox.Texts = "";
            this.table_combobox.OnSelectedIndexChanged += new System.EventHandler(this.table_combobox_OnSelectedIndexChanged_1);
            // 
            // all_workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "all_workers";
            this.Size = new System.Drawing.Size(1660, 1000);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.rj_button all_works_btn;
        private Controls.rj_button rj_button2;
        private Controls.rj_button rj_button1;
        private Controls.rj_combobox parameter_combobox;
        private Controls.rj_combobox month_combobox;
        private Controls.rj_combobox table_combobox;
    }
}
