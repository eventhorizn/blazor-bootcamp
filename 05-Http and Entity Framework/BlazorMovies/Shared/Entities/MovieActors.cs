namespace BlazorMovies.Shared.Entities
{
    public class MovieActors
    {
        public int PersionId { get; set; }
        public int MovieId { get; set; }
        public Person Person { get; set; }
        public Movie Movie { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}
