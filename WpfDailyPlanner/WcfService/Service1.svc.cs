﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
            dB.Groups.Add(group);
            dB.SaveChanges();
        }

        public User GetUserbyName(string login)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            return dB.Users.Where(u => u.Login == login).First();
        }

        public void UpdateUser(User user,string login)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            var temp = dB.Users.Where(u => u.Login == login).First();
            temp.Login = user.Login;
            temp.Password = user.Password;
            temp.Email = user.Email;
            temp.Telephone = user.Telephone;
            temp.PasswordConfirmation = user.PasswordConfirmation;
            dB.SaveChanges();
        }
    }
}
