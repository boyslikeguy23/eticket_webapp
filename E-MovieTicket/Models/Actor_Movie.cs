using eTickets.Models;

namespace E_MovieTicket.Models;

public class Actor_Movie
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int ActorId { get; set; }
    public Actor Actor { get; set; }

}