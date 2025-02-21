using UnityEngine;

public class Bar : MonoBehaviour
{
    int XDir;
    public float Speed ;
    void Start()
    {
        
    }

    
    void Update()
    {
        Moving();
    }

    void Moving()
    {
        XDir = (int)Input.GetAxisRaw("Horizontal");
        if ((XDir < 0 && transform.position.x <= -4.54) ||
            (XDir > 0 && transform.position.x >= 4.54))
            return;
        transform.Translate(XDir * Speed * Time.deltaTime,0,0);
    }
}
