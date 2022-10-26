namespace Observer_Push
{
    public sealed class Subject : ObservableBase
    {
        private ObservableState _state;

        public Subject()
        {
            State = new ObservableState();
            State.Name = "Default Name";
        }

        public override ObservableState State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyObservers(this);
            }
        }
    }
}