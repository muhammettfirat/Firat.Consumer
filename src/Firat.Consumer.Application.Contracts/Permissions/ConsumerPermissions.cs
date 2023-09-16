using Volo.Abp.Reflection;

namespace Firat.Consumer.Permissions;

public class ConsumerPermissions
{
    public const string GroupName = "Consumer";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ConsumerPermissions));
    }
}
