namespace HRM.GUI.Forms
{
    partial class settings_f
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
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.rjToggleButton1 = new HRM.GUI.Controls.RJToggleButton();
            this.name_admin_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjToggleButton2 = new HRM.GUI.Controls.RJToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.White;
            this.minimize_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(118)))));
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize_btn.ForeColor = System.Drawing.Color.Black;
            this.minimize_btn.Location = new System.Drawing.Point(673, 2);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(6);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(56, 52);
            this.minimize_btn.TabIndex = 67;
            this.minimize_btn.Text = "_";
            this.minimize_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(118)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(741, 2);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(56, 52);
            this.exit_btn.TabIndex = 66;
            this.exit_btn.Text = "X";
            this.exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Checked = true;
            this.rjToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton1.Location = new System.Drawing.Point(214, 90);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjToggleButton1.Size = new System.Drawing.Size(104, 54);
            this.rjToggleButton1.TabIndex = 68;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // name_admin_label
            // 
            this.name_admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_admin_label.ForeColor = System.Drawing.Color.Black;
            this.name_admin_label.Location = new System.Drawing.Point(327, 98);
            this.name_admin_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name_admin_label.Name = "name_admin_label";
            this.name_admin_label.Size = new System.Drawing.Size(71, 46);
            this.name_admin_label.TabIndex = 69;
            this.name_admin_label.Text = "Ru";
            this.name_admin_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 46);
            this.label1.TabIndex = 70;
            this.label1.Text = "Eng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.Checked = true;
            this.rjToggleButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton2.Location = new System.Drawing.Point(214, 217);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjToggleButton2.Size = new System.Drawing.Size(104, 54);
            this.rjToggleButton2.TabIndex = 75;
            this.rjToggleButton2.UseVisualStyleBackColor = true;
            this.rjToggleButton2.CheckedChanged += new System.EventHandler(this.rjToggleButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 46);
            this.label2.TabIndex = 76;
            this.label2.Text = "Светлая";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 46);
            this.label3.TabIndex = 77;
            this.label3.Text = "Тёмная";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 1023);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjToggleButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_admin_label);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings_f";
            this.Text = "settings_f";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settings_f_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settings_f_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button minimize_btn;
        public System.Windows.Forms.Button exit_btn;
        private Controls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Label name_admin_label;
        private System.Windows.Forms.Label label1;
        private Controls.RJToggleButton rjToggleButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}