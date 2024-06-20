using HRM.Auth;
using HRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public class entity_gateway
    {
        private static entity_gateway _instance;
        private entity_gateway() { }
        public static entity_gateway GetInstance()
        {
            if (_instance is null)
                _instance = new entity_gateway();
            return _instance;
        }
        public application_db_context Context { get; set; } = new application_db_context("Data Source=DESKTOP-OK6U4U9;Initial Catalog=ex_ispo;Integrated Security=True;MultipleActiveResultSets=true;");

        public void add_admin(admin ad)
        {
            Context.admins.Add(ad);
            Context.SaveChanges();
        }
        public void add_worker(worker wk)
        {
            Context.workers.Add(wk);
            Context.SaveChanges();
        }

        public void update_worker(worker wk)
        {
            var existingWorker = Context.Set<worker>().Find(wk.Id);

            if (existingWorker != null)
                Context.Entry(existingWorker).CurrentValues.SetValues(wk);
            else
                Context.Set<worker>().Add(wk);
            Context.SaveChanges();
        }
        public void update_bonus(bonus bu)
        {
            var existing_bonus = Context.Set<bonus>().Find(bu.Id);
            if (existing_bonus != null)
                Context.Entry(existing_bonus).CurrentValues.SetValues(bu);
            else
                Context.Set<bonus>().Add(bu);
            Context.SaveChanges();
        }
        public void delety_worker(worker wk)
        {
            Context.workers.Remove(wk);
            Context.SaveChanges();
        }
        public void delety_bonus(bonus bu)
        {
            Context.bonus.Remove(bu);
            Context.SaveChanges();
        }
        public List<admin> get_admins()
        {
            try
            {
                return Context.admins.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(language_pack.get_wait());
                Thread.Sleep(3000);
                return Context.admins.ToList();
            }
            
        }

        public List<worker> get_workers()
        {
            return Context.workers.ToList();
        }

        public List<bonus> get_bonus()
        {
            return Context.bonus.ToList();
        }
    }
}
