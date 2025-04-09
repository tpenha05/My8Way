using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInput : MonoBehaviour
{
    public void IniciaJogo()
    {
        GameController.init();
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
