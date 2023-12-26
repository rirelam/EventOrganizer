using Volo.Abp.Modularity;

namespace EventOrganizer;

public abstract class EventOrganizerApplicationTestBase<TStartupModule> : EventOrganizerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
