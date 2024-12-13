using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_WilliamOgJulie_ToDo
{
    internal class Task
    {
        public string Name;
        public string Description;
        public string Date;

        public Task(string name, string description, string Date)
        {
            Name = name;
            Description = description;
            Date = Date;
        }
    }


}
