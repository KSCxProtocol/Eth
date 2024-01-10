using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Kar.Web3.Eth.Blazor.Menus;

public class EthMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(EthMenus.Prefix, displayName: "Eth", "/Eth", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
