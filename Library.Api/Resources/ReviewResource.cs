namespace Library.Api.Resources
{
    public class ReviewResource
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Reviewer { get; set; }
        public BookResource Book { get; set; }
    }
}
