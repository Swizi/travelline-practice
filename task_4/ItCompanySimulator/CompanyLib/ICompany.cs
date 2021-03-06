﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public interface ICompany
    {
        int Salary { get; set; }
        int Budget { get; set; }

        void Advertise(int advertisementBudget);
        void AddParticipant(Employee participant);
        void AddClient(IClient client);
        void SetSalary(int salary);
    }
}
