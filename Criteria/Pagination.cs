namespace Criteria
{
    public class Pagination
    {
        private int offset;
        private int limit;

        public int Offset { get => this.offset; }
        public int Limit { get => this.limit; }

        public Pagination(int offset, int limit)
        {
            this.offset = offset;
            this.limit = limit;
        }
    }
}