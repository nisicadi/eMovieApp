using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Repository.Interfaces;
using eMovieApp.Service.Interfaces;
using System.Text;

namespace eMovieApp.Service.Services
{
    public class ActorService : BaseService<Actor>, IActorService
    {
        IActorRepository _repository;
        public ActorService(IActorRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public ActorGetVM Get(int id)
        {
            var actor = _repository.Get(id);

            ActorGetVM response = new ActorGetVM()
            {
                ActorId = actor.ActorId,
                Name = actor?.Name,
                Surname = actor?.Surname,
                DateOfBirth = actor?.DateOfBirth,
                Sex = actor?.Sex
            };

            return response;
        }

        public List<ActorGetVM> GetAll()
        {
            var list = _repository.GetAll().OrderBy(x => x.Name).ToList();

            List<ActorGetVM> response = new List<ActorGetVM>();

            foreach (var actor in list)
            {
                response.Add(new ActorGetVM()
                {
                    ActorId = actor.ActorId,
                    Name = actor?.Name,
                    Surname = actor?.Surname,
                    DateOfBirth = actor?.DateOfBirth,
                    Sex = actor?.Sex
                });
            }

            return response;
        }

        public ActorAddVM Add(ActorAddVM actor)
        {
            Actor newActor = new Actor()
            {
                ActorId = 0,
                Name = actor?.Name,
                Surname = actor?.Surname,
                DateOfBirth = actor?.DateOfBirth,
                Sex = actor?.Sex
            };

            _repository.Add(newActor);

            return actor;
        }
    }
}
