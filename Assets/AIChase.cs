using UnityEngine;

using UnityEngine;

public class AIChase : MonoBehaviour
{
    public float speed;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
    float distance = Vector2.Distance(transform.position, player.transform.position);

    if (distance < 5f && distance > 1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

}

