using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public GameObject GameoverPanel;
    public GameObject GameGui;
    public GameObject HomePanel;
    public Text ScoreAchived;

    public  enum PanelState
    {
        HomePanel,
        GameGui,
        GameoverPanel
    }
    public void Show(PanelState temp)
    {

        switch (temp)
        {
            case PanelState.HomePanel:
                    HomePanel.SetActive(true);
                    GameGui.SetActive(false);
                    GameoverPanel.SetActive(false); 
                break;
            case PanelState.GameGui:
                    GameGui.SetActive(true);
                    HomePanel.SetActive(false);
                    GameoverPanel.SetActive(false);
                break;
            case PanelState.GameoverPanel:
                    GameoverPanel.SetActive(true);
                    HomePanel.SetActive(false);
                    GameGui.SetActive(false);
                break;
        }
        

    }
    
}
