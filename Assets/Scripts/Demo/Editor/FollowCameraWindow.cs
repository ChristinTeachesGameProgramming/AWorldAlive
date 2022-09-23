using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCameraWindow : EditorWindow
{
    private FollowCameraAnimationCurve _camera;

    [MenuItem("Window/FollowCamera")]
    private static void Init()
    {
        GetWindow<FollowCameraWindow>("Follow Camera");
    }

    private void OnGUI()
    {
        if(_camera == null)
            DrawLoadButton();
        else
        {
            EditorGUILayout.LabelField($"Loaded camera: {_camera.name}");
            _camera.Player = (Transform)EditorGUILayout.ObjectField("Follow Target: ", _camera.Player, typeof(Transform), allowSceneObjects: true);
        }
    }

    private void DrawLoadButton()
    {
        if (GUI.Button(new Rect(20, 70, 100, 20), "Load Camera"))
        {
            var scene = SceneManager.GetActiveScene();
            var gameObjects = scene.GetRootGameObjects();

            foreach (var gameObject in gameObjects)
            {
                _camera = gameObject.GetComponentInChildren<FollowCameraAnimationCurve>();
                if (_camera)
                {
                    break;
                }
            }
        }
    }
}