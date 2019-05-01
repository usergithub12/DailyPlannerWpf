using System;
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

    }
}
