using Volo.Abp.Modularity;

namespace EventOrganizer;

/* Inherit from this class for your domain layer tests. */
public abstract class EventOrganizerDomainTestBase<TStartupModule> : EventOrganizerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
