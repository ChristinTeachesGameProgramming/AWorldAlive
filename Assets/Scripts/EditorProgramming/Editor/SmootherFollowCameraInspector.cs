using UnityEditor;

[CustomEditor(typeof(SmootherFollowCamera))]
public class SmootherFollowCameraInspector : Editor
{
    //https://docs.unity3d.com/Manual/GUIScriptingGuide.html
    //https://docs.unity3d.com/2021.2/Documentation/ScriptReference/EditorGUILayout.html
    //https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Editor.html


    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var cam = (SmootherFollowCamera)target;
        if(cam.TargetObject == null)
        {
            EditorGUILayout.HelpBox("Assign a target to follow", MessageType.Error);
        }
    }
}