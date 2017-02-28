namespace altnet.ioc.api.Domain
{
    public class NumberGenerator : INumberGenerator
    {
        private int count = 1;

        public int Get()
        {
            return count++;
        }
    }
}
