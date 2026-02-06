using System.Reactive.Subjects;

namespace R66.State
{
    public class MockStateService : IStateService
    {
        public BehaviorSubject<double> Global { get; set; } = new(100);
    }
}
