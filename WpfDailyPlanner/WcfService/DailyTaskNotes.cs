using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class DailyTaskNotes
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string  Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public string Location { get; set; }
        public virtual Group Group { get; set; }

    }
}