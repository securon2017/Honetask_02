namespace Library.Api.Resources
{
    public class RatingResource
    {
        public int Id { get; set; }
        public decimal Score { get; set; }
        public BookResource Book { get; set; }
    }
}
