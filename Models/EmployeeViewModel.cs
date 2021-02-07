using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessDemo.Models
{
    public class EmployeeViewModel
    {

        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

    }
}
