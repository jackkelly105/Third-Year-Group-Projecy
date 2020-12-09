﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    interface IMonthlyReport
    {
        int ReportID { get; set; }
        DateTime Date { get; set; }
        int Reservations { get; set; }
        decimal ReservationIncome { get; set; }
        int Sales { get; set; }
        decimal SalesIncome { get; set; }
        decimal StockExpenses { get; set; }
    }
}
