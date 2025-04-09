using UnityEngine;


public class UiManager : MonoBehaviour
{
    public GameObject EndGamePanel;

    void Start()
    {
        GameController.init();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.GameOver)
        {
            EndGamePanel.SetActive(true);
        }
    }
}
