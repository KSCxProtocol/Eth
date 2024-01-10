using Kar.Web3.Eth.Samples;
using Xunit;

namespace Kar.Web3.Eth.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<EthMongoDbTestModule>
{

}
