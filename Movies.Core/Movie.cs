namespace Movies.Core
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Genre Genre { get; set; }
    }
}
