using BusinessEntities;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface ICustomer
    {
        int Login(string pUserId, string pPassword);
        int PartPayment(float pAmount, LoanEntity pLoanCustomer);

        int ForeClose(string pLoanId);
        CustomerHome CustomerHomeDetail(string pCustID);

        IEnumerable<SavingTransactionsEntity> GetSavingsTransaction(string pId, DateTime pFromDate, DateTime pToDate);
        IEnumerable<LoanTransactionsEntity> GetLoanTransaction(string pId, DateTime pFromDate, DateTime pToDate);

        bool CheckAccountBalance(string pAID, out float pBal, out float? pOutstanding);
    }
}
