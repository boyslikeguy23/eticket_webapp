using E_MovieTicket.Data.Base;
using E_MovieTicket.Models;

namespace E_MovieTicket.Data.Services;

public class ProducersService : EntityBaseRepository<Producer>, IProducersService
{
    public ProducersService(AppDbContext context) : base(context)
    {
    }
}