using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public Usuario(int id, string email, string password, IHttpContextAccessor httpContextAccessor)
        {
            this.IdUsuario = id;
            this.Email = email;
            this.Password = password;
            this._httpContextAccessor = httpContextAccessor;
            this._httpContextAccessor = httpContextAccessor;
        }

        public Usuario()
        {

        }


    }
}
