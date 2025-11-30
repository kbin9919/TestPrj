using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlTest.utill;

namespace XmlTest.login
{
    public class LoginDao
    {
        LoginMapper mapper;
        SqlTemplate sqlTemplate;

        public LoginDao() 
        {
            this.mapper = new LoginMapper("");
            this.sqlTemplate = new SqlTemplate();
        }

        public EmpVo GetEmp(string id, string pwd)
        {
            try
            {
                string query = mapper.GetEmp();
                DataTable emp = sqlTemplate.Select(query);

                EmpVo vo = new EmpVo();
                vo.id = emp?.Rows[0]["id"].ToString();
                vo.id = emp?.Rows[0]["pwd"].ToString();

                return vo;
            }
            catch (Exception ex)
            {
                // 로그
                return null;
            }
        }
    }
}
