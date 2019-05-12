using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.ExceptionsFault;

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
        [OperationContract]
        void UpdateTask(DailyTaskNotes task, string taskname);
        [OperationContract]
        DailyTaskNotes GetTaskByName(string taskname);

        [OperationContract]
        [FaultContract(typeof(EmailFormatExceptionFault))]
        [FaultContract(typeof(EmptyCyrilicLoginExceptionFault))]
        [FaultContract(typeof(PasswordConfirmationExceptionFault))]
        [FaultContract(typeof(PasswordIndexOutOfRangeExceptionFault))]
        [FaultContract(typeof(PasswordSpecificCharactersExceptionFault))]
        [FaultContract(typeof(PhoneFormatExceptionFault))]
        void GetUserforValidation(User user);


        [OperationContract]
        [FaultContract(typeof(MyExceptionFault))]
        [FaultContract(typeof(PasswordEqualsInDataBaseExceptionFault))]
        void GetLoginUserforValidation(string login, string password);

    }


    
}
