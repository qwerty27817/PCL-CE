using PCL.Core.App.Region;

namespace PCL;

/// <summary>
///     本地分支补丁：停用上游 #3673 引入的中国大陆区域限制。
///     保留该类型及其签名，使上游所有调用点保持编译通过，便于后续继续同步上游。
/// </summary>
internal static class RestrictedFeaturePolicy
{
    private static readonly RegionAssessment DisabledAssessment =
        new(RegionClassification.Other, "region-policy-disabled");

    internal static RegionAssessment Assess() => DisabledAssessment;

    internal static bool IsRestricted => false;

    internal static bool Check(string feature, bool showHint = true) => true;

    internal static void ThrowIfRestricted(string feature)
    {
    }
}
