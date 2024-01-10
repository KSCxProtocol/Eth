using Kar.Web3.Eth.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kar.Web3.Eth.Permissions;

public class EthPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EthPermissions.GroupName, L("Permission:Eth"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EthResource>(name);
    }
}
