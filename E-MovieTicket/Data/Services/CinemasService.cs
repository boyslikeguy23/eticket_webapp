using E_MovieTicket.Data.Base;
using E_MovieTicket.Models;

namespace E_MovieTicket.Data.Services;

public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
{
    public CinemasService(AppDbContext context) : base(context){}
}