using Microsoft.Extensions.DependencyInjection;
using OmniJournal.Core.Models;

namespace OmniJournal.Core;

public class TrackerFactory
{
    public TrackerFactory()
    {

    }
    public void AddTracker<T>(IServiceCollection services, string name) where T : ITracker
    {
        services.AddSingleton<ITracker>(provider => (ITracker)Activator.CreateInstance(typeof(T), name)!);
    }
}
