using Microsoft.Extensions.DependencyInjection;

namespace OmniJournal.Core;

public class TrackerFactory
{
    public TrackerFactory()
    {

    }
    public void AddTracker<T>(IServiceCollection services, string name) where T : Tracker<T>
    {
        services.AddSingleton<ITracker>(provider => (ITracker)Activator.CreateInstance(typeof(T), name)!);
    }
}
