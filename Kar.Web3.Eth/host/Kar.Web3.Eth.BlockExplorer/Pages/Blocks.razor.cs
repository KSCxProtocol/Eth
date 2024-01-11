namespace Kar.Web3.Eth.BlockExplorer.Pages
{
    public partial class Blocks
    {
        public List<BlocksData> Data { get; set; }
    }
    public class BlocksData
    {
        public int Index { get; set; }
        public int Transactions { get; set; }
        public DateTime DateTime { get; set; }
        public int Size { get; set; }
    }
}
