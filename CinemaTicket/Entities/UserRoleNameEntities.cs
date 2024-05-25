namespace CinemaTicket.Entities
{
    public class UserRoleNameEntities
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
