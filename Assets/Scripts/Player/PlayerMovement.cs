using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] KeyCode Sprint = KeyCode.LeftShift;
    [SerializeField] KeyCode Jump = KeyCode.Space;
    [SerializeField] float speed;
    [SerializeField] float sprintCoef;
    [SerializeField] float jumpStrength;

    PlayerController PC;
    float hor;
    float ver;
    bool sprint;
    bool jump;
    
    public PhysicsMaterial ActEnv;
    public Collider ActCold;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PC = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ActCold.material != ActEnv)
            ActCold.material = ActEnv;
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
        sprint = Input.GetKeyDown(Sprint);
        jump = Input.GetKeyDown(Jump);
    }

    void FixedUpdate()
    {
        PC.Movement(hor, ver, speed, sprintCoef, jumpStrength, sprint, jump);
    }
}
