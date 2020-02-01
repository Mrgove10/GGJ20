using UnityEngine;

public class VIP : MonoBehaviour
{
    public Main_Manager _mainManager;

    public Material Carmaterial;
    public Light CarLight1;
    public Light CarLight2;

    private void Update()
    {
        var h = _mainManager.health;
        var c = new Color(0, 0, 0);
        if (h > 66.6)
        {
            c = new Color(0, 200, 0);
        }
        else if (h > 33.3)
        {
            c = new Color(252, 186, 3);
        }
        else
        {
            c = new Color(200, 0, 0);
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