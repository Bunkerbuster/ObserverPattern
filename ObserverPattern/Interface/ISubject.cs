
namespace ObserverPattern.Interface
{
    public interface ISubject
    {
        public void Attach(IObserver observer);
        public void Notify();
    }
}
