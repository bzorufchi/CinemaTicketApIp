﻿namespace CinemaTicket.Entities
{
    public class GenreEntities
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
