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
        public void GetTask(Task task)
        {
            throw new NotImplementedException();
        }

        public Task[] GetTasks()
        {
            throw new NotImplementedException();
        }

        public void GetUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
