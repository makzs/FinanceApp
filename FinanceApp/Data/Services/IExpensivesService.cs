using FinanceApp.Models;

namespace FinanceApp.Data.Services;

public interface IExpensivesService
{
    Task<IEnumerable<Expense>> GetAll();
    Task Add(Expense expense);
}
