using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Services
{
    public class Logger : IDeveloverLogger
    {

        public bool Log(string message)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogAsync(string message)
        {
            throw new NotImplementedException();
        }
    }
}
