namespace CinemaTicket.Entities
{
    public class UserRoleEntities
    {
        public int Id { get; set; }
        public UserEntities UserId { get; set; }
        public UserRoleNameEntities UserRoleNameId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
