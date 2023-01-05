using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager_System_FIT.UTEHY
{
    public static class Utilities
    {
        public static string FormatDate(string date)
        {
            string[] arr = date.Split('/');
            string dateString = arr[2] + "-" + arr[1] + "-" + arr[0];
            return dateString;
        }
    }
}
