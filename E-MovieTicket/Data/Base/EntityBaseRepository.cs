namespace E_MovieTicket.Data.Base;

public class EntityBaseRepository<T>: IEntityBaseRepository<T> where T : class, IEntityBase, new()
{
    private readonly AppDbContext _context;
    
}