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
        public string DoDate;
        public bool Done = false;

        public Task(string name, string doDate, bool done)
        {
            Name = name;
            DoDate = doDate;
            Done = done;
        }
    }


}
