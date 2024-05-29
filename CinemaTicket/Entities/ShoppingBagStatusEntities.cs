namespace CinemaTicket.Entities
{
    public class ShoppingBagStatusEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<ShoppingBagEntities> ShoppingBags { get; set; }
    }
}
