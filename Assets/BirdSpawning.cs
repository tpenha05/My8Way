using UnityEngine;

public class BirdSpawning : MonoBehaviour
{

    public GameObject[] birdPrefabs; // lista de prefabs diferentes
    public int quantidade;

    public Vector2 minPos;
    public Vector2 maxPos;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < quantidade; i++)
        {
            SpawnBird();
        }
    }


    // Update is called once per frame
    void SpawnBird()
    {
        GameObject prefab = birdPrefabs[Random.Range(0, birdPrefabs.Length)];

        // Gera uma posição aleatória
        float x = Random.Range(minPos.x, maxPos.x);
        float y = Random.Range(minPos.y, maxPos.y);
        Vector2 pos = new Vector2(x, y);

        Instantiate(prefab, pos, Quaternion.identity);
    }
}
