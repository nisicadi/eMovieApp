namespace eMovieApp.DTO.ViewModels
{
    public class DirectorGetVM
    {
        public int DirectorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public char? Sex { get; set; }
    }
}
