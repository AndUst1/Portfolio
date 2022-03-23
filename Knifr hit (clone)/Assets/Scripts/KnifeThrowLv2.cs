using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KnifeThrowLv2 : MonoBehaviour
{
    public Text amountText;
    public GameObject knifePrefab;
    private GameObject knife;

    public short amount;
    public float force;

    void Start()
    {
        knife = Instantiate(knifePrefab, transform);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knife.transform.parent = null;
            knife.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
            knife = Instantiate(knifePrefab, transform);

            Click();
        }
    }
    public void Click()
    {
        amount++;
        amountText.text = amount.ToString();
        if (amount == 15)
            SceneManager.LoadScene("Lv1");
    }
}
