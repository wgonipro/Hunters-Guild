using UnityEditor;
using UnityEditor.EditorTools;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class LandGeneration : MonoBehaviour
{
    public GameObject[] commonPrefabs;
    public GameObject[] uncommonPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[EditorTool("Land Tool", typeof(LandGeneration))]
class LandTool : EditorTool
{

}