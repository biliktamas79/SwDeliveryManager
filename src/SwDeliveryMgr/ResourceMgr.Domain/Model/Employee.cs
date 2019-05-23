using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceMgr.Domain.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }
    }
}
