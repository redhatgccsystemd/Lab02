using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    class Company
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Company(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

    }
}
