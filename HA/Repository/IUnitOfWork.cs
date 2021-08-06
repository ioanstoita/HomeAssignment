using HA.Repository.Repositories;
using System.Threading.Tasks;

namespace HA.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();

        IProductsRepository Products { get; set; }
    }
}