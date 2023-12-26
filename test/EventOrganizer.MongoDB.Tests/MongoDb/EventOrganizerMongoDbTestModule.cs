using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace EventOrganizer.MongoDB;

[DependsOn(
    typeof(EventOrganizerApplicationTestModule),
    typeof(EventOrganizerMongoDbModule)
)]
public class EventOrganizerMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = EventOrganizerMongoDbFixture.GetRandomConnectionString();
        });
    }
}
