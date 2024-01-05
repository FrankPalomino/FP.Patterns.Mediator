namespace FP.Patterns.Mediator.Exercice2
{

    public class Mediator : IMediator
    {
        private List<Device> _devices;

        public Mediator()
        {
            _devices = new List<Device>();
        }
        public void AddDevice(Device device)
        {
            _devices.Add(device);
        }

        public void Send(Device sender, string message)
        {
            foreach (var device in _devices)
            {
                if( device != sender)
                {
                    device.Receive(message);
                }
            }
        }
    }
}
