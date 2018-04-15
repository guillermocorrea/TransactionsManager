using X.PagedList;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TransactionsManager.Domain;

namespace TransactionsManager.Services.Interfaces
{
    public interface ITransactionsService
    {
        Task Register(Transaction transaction);
        Task<IPagedList<Transaction>> Paginate(int pageNumber, int pageSize);
        Task<Transaction> FindById(int id);
        Task<IPagedList<Transaction>> Find(TransactionsSearchCriteria searchCriteria, int pageNumber, int pageSize);
        Task MarkAsFraud(int id);
    }
}
