namespace Xtrf.Api.Browser.Data
{
    public class Pagination
    {
        public int rowsCount { get; set; }
        public int unfilteredRowsCount { get; set; }
        public int currentPage { get; set; }
        public int pagesCount { get; set; }
        public PaginationLinks links { get; set; }
    }
}
