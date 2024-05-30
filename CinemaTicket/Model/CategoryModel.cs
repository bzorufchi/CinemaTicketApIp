namespace CinemaTicket.Model
{
    public class CategoryModel
    {
       public class CategoryInput
        {

            public int Id { get; set; }
        }
        public class CategoryOutput : CategoryInput {
            public string CategoryName { get; set; }
            public DateTime CreateDate { get; set; }
            public int Isactive { get; set; }
            public int ByUserId { get; set; }
        }
    }
}
