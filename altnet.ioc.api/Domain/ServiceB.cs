namespace altnet.ioc.api.Domain
{
    public class ServiceB
    {
        private INumberGenerator _num;

        public ServiceB(INumberGenerator num)
        {
            _num = num;
        }

        public int GetValueB()
        {
            return _num.Get();
        }
    }
}
