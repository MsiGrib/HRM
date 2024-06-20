using HRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Controls_Form
{
    public partial class search_worker_controller : UserControl
    {
        private int id;

        public delegate void click_handler(int id);
        public event click_handler on_click = null;

        public search_worker_controller()
        {
            InitializeComponent();
        }
        public void set_data(string name, string grade, int value)
        { 
            name_lable.Text = name;
            email_lable.Text = grade;
            id = value;
        }

        private void search_worker_controller_Click(object sender, EventArgs e)
        {
            on_click?.Invoke(id);
        }

        private void name_lable_Click(object sender, EventArgs e)
        {
            on_click?.Invoke(id);
        }

        private void email_lable_Click(object sender, EventArgs e)
        {
            on_click?.Invoke(id);
        }
    }
}
