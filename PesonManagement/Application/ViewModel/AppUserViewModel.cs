﻿using System;
using System.Collections.Generic;

namespace PesonManagement.Application.ViewModel
{
    using PesonManagement.Utils;

    public class AppUserViewModel
    {
        public AppUserViewModel()
        {
            Roles = new List<string>();
        }

        public Guid Id { set; get; }
        public string FullName { set; get; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string UserName { set; get; }
        public string Address { get; set; }
        public string PhoneNumber { set; get; }
        public string Avatar { get; set; }
        public Status Status { get; set; }
        public string Gender { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDelete { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}