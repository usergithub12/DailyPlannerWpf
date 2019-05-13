using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;
using System.Text.RegularExpressions;
using WcfService.Exceptions;
using WcfService.ExceptionsFault;
using System.Net.Mail;

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
                task.Group = dailyPlanner.Groups.SingleOrDefault(g => g.Id == task.Group.Id) ?? new Group { Name = task.Group.Name };
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
            return dB.Users.Where(u => u.Login == login).FirstOrDefault();
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


        public void UpdateTask(DailyTaskNotes task)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            var temp = dB.Tasks.SingleOrDefault(u => u.Id == task.Id);
            temp.Name = task.Name;
            temp.Description = task.Description;
            temp.Location = task.Location;

            temp.Group = dB.Groups.SingleOrDefault(g=>g.Id==task.Group.Id)?? new Group { Name =task.Name };

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

        public void GetUserforValidation(User user)
        {
            try
            {
                if (user.Login == String.Empty || user.Login == null || Regex.IsMatch(user.Login, @"\p{IsCyrillic}"))
                {
                    throw new EmptyCyrilicLoginException();
                }
            }
            catch (EmptyCyrilicLoginException err)
            {
                EmptyCyrilicLoginExceptionFault ex = new EmptyCyrilicLoginExceptionFault();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<EmptyCyrilicLoginExceptionFault>(ex, new FaultReason(" field empty or has cyrilyc characters"));
            }

            try
            {

                if (user.Password != user.PasswordConfirmation)
                {
                    throw new PasswordConfirmationException();
                }
            }
            catch (PasswordConfirmationException err)
            {
                PasswordConfirmationExceptionFault ex = new PasswordConfirmationExceptionFault();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<PasswordConfirmationExceptionFault>(ex, new FaultReason(" pass!=pass conf"));
            }

            try
            {
                if (user.Password.Length >= 6)
                {
                    throw new PasswordIndexOutOfRangeException();
                }
            }
            catch (PasswordIndexOutOfRangeException err)
            {
                PasswordIndexOutOfRangeExceptionFault ex = new PasswordIndexOutOfRangeExceptionFault();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<PasswordIndexOutOfRangeExceptionFault>(ex, new FaultReason(" over 6 characters in pass"));
            }

            try
            {
                if (Regex.IsMatch(user.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                {
                    throw new PasswordSpecificCharactersException();
                }
            }
            catch (PasswordSpecificCharactersException err)
            {
                PasswordSpecificCharactersExceptionFault ex = new PasswordSpecificCharactersExceptionFault();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<PasswordSpecificCharactersExceptionFault>(ex, new FaultReason(" specific characters in pass"));
            }

            try
            {
                if (user.Email == null || String.IsNullOrEmpty(user.Email))
                {
                    MailAddress m = new MailAddress(user.Email);
                    throw new EmailFormatException();
                }
            }
            catch (EmailFormatException err)
            {
                EmailFormatExceptionFault ex = new EmailFormatExceptionFault();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<EmailFormatExceptionFault>(ex, new FaultReason(" wrond email format"));
            }

            try
            {
                if (String.IsNullOrEmpty(user.Telephone))
                {
                    var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
                    r.IsMatch(user.Telephone);
                    throw new PhoneFormatException();
                }

            }
            catch (PhoneFormatException err)
            {
                PhoneFormatExceptionFault ex = new PhoneFormatExceptionFault();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<PhoneFormatExceptionFault>(ex, new FaultReason(" wrong phone format"));
            }

        }


        public void GetLoginUserforValidation(string login, string password)
        {
            using (DailyPlannerDB dB = new DailyPlannerDB())
            {
                try
                {
                    var t = dB.Users.FirstOrDefault(u => u.Login == login);
                    if (t == null)
                    {
                        throw new UserExistsInDatabaseException();
                    }
                }
                catch (UserExistsInDatabaseException err)
                {
                    MyExceptionFault ex = new MyExceptionFault();
                    ex.Result = false;
                    ex.Message = err.Message;
                    ex.Description = "Htos' naplyguv, ajajaj ((((";
                    throw new FaultException<MyExceptionFault>(ex, new FaultReason(" user not exists in database"));
                }

                try
                {
                    foreach (var item in dB.Users)
                    {
                        if (item.Password == password)
                        {
                            throw new PasswordEqualsInDataBaseException();
                        }
                    }
                }
                catch (PasswordEqualsInDataBaseException err)
                {

                    PasswordEqualsInDataBaseExceptionFault ex = new PasswordEqualsInDataBaseExceptionFault();
                    ex.Result = false;
                    ex.Message = err.Message;
                    ex.Description = "Htos' naplyguv, ajajaj ((((";
                    throw new FaultException<PasswordEqualsInDataBaseExceptionFault>(ex, new FaultReason(" passwords not equals"));
                }

            }


        }

        public DailyTaskNotes GetDailyTaskById(DailyTaskNotes taskNotes)
        {
            DailyPlannerDB dB = new DailyPlannerDB();
            return dB.Tasks.SingleOrDefault(f=>f.Id==taskNotes.Id);
        }
    }
}
