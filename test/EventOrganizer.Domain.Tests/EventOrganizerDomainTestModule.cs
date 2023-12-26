using Volo.Abp.Modularity;

namespace EventOrganizer;

[DependsOn(
    typeof(EventOrganizerDomainModule),
    typeof(EventOrganizerTestBaseModule)
)]
public class EventOrganizerDomainTestModule : AbpModule
{

}
