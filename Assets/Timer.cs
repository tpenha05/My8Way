using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeElapsed;
    private bool isCounting = true;

    public int fontSize = 50;
    public Color fontColor = Color.black;

    private GUIStyle style;

    void Start()
    {
        style = new GUIStyle();
        style.fontSize = fontSize;
        style.normal.textColor = fontColor;
    }

    void Update()
    {
        if (isCounting)
        {
            timeElapsed += Time.deltaTime;
        }
    }

    public void StopTimer()
    {
        isCounting = false;
    }

    void OnGUI()
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60f);
        int seconds = Mathf.FloorToInt(timeElapsed % 60f);

        string timeString = minutes.ToString("00") + ":" + seconds.ToString("00");

        // Centralizado no topo
        GUI.Label(new Rect(Screen.width / 2 - 50, 10, 200, 50), timeString, style);
    }
}
