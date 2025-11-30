namespace XmlTest.login
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            id = new TextBox();
            pwd = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // id
            // 
            id.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            id.Location = new Point(30, 48);
            id.Name = "id";
            id.Size = new Size(364, 43);
            id.TabIndex = 0;
            // 
            // pwd
            // 
            pwd.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            pwd.Location = new Point(30, 123);
            pwd.Name = "pwd";
            pwd.Size = new Size(364, 43);
            pwd.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(30, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(364, 58);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 330);
            Controls.Add(btnLogin);
            Controls.Add(pwd);
            Controls.Add(id);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private TextBox pwd;
        private Button btnLogin;
    }
}