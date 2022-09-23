using UnityEditor;

[CustomEditor(typeof(FollowCameraAnimationCurve))]
public class FollowCameraAnimationCurveInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var cam = (FollowCameraAnimationCurve)target;

        if(cam.Player == null)
        {
            EditorGUILayout.HelpBox("Assign a target!", MessageType.Error);
        }
    }
}