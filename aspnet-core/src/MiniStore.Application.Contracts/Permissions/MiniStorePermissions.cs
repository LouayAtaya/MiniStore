namespace MiniStore.Permissions;

public static class MiniStorePermissions
{
    public const string GroupName = "MiniStore";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Items
    {
        public const string Default = GroupName + ".Items";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
