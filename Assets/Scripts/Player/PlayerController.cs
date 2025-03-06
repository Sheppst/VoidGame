using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameManager GM;
    Rigidbody rb;
    Collider C;
    Vector3 vel = Vector3.zero;
    bool OnGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GM = GameManager.GM;
        rb = GetComponent<Rigidbody>();
        C = GM.LPlayer.GetChild(0).GetComponent<PlayerMovement>().ActCold;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 or = new Vector3(C.bounds.center.x, C.bounds.min.y, C.bounds.center.z);
        OnGround = Physics.Raycast(or, Vector3.down, 0.15f, GM.GMask);
    }

    public void Movement(float hor, float ver, float speed, float sprintCoef, float jumpStrength ,bool sprint, bool jump)
    {
        Vector3 targ = transform.forward * ver + transform.right * hor;
        if (sprint)
            targ *= 1 + sprintCoef;
        if (jump)
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targ * speed, ref vel, 0.5f);
    }
}
