namespace FP.Patterns.Mediator.Exercice3
{
    public class ControlTower : IMediator
    {
        private List<Component> _components = [];
        public void Register(Component component)
        {
            _components.Add(component);
            component.SetMediator(this);
        }

        public void SendMessage(Component sender, string message)
        {
            foreach (var component in _components)
            {
                if (component != sender)
                {
                    component.ReceiveMessage(message);
                }
            }
        }
    }
}
