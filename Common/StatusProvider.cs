using System.Globalization;

namespace Common;

public interface IStatusProvider
{
    string GetStatus();
}

public sealed class StatusProvider : IStatusProvider
{
    public string GetStatus() => DateTime.UtcNow.ToString(CultureInfo.InvariantCulture);
}