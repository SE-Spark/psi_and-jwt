
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Authentication.DAL.Entities;
using Authentication.DAL.Repository;
using Authentication.DAL.Interfaces;
using System.Threading.Tasks;

namespace Authentication.BAL.Logics
{
    public class LoginLogic
    {
        private ILogin _ILogin;
        public LoginLogic(LoginRepository loginRepository)
        {
            _ILogin = loginRepository;
        }
        public Task<Response> CreateAccount(Login lg)
        {            
            return  _ILogin.Register(lg);
        }
        //edit
        public Task<Response> EditAccounts(Login lg)
        {
            return _ILogin.Update(lg);
        }
        //get
        public Task<Response> ValidateLogins(Login lg)
        {           
            return _ILogin.Login(lg);
        }
        //delete
        public Task<Response> DeleteAccount(Login lg)
        {
            return _ILogin.Delete(lg);
        }
    }
}
