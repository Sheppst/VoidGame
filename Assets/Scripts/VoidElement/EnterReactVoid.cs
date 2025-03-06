using UnityEngine;

public class EnterReactVoid : MonoBehaviour
{
    [SerializeField] InGameEnv Void;
    [SerializeField] PhysicsMaterial EnvVoid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rb))
            rb.useGravity = false;
        if (other.TryGetComponent(out PlayerAction PA))
            PA.Env = Void;
        else
            other.material = EnvVoid;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rb))
            rb.useGravity = true;
        if (other.TryGetComponent(out PlayerAction PA))
            PA.Env = GameManager.GM.ActGloEnv;
        else
            other.material = GameManager.GM.GlobalEnvRest(other);
    }
}
