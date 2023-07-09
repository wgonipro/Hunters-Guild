using UnityEditor;
using UnityEditor.EditorTools;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class LandGeneration : MonoBehaviour
{
    public GameObject[] commonPrefabs;
    public GameObject[] uncommonPrefabs;
    public float tileDistance = 3.02f;
    public int width, height;
    private int uncommonProbability = 80;

    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate()
    {
        GameObject landParent = new GameObject("landParent");
        landParent.transform.position = new Vector3(0, 0);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                GameObject tile;
                int prob = Mathf.RoundToInt(Random.Range(0, 100));
                print(prob);
                if (prob < uncommonProbability)
                {
                    int index = prob % commonPrefabs.Length;
                    print("Common: " + index);
                    tile = commonPrefabs[index];
                }
                else
                {
                    int index = prob % uncommonPrefabs.Length;
                    print("Uncommon: " + index);
                    tile = uncommonPrefabs[index];
                }
                Instantiate(tile, new Vector3(i * tileDistance, 0, j * tileDistance), new Quaternion(), landParent.transform);
            }
        }
    }
}

[EditorTool("Land Tool", typeof(LandGeneration))]
class LandTool : EditorTool
{

}