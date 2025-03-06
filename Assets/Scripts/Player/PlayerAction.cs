using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public InGameEnv Env;
    PlayerMovement PM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PM = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        PM.ActEnv = Env.EnvMaterial;
    }
}
