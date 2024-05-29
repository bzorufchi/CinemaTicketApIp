namespace CinemaTicket.Entities
{
    public class ShoppingBagEntities
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public ShoppingBagStatusEntities shoppingBagStatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public ICollection<OnlineEntities> Onlines { get; set; }
        public ICollection<UsercreaditEntities> Usercreadits { get; set; }
    }
}
