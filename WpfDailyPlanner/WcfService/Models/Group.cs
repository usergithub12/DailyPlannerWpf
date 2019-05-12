using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    [KnownType(typeof(DailyTaskNotes))]
    public class Group
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
        [DataMember]
        public virtual IEnumerable<DailyTaskNotes> Tasks { get; set; }
    }
}