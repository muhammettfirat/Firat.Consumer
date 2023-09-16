namespace Firat.Consumer;

public static class ConsumerDbProperties
{
    public static string DbTablePrefix { get; set; } = "Consumer";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Consumer";
}
