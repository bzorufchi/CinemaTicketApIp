namespace CinemaTicket.Entities
{
    public class UsercreaditEntities
    {
        public int Id { get; set; }
        public ShoppingBagEntities ShoppingBagId { get; set; }
        public UserEntities UserId { get; set; }
        public OnlineEntities OnlineId { get; set; }
        public UsercreaditTypeEntities TypeId { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
    }
}
