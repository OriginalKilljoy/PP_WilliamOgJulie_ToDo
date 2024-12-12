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
        public string DoDate;

        public Task(string name, string description, string doDate)
        {
            Name = name;
            Description = description;
            DoDate = doDate;
        }
    }


}
