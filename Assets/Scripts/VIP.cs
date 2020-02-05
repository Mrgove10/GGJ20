using UnityEngine;

public class VIP : MonoBehaviour
{
    public Main_Manager _mainManager;

    public Material Carmaterial;
    public Light CarLight1;
    public Light CarLight2;
    Color c = new Color(0, 0, 0,255);
    private void Update()
    {
        var h = _mainManager.health;

        if (h >= 67)
        {
            c = new Color(0, 200, 0,255);
        }
        else if (h >= 34)
        {
            c = new Color(252, 186, 3,255);
        }
        else
        {
            c = new Color(200, 0, 0,255);
        }

        Carmaterial.color = c;
        CarLight1.color = c;
        CarLight2.color = c;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Debris"))
        {
            _mainManager.health -= 33;
            Debug.Log("hit Debris");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag("Finishh"))
        {
            Debug.Log("win");
            _mainManager.finishedGame();
        }
    }
}