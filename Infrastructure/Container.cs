using System;

namespace Infrastructure
{
    public class Container
    {
        private Container _instance;

        private Container()
        {

        }

        public Container Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Container();

                return _instance;
            }
        }

        public IWeather
    }
}
