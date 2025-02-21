using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour
{
    int score ;
    bool play = false;
    int time;

    public UI UIControl;
    public GameObject Ball;
    public Text Score;
    public Text Time;
    void Start()
    {
        SetGamePlay(true);
        UIControl.Show(UI.PanelState.HomePanel);
    }

    public void GameStart()
    {
        
        score = 0;
        play = true;
        time = 30;
        Time.text = time.ToString();
        ScoreUpdate();
        UIControl.Show(UI.PanelState.GameGui);
        SpawnBall();
        StartCoroutine(TimePlay());
    }

    private IEnumerator TimePlay()
    {
        
        while (time > 0)
        {
            yield return new WaitForSeconds(1); 
            time--;
            Time.text = time.ToString(); 
        }
        UIControl.Show(UI.PanelState.GameoverPanel);
    }

    public void SetGamePlay(bool Status)
    {
        play = Status;
    }
    void Update()
    {
        if (!play)
        {
            UIControl.ScoreAchived.text = Score.text;
            UIControl.Show(UI.PanelState.GameoverPanel);
        }
            
    }
    public void IncreScore()
    {
        score++;
    }

    public void ScoreUpdate()
    {
        Score.text = score.ToString();
        UIControl.ScoreAchived.text = score.ToString();
    }

    public void SpawnBall()
    {
        float Xspawn = Random.Range(-8.0f, 8.0f);
        if(Ball)
        {
            Instantiate(Ball,new Vector3(Xspawn,7f,0f),Quaternion.identity);
        }
    }

}
