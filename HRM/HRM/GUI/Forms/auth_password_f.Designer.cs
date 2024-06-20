namespace HRM.GUI.Forms
{
    partial class auth_password_f
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
            this.label5 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
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
            this.minimize_btn.Location = new System.Drawing.Point(420, -1);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(6);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(56, 52);
            this.minimize_btn.TabIndex = 40;
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
            this.exit_btn.Location = new System.Drawing.Point(488, -1);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(56, 52);
            this.exit_btn.TabIndex = 39;
            this.exit_btn.Text = "X";
            this.exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(189, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 50);
            this.label5.TabIndex = 43;
            this.label5.Text = "Пароль";
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textbox.Location = new System.Drawing.Point(25, 133);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(500, 62);
            this.password_textbox.TabIndex = 41;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(118)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(25, 207);
            this.login_btn.Margin = new System.Windows.Forms.Padding(6);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(500, 94);
            this.login_btn.TabIndex = 44;
            this.login_btn.Text = "Подтвердить";
            this.login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // auth_password_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 323);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "auth_password_f";
            this.Text = "auth_password_f";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.auth_password_f_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.auth_password_f_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button minimize_btn;
        public System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox password_textbox;
        public System.Windows.Forms.Button login_btn;
    }
}