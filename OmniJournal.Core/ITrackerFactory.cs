namespace OmniJournal.Core;

public interface ITrackerFactory
{
    void AddTracker<T>(IServiceCollection services, string name) where T : Tracker<T>;
}
