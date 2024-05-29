namespace CinemaTicket.Entities
{
    public class OnlineEntities
    {
        public int Id { get; set; }
        public UserEntities UserId { get; set; }
        public ShoppingBagEntities ShoppingBagId { get; set; }
        public decimal TransAmount { get; set; }
        public int OrderNo { get; set; }
        public int TransNo { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public ICollection<UsercreaditEntities> Usercreadits { get; set; }
    }
}
