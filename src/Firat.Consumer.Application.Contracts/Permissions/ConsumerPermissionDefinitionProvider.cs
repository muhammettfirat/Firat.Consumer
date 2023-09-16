using Firat.Consumer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Firat.Consumer.Permissions;

public class ConsumerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ConsumerPermissions.GroupName, L("Permission:Consumer"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ConsumerResource>(name);
    }
}
