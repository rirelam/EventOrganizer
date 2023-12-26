using EventOrganizer.Samples;
using Xunit;

namespace EventOrganizer.MongoDB.Domains;

[Collection(EventOrganizerTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<EventOrganizerMongoDbTestModule>
{

}
