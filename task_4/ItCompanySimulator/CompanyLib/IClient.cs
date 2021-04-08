﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public interface IClient
    {
        ICompany Company { set; }
        void GiveFeedback();
        void PayMoney(int payment);
    }
}
