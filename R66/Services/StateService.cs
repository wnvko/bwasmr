using System.Reactive.Subjects;

namespace R66.State
{
    public class StateService: IStateService
    {
        public BehaviorSubject<double> Global { get; set; } = new(100);
    }
}
