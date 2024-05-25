namespace MyFirstApi.Entities
{
    public class Device
    {
        protected bool IsConnected() => true;

        public void Test()
        {
            var x = IsConnected();
        }


    }
}
