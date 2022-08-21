using System.Collections.Generic;

namespace PKHeX.Core;

/// <summary>
/// Exposes what move IDs are in the relearn moves list on encounter.
/// </summary>
public interface IRelearn
{
    /// <summary>
    /// Move IDs are in the relearn moves list on encounter.
    /// </summary>
    IReadOnlyList<int> Relearn { get; }
}
