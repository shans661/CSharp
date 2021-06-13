namespace DatingApp.Helpers
{
    public class PaginationParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int m_PageSize = 10;

        public int PageSize
        {
            get => m_PageSize;
            set => m_PageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }
}