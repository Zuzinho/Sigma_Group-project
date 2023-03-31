using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma_Group_project.Models
{
    public class Form
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int? RecoverCode { get; private set; }

        public Form(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }
        public Form(int id, string email, string password, int? recoverCode) : this(id, email, password)
        {
            RecoverCode = recoverCode;
        }
    }
}