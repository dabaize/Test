using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Editortool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [UnityEditor.MenuItem("tools/removecomponent")]
    static void Remcomp()
    {

    }

    [UnityEditor.MenuItem("tools/TestTool")]
    static void TestTool()
    {
        GameObject go = Selection.activeGameObject;
        if (go.GetComponent<MeshFilter>().sharedMesh)
        {
            Debug.Log("ok");
        }
        else
        {
            Debug.Log("nook");

        }

    }
}
