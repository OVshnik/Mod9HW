using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    public class MyException : Exception
    {

        public string message
        {
            get { return message; }


            set { message = "The file extension not appropriate required"; }
        }

    }
}
