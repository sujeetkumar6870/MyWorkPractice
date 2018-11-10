using BusinessEntities;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IEmployeeLoan
    {
        IEnumerable<LoanTransactionsEntity> GetLoanTransaction(string pLoanId, DateTime pFromDate, DateTime pToDate);
    }
}
