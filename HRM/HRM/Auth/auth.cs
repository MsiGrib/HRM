using HRM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRM.Auth
{
    public class auth
    {
        private static auth _instance;
        private auth() { }
        public static auth GetInstance()
        {
            if(_instance is null)
                _instance = new auth();
            return _instance;
        }

        public admin admin { get; private set; }
        private bool ready = false;

        public bool register(string name, string pass, string pass2, string mail, string img) 
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(pass2) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show(language_pack.get_auth_clear_data(), language_pack.get_error());
                return false;
            }
            if (pass != pass2)
            {
                MessageBox.Show(language_pack.get_auth_no_rep_pas(), language_pack.get_error());
                return false;
            }
            if (!is_ready())
            {
                MessageBox.Show(language_pack.get_auth_no_img(), language_pack.get_error());
                return false;
            }
            admin ad = new admin();
            ad.Id = entity_gateway.GetInstance().get_admins().Count != 0 ? entity_gateway.GetInstance().get_admins().Last().Id + 1 : 0;
            ad.User_Name = name;
            ad.Password = pass;
            ad.Email = mail;
            ad.Img = img;
            entity_gateway.GetInstance().add_admin(ad);
            MessageBox.Show(language_pack.get_auth_register_compl(), language_pack.get_info());
            return true;
        }

        public worker add_worker(string fio, string doc, string otdel, string skill, string sallary, string ex, string obr, string icon)
        {
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(doc) || string.IsNullOrEmpty(otdel) ||
                string.IsNullOrEmpty(skill) || string.IsNullOrEmpty(sallary) || string.IsNullOrEmpty(ex) ||
                string.IsNullOrEmpty(obr) || string.IsNullOrEmpty(icon))
            {
                MessageBox.Show(language_pack.get_auth_all_no_filds(), language_pack.get_error());
                return null;
            }
            worker wk = new worker();
            wk.Id = wk.Id = entity_gateway.GetInstance().get_workers().Count != 0 ? entity_gateway.GetInstance().get_workers().Last().Id + 1 : 0;
            wk.Name = fio;
            wk.Document_info = doc;
            wk.Department = otdel;
            wk.Grade = skill;
            if (!Double.TryParse(sallary.Replace(".", ","), out double tmp_sel))
            {
                MessageBox.Show(language_pack.get_auth_involid_data(), language_pack.get_error());
                return null;
            }
            wk.Salary = tmp_sel;
            if (!Double.TryParse(ex.Replace(".", ","), out double tmp_ex))
            {
                MessageBox.Show(language_pack.get_auth_involid_data(), language_pack.get_error());
                return null;
            }
            wk.Experience = tmp_ex;
            wk.Education = obr;
            wk.Img = $"../../../../Работники/Личный кабинет работника {fio}/icon_{fio}.png";
            entity_gateway.GetInstance().add_worker(wk);
            MessageBox.Show(language_pack.get_auth_add_worker_compl(), language_pack.get_info());
            return wk;
        }

        public bool authoriz(string log, string pas)
        {
            admin = entity_gateway.GetInstance().get_admins().SingleOrDefault(a => a.User_Name == log && a.Password == pas);
            return admin != null;
        }
        public bool auth_password(string pas)
        {
            admin = entity_gateway.GetInstance().get_admins().SingleOrDefault(a => a.Password == pas);
            return admin != null;
        }


        public void set_ready(bool b)
        {
            ready = b;
        }

        private bool is_ready()
        {
            return ready;
        }
    }
}
