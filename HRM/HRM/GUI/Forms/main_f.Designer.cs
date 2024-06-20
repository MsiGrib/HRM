namespace HRM.GUI.Forms
{
    partial class main_f
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_f));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nav_panel = new System.Windows.Forms.Panel();
            this.analytics_btn = new HRM.GUI.Controls.yt_Button();
            this.personal_area_btn = new HRM.GUI.Controls.yt_Button();
            this.select_worker_btn = new HRM.GUI.Controls.yt_Button();
            this.add_worker_btn = new HRM.GUI.Controls.yt_Button();
            this.back_btn = new HRM.GUI.Controls.yt_Button();
            this.settings_btn = new HRM.GUI.Controls.yt_Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.name_admin_label = new System.Windows.Forms.Label();
            this.img_admin_picture = new System.Windows.Forms.PictureBox();
            this.title_bar_panel = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.profile_worker1 = new HRM.GUI.Controls_Form.profile_worker();
            this.all_workers1 = new HRM.GUI.Controls_Form.all_workers();
            this.add_worker1 = new HRM.GUI.Forms.add_worker();
            this.analitik_workers1 = new HRM.GUI.Controls_Form.analitik_workers();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_admin_picture)).BeginInit();
            this.title_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.nav_panel);
            this.panel1.Controls.Add(this.analytics_btn);
            this.panel1.Controls.Add(this.personal_area_btn);
            this.panel1.Controls.Add(this.select_worker_btn);
            this.panel1.Controls.Add(this.add_worker_btn);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.settings_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 551);
            this.panel1.TabIndex = 0;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.nav_panel.Location = new System.Drawing.Point(0, 180);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(11, 53);
            this.nav_panel.TabIndex = 2;
            // 
            // analytics_btn
            // 
            this.analytics_btn.Align = System.Drawing.StringAlignment.Near;
            this.analytics_btn.BackColor = System.Drawing.Color.White;
            this.analytics_btn.ForeColor = System.Drawing.Color.Black;
            this.analytics_btn.Height_img = 32;
            this.analytics_btn.Img = ((System.Drawing.Image)(resources.GetObject("analytics_btn.Img")));
            this.analytics_btn.Location = new System.Drawing.Point(0, 357);
            this.analytics_btn.Name = "analytics_btn";
            this.analytics_btn.Offset_img_x = 170;
            this.analytics_btn.Offset_img_y = 10;
            this.analytics_btn.Offset_text_x = 15;
            this.analytics_btn.Size = new System.Drawing.Size(207, 53);
            this.analytics_btn.TabIndex = 2;
            this.analytics_btn.Text = "Аналитика";
            this.analytics_btn.Width_img = 32;
            this.analytics_btn.Click += new System.EventHandler(this.analytics_btn_Click);
            // 
            // personal_area_btn
            // 
            this.personal_area_btn.Align = System.Drawing.StringAlignment.Near;
            this.personal_area_btn.BackColor = System.Drawing.Color.White;
            this.personal_area_btn.ForeColor = System.Drawing.Color.Black;
            this.personal_area_btn.Height_img = 32;
            this.personal_area_btn.Img = ((System.Drawing.Image)(resources.GetObject("personal_area_btn.Img")));
            this.personal_area_btn.Location = new System.Drawing.Point(0, 298);
            this.personal_area_btn.Name = "personal_area_btn";
            this.personal_area_btn.Offset_img_x = 170;
            this.personal_area_btn.Offset_img_y = 10;
            this.personal_area_btn.Offset_text_x = 15;
            this.personal_area_btn.Size = new System.Drawing.Size(207, 53);
            this.personal_area_btn.TabIndex = 2;
            this.personal_area_btn.Text = "Личный кабинет работников";
            this.personal_area_btn.Width_img = 32;
            this.personal_area_btn.Click += new System.EventHandler(this.personal_area_btn_Click);
            // 
            // select_worker_btn
            // 
            this.select_worker_btn.Align = System.Drawing.StringAlignment.Near;
            this.select_worker_btn.BackColor = System.Drawing.Color.White;
            this.select_worker_btn.ForeColor = System.Drawing.Color.Black;
            this.select_worker_btn.Height_img = 32;
            this.select_worker_btn.Img = ((System.Drawing.Image)(resources.GetObject("select_worker_btn.Img")));
            this.select_worker_btn.Location = new System.Drawing.Point(0, 239);
            this.select_worker_btn.Name = "select_worker_btn";
            this.select_worker_btn.Offset_img_x = 170;
            this.select_worker_btn.Offset_img_y = 10;
            this.select_worker_btn.Offset_text_x = 15;
            this.select_worker_btn.Size = new System.Drawing.Size(207, 53);
            this.select_worker_btn.TabIndex = 2;
            this.select_worker_btn.Text = "Все работники";
            this.select_worker_btn.Width_img = 32;
            this.select_worker_btn.Click += new System.EventHandler(this.select_worker_btn_Click);
            // 
            // add_worker_btn
            // 
            this.add_worker_btn.Align = System.Drawing.StringAlignment.Near;
            this.add_worker_btn.BackColor = System.Drawing.Color.White;
            this.add_worker_btn.ForeColor = System.Drawing.Color.Black;
            this.add_worker_btn.Height_img = 32;
            this.add_worker_btn.Img = ((System.Drawing.Image)(resources.GetObject("add_worker_btn.Img")));
            this.add_worker_btn.Location = new System.Drawing.Point(0, 180);
            this.add_worker_btn.Name = "add_worker_btn";
            this.add_worker_btn.Offset_img_x = 170;
            this.add_worker_btn.Offset_img_y = 10;
            this.add_worker_btn.Offset_text_x = 15;
            this.add_worker_btn.Size = new System.Drawing.Size(207, 53);
            this.add_worker_btn.TabIndex = 2;
            this.add_worker_btn.Text = "Добавить работника";
            this.add_worker_btn.Width_img = 32;
            this.add_worker_btn.Click += new System.EventHandler(this.add_worker_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Align = System.Drawing.StringAlignment.Near;
            this.back_btn.BackColor = System.Drawing.Color.White;
            this.back_btn.ForeColor = System.Drawing.Color.Black;
            this.back_btn.Height_img = 0;
            this.back_btn.Img = null;
            this.back_btn.Location = new System.Drawing.Point(0, 467);
            this.back_btn.Name = "back_btn";
            this.back_btn.Offset_img_x = 0;
            this.back_btn.Offset_img_y = 0;
            this.back_btn.Offset_text_x = 15;
            this.back_btn.Size = new System.Drawing.Size(207, 28);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Выйти";
            this.back_btn.Width_img = 0;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Align = System.Drawing.StringAlignment.Near;
            this.settings_btn.BackColor = System.Drawing.Color.White;
            this.settings_btn.ForeColor = System.Drawing.Color.Black;
            this.settings_btn.Height_img = 32;
            this.settings_btn.Img = ((System.Drawing.Image)(resources.GetObject("settings_btn.Img")));
            this.settings_btn.Location = new System.Drawing.Point(0, 501);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Offset_img_x = 170;
            this.settings_btn.Offset_img_y = 10;
            this.settings_btn.Offset_text_x = 15;
            this.settings_btn.Size = new System.Drawing.Size(207, 47);
            this.settings_btn.TabIndex = 2;
            this.settings_btn.Text = "Настройки";
            this.settings_btn.Width_img = 32;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.name_admin_label);
            this.panel3.Controls.Add(this.img_admin_picture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 179);
            this.panel3.TabIndex = 2;
            // 
            // name_admin_label
            // 
            this.name_admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_admin_label.ForeColor = System.Drawing.Color.Black;
            this.name_admin_label.Location = new System.Drawing.Point(0, 152);
            this.name_admin_label.Name = "name_admin_label";
            this.name_admin_label.Size = new System.Drawing.Size(207, 24);
            this.name_admin_label.TabIndex = 2;
            this.name_admin_label.Text = "Name";
            this.name_admin_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_admin_picture
            // 
            this.img_admin_picture.Location = new System.Drawing.Point(0, 0);
            this.img_admin_picture.Name = "img_admin_picture";
            this.img_admin_picture.Size = new System.Drawing.Size(207, 149);
            this.img_admin_picture.TabIndex = 2;
            this.img_admin_picture.TabStop = false;
            // 
            // title_bar_panel
            // 
            this.title_bar_panel.BackColor = System.Drawing.Color.White;
            this.title_bar_panel.Controls.Add(this.minimize_btn);
            this.title_bar_panel.Controls.Add(this.exit_btn);
            this.title_bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar_panel.Location = new System.Drawing.Point(207, 0);
            this.title_bar_panel.Name = "title_bar_panel";
            this.title_bar_panel.Size = new System.Drawing.Size(829, 29);
            this.title_bar_panel.TabIndex = 1;
            this.title_bar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_panel_MouseDown);
            this.title_bar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_panel_MouseMove);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.White;
            this.minimize_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(118)))));
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize_btn.ForeColor = System.Drawing.Color.Black;
            this.minimize_btn.Location = new System.Drawing.Point(768, -1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(28, 27);
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
            this.exit_btn.Location = new System.Drawing.Point(802, -1);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(28, 27);
            this.exit_btn.TabIndex = 39;
            this.exit_btn.Text = "X";
            this.exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // profile_worker1
            // 
            this.profile_worker1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.profile_worker1.ForeColor = System.Drawing.Color.Black;
            this.profile_worker1.Location = new System.Drawing.Point(207, 28);
            this.profile_worker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile_worker1.Name = "profile_worker1";
            this.profile_worker1.Size = new System.Drawing.Size(830, 520);
            this.profile_worker1.TabIndex = 4;
            // 
            // all_workers1
            // 
            this.all_workers1.BackColor = System.Drawing.Color.White;
            this.all_workers1.Location = new System.Drawing.Point(207, 28);
            this.all_workers1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.all_workers1.Name = "all_workers1";
            this.all_workers1.Size = new System.Drawing.Size(830, 520);
            this.all_workers1.TabIndex = 3;
            // 
            // add_worker1
            // 
            this.add_worker1.BackColor = System.Drawing.Color.White;
            this.add_worker1.ForeColor = System.Drawing.Color.Black;
            this.add_worker1.Location = new System.Drawing.Point(207, 28);
            this.add_worker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.add_worker1.Name = "add_worker1";
            this.add_worker1.Size = new System.Drawing.Size(830, 520);
            this.add_worker1.TabIndex = 2;
            // 
            // analitik_workers1
            // 
            this.analitik_workers1.Location = new System.Drawing.Point(207, 28);
            this.analitik_workers1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.analitik_workers1.Name = "analitik_workers1";
            this.analitik_workers1.Size = new System.Drawing.Size(830, 520);
            this.analitik_workers1.TabIndex = 5;
            // 
            // main_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 551);
            this.Controls.Add(this.analitik_workers1);
            this.Controls.Add(this.profile_worker1);
            this.Controls.Add(this.all_workers1);
            this.Controls.Add(this.add_worker1);
            this.Controls.Add(this.title_bar_panel);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_f";
            this.Text = "main_f";
            this.Load += new System.EventHandler(this.main_f_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_admin_picture)).EndInit();
            this.title_bar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel title_bar_panel;
        private System.Windows.Forms.PictureBox img_admin_picture;
        public System.Windows.Forms.Button minimize_btn;
        public System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Label name_admin_label;
        public add_worker add_worker1;
        public Controls_Form.all_workers all_workers1;
        public Controls.yt_Button add_worker_btn;
        public Controls.yt_Button analytics_btn;
        public Controls.yt_Button personal_area_btn;
        public Controls.yt_Button select_worker_btn;
        public Controls.yt_Button back_btn;
        public Controls.yt_Button settings_btn;
        public Controls_Form.profile_worker profile_worker1;
        public Controls_Form.analitik_workers analitik_workers1;
    }
}