using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmoothCameraWindow : EditorWindow
{
    //https://docs.unity3d.com/Manual/UIE-HowTo-CreateEditorWindow.html

    private static SmootherFollowCamera _cam;

    [MenuItem("Window/SmoothCamera")]
    private static void Init()
    {
        GetWindow<SmoothCameraWindow>("Smooth Camera");
    }

    private void OnGUI()
    {
        if(_cam == null)
            DrawLoadButton();
        else
        {
            EditorGUILayout.LabelField($"Loaded camera: {_cam.name}");
            EditorGUILayout.ObjectField("Follow Target: ", _cam.TargetObject, typeof(Transform), allowSceneObjects: true);
        }
    }

    private void DrawLoadButton()
    {
        if (GUI.Button(new Rect(20, 70, 100, 20), "Load Camera"))
        {
            var scene = SceneManager.GetActiveScene();
            var rootObjects = scene.GetRootGameObjects();

            foreach (var rootObject in rootObjects)
            {
                _cam = rootObject.GetComponentInChildren<SmootherFollowCamera>();
                if (_cam != null)
                {
                    break;
                }
            }
        }
    }
}
