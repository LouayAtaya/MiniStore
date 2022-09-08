using MiniStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MiniStore.Permissions;

public class MiniStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var miniStoreGroup = context.AddGroup(MiniStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MiniStorePermissions.MyPermission1, L("Permission:MyPermission1"));

        var itemsPermission = miniStoreGroup.AddPermission(MiniStorePermissions.Items.Default, L("Permission:Items"));
        itemsPermission.AddChild(MiniStorePermissions.Items.Create, L("Permission:Items.Create"));
        itemsPermission.AddChild(MiniStorePermissions.Items.Edit, L("Permission:Items.Edit"));
        itemsPermission.AddChild(MiniStorePermissions.Items.Delete, L("Permission:Items.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MiniStoreResource>(name);
    }
}
