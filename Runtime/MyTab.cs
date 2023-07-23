#if UNITY_EDITOR

using System.Collections;
using UnityEditor;
using UnityEditorInternal;

public class MyTab 
{



    [MenuItem("MyTab/MyAPI")]
    static void Select_MyAPI()
    {
        Selection.activeObject = AssetDatabase.LoadMainAssetAtPath("Assets/MyAPI");
    }

    [MenuItem("MyTab/GameSetting")]
    static void Select_GameSetting()
    {
        Selection.activeObject = AssetDatabase.LoadMainAssetAtPath("Assets/MyAPI/Prefabs/GameSetting.prefab");
    }


}
#endif