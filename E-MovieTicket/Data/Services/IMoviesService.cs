using E_MovieTicket.Data.Base;
using E_MovieTicket.Models;
using eTickets.Data.ViewModels;
using eTickets.Models;

namespace E_MovieTicket.Data.Services;

public interface IMoviesService:IEntityBaseRepository<Movie>
{
    Task<Movie> GetMovieByIdAsync(int id);
    Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    Task AddNewMovieAsync(NewMovieVM data);
    Task UpdateMovieAsync(NewMovieVM data);
}