    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebRong.ViewModels;

namespace WebRong.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
}