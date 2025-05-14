
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject biomeTilePrefab;
    public int width = 3;
    public int height = 3;
    public float spacing = 1.5f;

    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 position = new Vector2(x * spacing, y * spacing);
                Instantiate(biomeTilePrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
