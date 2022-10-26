namespace Observer_PushUpdate
{
    public class Subject : ObservableBase
    {
        private string _state;

        public string State
        {
            get => _state;
            
            set
            {
                _state = value;
                NotifyObservers(_state);
            }
        }

        public Subject()
        {
            State = "Default State"; // not notifying observers because they don't exist here
        }
    }
}