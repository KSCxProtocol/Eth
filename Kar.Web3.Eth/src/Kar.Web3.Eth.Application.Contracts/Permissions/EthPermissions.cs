using Volo.Abp.Reflection;

namespace Kar.Web3.Eth.Permissions;

public class EthPermissions
{
    public const string GroupName = "Eth";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(EthPermissions));
    }
}
