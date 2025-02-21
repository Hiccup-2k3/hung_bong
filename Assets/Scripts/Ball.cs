using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
    GameControl GameControl;
    UI UIcontrol;
    private void Start()
    {
        GameControl = FindObjectOfType<GameControl>();
        UIcontrol = FindObjectOfType<UI>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bar"))
        {

            GameControl.IncreScore();
            GameControl.ScoreUpdate();
            Destroy(gameObject);
            GameControl.SpawnBall();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            
            Destroy(gameObject);
            
            UIcontrol.Show(UI.PanelState.GameoverPanel);
            
        }


    }

}
