using Syncfusion.Blazor.Grids;

namespace Kar.Web3.Eth.BlockExplorer.Pages
{
    public partial class Addresses
    {
        public List<AddressesData> Data { get; set; }       
        public SfGrid<AddressesData> DefaultGrid;

    }
    public class AddressesData
    {
        public string Address { get; set; }
        public string Created { get; set; }
        public string Ended { get; set; }
        public string Transactions { get; set; }
    }
}
