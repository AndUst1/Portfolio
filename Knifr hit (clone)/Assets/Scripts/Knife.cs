using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{
    public Rigidbody2D knife;
    public bool knifeOnWood;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wood")
        {
            knife.velocity = Vector2.zero;
            transform.parent = other.transform;
            knifeOnWood = true;
        }        
        
        if (other.gameObject.tag == "Knife")
        {
            if (other.gameObject.GetComponent<Knife>().knifeOnWood)
            {
                knife.velocity = Vector2.zero;
                knife.gravityScale = 1;
                SceneManager.LoadScene("RestartMenu");
            }
        }
    }
}
