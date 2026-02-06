using System.Reactive.Subjects;

namespace R66.State
{
    public interface IStateService
    {
        public BehaviorSubject<double> Global { get; set; }
    }
}
