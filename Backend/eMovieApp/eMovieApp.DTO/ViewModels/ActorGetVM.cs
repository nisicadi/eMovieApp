namespace eMovieApp.DTO.ViewModels
{
    public class ActorGetVM
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public char? Sex { get; set; }
    }
}
