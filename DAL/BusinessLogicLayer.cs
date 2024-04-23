using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class BusinessLogicLayer
    {
        public bool CheckAccount(string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{3,24}$");
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
    }
}
