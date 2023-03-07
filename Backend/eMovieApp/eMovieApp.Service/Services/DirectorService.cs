using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Repository.Interfaces;
using eMovieApp.Service.Interfaces;
using System.IO;

namespace eMovieApp.Service.Services
{
    public class DirectorService : BaseService<Director>, IDirectorService
    {
        IDirectorRepository _repository;
        public DirectorService(IDirectorRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public DirectorGetVM Get(int id)
        {
            var director = _repository.Get(id);

            DirectorGetVM response = new DirectorGetVM()
            {
                DirectorId = director.DirectorId,
                Name = director?.Name,
                Surname = director?.Surname,
                DateOfBirth = director?.DateOfBirth,
                Sex = director?.Sex
            };

            return response;
        }

        public List<DirectorGetVM> GetAll()
        {
            var list = _repository.GetAll().OrderBy(x => x.Name).ToList();

            List<DirectorGetVM> response = new List<DirectorGetVM>();

            foreach (var director in list)
            {
                response.Add(new DirectorGetVM()
                {
                    DirectorId = director.DirectorId,
                    Name = director?.Name,
                    Surname = director?.Surname,
                    DateOfBirth = director?.DateOfBirth,
                    Sex = director?.Sex
                });
            }

            return response;
        }

        public DirectorAddVM Add(DirectorAddVM director)
        {
            Director newDirector = new Director()
            {
                DirectorId = 0,
                Name = director?.Name,
                Surname = director?.Surname,
                DateOfBirth = director?.DateOfBirth,
                Sex = director?.Sex
            };

            _repository.Add(newDirector);

            return director;
        }
    }
}
