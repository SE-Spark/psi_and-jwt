using Authentication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.DAL.Interfaces
{
    public interface ILogin
    {
        Task<Response> Register(Login lg);
        Task<Response> Login(Login lg);
        Task<Response> Update(Login lg);
        Task<Response> Delete(Login lg);

    }
}
