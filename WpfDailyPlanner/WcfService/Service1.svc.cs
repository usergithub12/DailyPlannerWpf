using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;

namespace WcfService
{

    public class Service1 : IService1
    {
        public void GetUser(User user)
        {
            using (DailyPlannerDB plannerDB = new DailyPlannerDB())
            {
                plannerDB.Users.Add(user);
                plannerDB.SaveChanges();
            }
        }

        public DailyTaskNotes[] GetTasks()
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            dB.Configuration.ProxyCreationEnabled = false;
            return dB.Tasks.ToArray();
        }

        public void GetTaskToAdd(DailyTaskNotes task)
        {
            using (DailyPlannerDB dailyPlanner = new DailyPlannerDB())
            {
                dailyPlanner.Tasks.Add(task);
                dailyPlanner.SaveChanges();
            }
        }

        public Group[] GetGroups()
        {
            DailyPlannerDB dB = new DailyPlannerDB();

            return dB.Groups.ToArray();

        }

        public DailyTaskNotes[] GetTasksFromGroup(string groupname)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            dB.Configuration.ProxyCreationEnabled = false;
            return dB.Tasks.Where(t => t.Group.Name == groupname).ToArray();
        }

        public Group GetGroupbyName(string groupname)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            return dB.Groups.Where(g => g.Name == groupname).FirstOrDefault();
        }

        public void GetGroupToAdd(Group group)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            if (dB.Groups.FirstOrDefault(q => q.Name == group.Name) == null)
            {
                dB.Groups.Add(group);
                dB.SaveChanges();
            }
        }

        public User GetUserbyName(string login)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            return dB.Users.Where(u => u.Login == login).First();
        }

        public void UpdateUser(User user, string login)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            var temp = dB.Users.SingleOrDefault(u => u.Login == login);
            if (temp != null)
            {
                temp.Login = user.Login;
                temp.Password = user.Password;
                temp.Email = user.Email;
                temp.Telephone = user.Telephone;
                temp.PasswordConfirmation = user.PasswordConfirmation;
                dB.SaveChanges();
            }
        }

        public DailyTaskNotes[] GetTasksByDate(DateTime date)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            dB.Configuration.ProxyCreationEnabled = false;
            List<DailyTaskNotes> temp = new List<DailyTaskNotes>();
            foreach (var item in dB.Tasks.Include(c => c.Group))
            {
                if (DateTime.Parse(item.StartDate.ToShortDateString()) == date)
                {
                    temp.Add(item);
                }
            }
            return temp.ToArray();
        }

        public void DeleteTaskByName(string taskname)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            DailyTaskNotes dailyTask = dB.Tasks.Where(t => t.Name == taskname).FirstOrDefault();
            dB.Tasks.Remove(dailyTask);
            dailyTask.IsDeleted = true;

            dB.SaveChanges();
        }

        public void DeleteGroupByName(string groupname)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            Group group = dB.Groups.Where(t => t.Name == groupname).FirstOrDefault();
            group.IsDeleted = true;
            foreach (var item in dB.Tasks.Where(q => q.Group.Name == groupname))
            {
                item.IsDeleted = true;
            }
            dB.SaveChanges();
        }


        public void UpdateTask(DailyTaskNotes task, string taskname)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            var temp = dB.Tasks.Where(u => u.Name == taskname).First();
            temp.Name = task.Name;
            temp.Description = task.Description;
            temp.Location = task.Location;
            temp.Group = task.Group;
            temp.StartDate = task.StartDate;
            temp.EndDate = task.EndDate;
            dB.SaveChanges();
        }

        public DailyTaskNotes GetTaskByName(string taskname)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            dB.Configuration.ProxyCreationEnabled = false;
            return dB.Tasks.FirstOrDefault(g => g.Name == taskname);
        }
    }
}
