using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int vidaAtual;
    public int vidaMaxima = 5;

    public Image[] coracoes;
    public Sprite coracaoCheio;
    public Sprite coracaoVazio;

    public GameObject EndGamePanel;
    public GameObject VidaUI;


    void Update()
    {
        if (vidaAtual > vidaMaxima)
        {
            vidaAtual = vidaMaxima;
        }

        for (int i = 0; i < coracoes.Length; i++)
        {
            if (i < vidaAtual)
            {
                coracoes[i].sprite = coracaoCheio;
            }
            else
            {
                coracoes[i].sprite = coracaoVazio;
            }

            coracoes[i].enabled = i < vidaMaxima;
        }
    }

    public void TakeDamage(int damage)
    {
        vidaAtual -= damage;
        Debug.Log("Player took damage! Current health: " + vidaAtual);
        if (vidaAtual <= 0)
        {
            EndGamePanel.SetActive(true);
            VidaUI.SetActive(false);
            FindObjectOfType<Timer>().StopTimer();
        }
    }
}
