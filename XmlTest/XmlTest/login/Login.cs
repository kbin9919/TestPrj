using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlTest.login
{
    public partial class Login : Form
    {
        LoginDao dao;
        public Login()
        {
            InitializeComponent();
            this.dao = new LoginDao();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputId = id.Text;
            string inputPwd = pwd.Text;

            EmpVo orginEmp = dao.GetEmp(inputId, inputPwd);

            //~~ 로그인 처리
        }
    }
}
