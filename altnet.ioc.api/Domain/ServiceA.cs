namespace altnet.ioc.api.Domain
{
    public class ServiceA
    {
        private INumberGenerator _num;

        public ServiceA(INumberGenerator num)
        {
            _num = num;
        }

        public int GetValueA()
        {
            return _num.Get();
        }
    }
}
