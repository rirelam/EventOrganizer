using EventOrganizer.MongoDB;
using EventOrganizer.Samples;
using Xunit;

namespace EventOrganizer.MongoDb.Applications;

[Collection(EventOrganizerTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<EventOrganizerMongoDbTestModule>
{

}
