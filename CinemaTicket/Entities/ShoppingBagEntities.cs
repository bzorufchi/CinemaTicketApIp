namespace CinemaTicket.Entities
{
    public class ShoppingBagEntities
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public ShoppingBagStatusEntities shoppingBagStatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
    }
}
