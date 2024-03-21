namespace Mission11_McAvoy.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
