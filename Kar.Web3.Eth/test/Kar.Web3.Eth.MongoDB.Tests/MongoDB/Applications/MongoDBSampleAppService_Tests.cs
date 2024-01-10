using Kar.Web3.Eth.MongoDB;
using Kar.Web3.Eth.Samples;
using Xunit;

namespace Kar.Web3.Eth.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<EthMongoDbTestModule>
{

}
