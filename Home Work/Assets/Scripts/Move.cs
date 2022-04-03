using UnityEngine;

public class Move : MonoBehaviour
{    
    private Rigidbody rb;
    private Animator animator;

    public float speed = 1f;
    public float rotationSpeed = 10f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float v = Input.GetAxis("Horizontal");
        float h = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
            speed = 3;
        else
            speed = 1;

        Vector3 directionVector = new Vector3(v, 0, h);
        if (directionVector.magnitude > Mathf.Abs(0.07f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);

        animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
    }
}
