namespace Kar.Web3.Eth;

public static class EthDbProperties
{
    public static string DbTablePrefix { get; set; } = "Eth";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Eth";
}
