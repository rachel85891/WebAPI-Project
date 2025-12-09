using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class PasswordService : IPasswordService
    {
        public PasswordService() { }
        public async Task<PasswordEntity> GetStrengthByPass(string password)
        {
            var result = Zxcvbn.Core.EvaluatePassword(password);
            int strength = result.Score;
            PasswordEntity pass = new PasswordEntity();
            pass.password = password;
            pass.strength = strength;
            return await Task.FromResult(pass);
        }
    }
}
