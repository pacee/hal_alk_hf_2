using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hal_alk_hf_2
{
    public partial class Form1 : Form
    {
        private Validator validator;
       
        public Form1(){
            InitializeComponent();
            startSettings();

        }

        private void startSettings(){
            try{ 
                txtPassword.PasswordChar = '*';
                txtPassword.MaxLength = 8;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MinimizeBox = false;
                this.MaximizeBox = false;
                this.validator = new Validator();
                txtPassword.KeyDown += new KeyEventHandler(textboxKeyDown);
                txtUserName.KeyDown += new KeyEventHandler(textboxKeyDown);
            }catch(Exception exc){
                UserInfo.errorMessage(exc.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e){
            loginProcess();
        }
        private void textboxKeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter){
                loginProcess();
            }
        }

        private void loginProcess(){
            try{
                string userName = txtUserName.Text.ToString();
                string password = txtPassword.Text.ToString();

                User user = new User(userName, password);

                bool inputOK = InputValidator.inputDataValidator(userName, password);
                if (inputOK){
                    bool result = validator.validateUser(user);
                    if (result){
                        Logger.log(1, userName);
                        this.Close();
                    }else{
                        Logger.log(0, userName);
                        UserInfo.errorMessage("Wrong username os password! Try again!");
                    }
                }else{
                    UserInfo.errorMessage("Username or password is invalid or empty!");
                }
            }catch (Exception exc){
                UserInfo.errorMessage(exc.Message);
            }
        }
    }
}
