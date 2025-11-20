using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class PasswordService
    {
        public PasswordEntity GetStrengthByPass(string password)
        {
            var result = Zxcvbn.Core.EvaluatePassword(password);
            int strength = result.Score;
            PasswordEntity pass = new PasswordEntity();
            pass.Password = password;
            pass.Strength = strength;
            return pass;
        }
    }
}
