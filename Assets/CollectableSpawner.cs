using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject[] collectablePrefabs; // lista de prefabs diferentes
    public int quantidade = 5;
    public Vector2 minPos;
    public Vector2 maxPos;

    void Start()
    {
        for (int i = 0; i < quantidade; i++)
        {
            SpawnColetavelAleatorio();
        }
    }

    void SpawnColetavelAleatorio()
    {
        // Sorteia um prefab
        GameObject prefab = collectablePrefabs[Random.Range(0, collectablePrefabs.Length)];

        // Gera uma posição aleatória
        float x = Random.Range(minPos.x, maxPos.x);
        float y = Random.Range(minPos.y, maxPos.y);
        Vector2 pos = new Vector2(x, y);

        Instantiate(prefab, pos, Quaternion.identity);
        Debug.Log("Coletável instanciado em: " + pos);
    }
}
