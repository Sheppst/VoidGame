using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    public InGameEnv ActGloEnv;
    public Transform LPlayer;
    public LayerMask GMask;
    private void Awake()
    {
        GM = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GM != this)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public PhysicsMaterial GlobalEnvRest(Object obj = null)
    {   
        return null;
    }
}
