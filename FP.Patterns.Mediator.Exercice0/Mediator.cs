namespace FP.Patterns.Mediator
{
    public class Mediator : IMediator
    {
        private List<Colleague> _colleagues;

        public Mediator()
        {
            _colleagues = new List<Colleague>();
        }

        public void AddColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void Send(string message, Colleague colleague)
        {
            foreach (var c in _colleagues)
            {
                if (c != colleague)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
