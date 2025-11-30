using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlTest.utill;

namespace XmlTest.login
{
    public class LoginMapper : XmlMapper
    {
        public LoginMapper(string xmlPath) : base(xmlPath) { }

        public string GetEmp()
        {
            return GetQuery("GetEmp");
        }
    }
}
