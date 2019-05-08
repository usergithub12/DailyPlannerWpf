﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    [KnownType(typeof(Group))]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string PasswordConfirmation { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Telephone { get; set; }
        [DataMember]
        public string PhotoPath { get; set; }

    }
}