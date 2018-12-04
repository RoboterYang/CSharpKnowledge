﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void PrintString(string content);
    public class DelegateClass
    {
        public string m_member1;
        public PrintString PrintStringdele;

        public void PrintAllDel()
        {
            PrintStringdele(m_member1);
            PrintStringdele.GetInvocationList();
        }
    }
}
