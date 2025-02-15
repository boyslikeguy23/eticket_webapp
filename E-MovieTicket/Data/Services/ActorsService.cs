using E_MovieTicket.Data.Base;
using eTickets.Models;

namespace E_MovieTicket.Data.Services;

public class ActorsService : EntityBaseRepository<Actor>, IActorsService    
{
    public ActorsService(AppDbContext context) : base(context) { }

}