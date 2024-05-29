namespace CinemaTicket.Entities
{
    public class MovieEntities
    {
        public int Id { get; set; }
        public GenreEntities GenreId { get; set; }
        public AgeGroupEntities AgeGroupId { get; set; }
        public MovieStatusEntities StatusId { get; set; }
        public CategoryEntities CategoryId { get; set; }
        public string CinemaName { get; set; }
        public string MainPhoto { get; set; }
        public string Description { get; set; }
        // Director
        public string Teaser { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<ActorEntities> Actors { get; set; }
        public ICollection<CinemaMovieEntities> CinemaMovies { get; set; }
        public ICollection<ActorMovieEntities> ActorMovies { get; set; }
        public ICollection<CommentsMovieEntities> CommentsMovies { get; set; }
        public ICollection<MovieDetailEntities> MovieDetails { get; set; }
        public ICollection<MoviePhotosLocationsEntities> MoviePhotosLocations { get; set; }
        public ICollection<SansEntities> Sanses { get; set; }
    }
}
