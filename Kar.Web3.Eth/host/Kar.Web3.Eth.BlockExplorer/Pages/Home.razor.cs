namespace Kar.Web3.Eth.BlockExplorer.Pages
{
    public partial class Home
    {
        public List<DataModal> Data { get; set; }
    }
    public class DataModal
    {
        public int Index { get; set; }
        public int Transactions { get; set; }
        public DateTime DateTime { get; set; }
        public int Size { get; set; }
    }
}
