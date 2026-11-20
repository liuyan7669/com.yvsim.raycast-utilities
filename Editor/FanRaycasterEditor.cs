using UnityEditor;
using Yvsim.InspectorGroups.Editor;

namespace Yvsim.RaycastUtilities.Editor
{
    /// <summary>使用 Inspector Groups 绘制字段与条件分组。</summary>
    [CustomEditor(typeof(FanRaycaster))]
    [CanEditMultipleObjects]
    public sealed class FanRaycasterEditor : InspectorGroupsEditor<FanRaycaster>
    {
    }
}
