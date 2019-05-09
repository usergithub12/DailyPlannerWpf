using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
   
        [OperationContract]
        void GetUser(User user);
        [OperationContract]
        void GetTaskToAdd(DailyTaskNotes task);
        [OperationContract]
        DailyTaskNotes[] GetTasks();
        [OperationContract]
        Group[] GetGroups();
        [OperationContract]
        DailyTaskNotes[] GetTasksFromGroup(string groupname);
        [OperationContract]
        Group GetGroupbyName(string groupname);
        [OperationContract]
        void GetGroupToAdd(Group group);
        [OperationContract]
        User GetUserbyName(string login);
        [OperationContract]
        void UpdateUser(User user,string login);
        [OperationContract]
        DailyTaskNotes[] GetTasksByDate(DateTime date);
        [OperationContract]
        void DeleteTaskByName(string taskname);
        [OperationContract]
        void DeleteGroupByName(string groupname);

        //Group GetGroupbyId()
    }


    
}
