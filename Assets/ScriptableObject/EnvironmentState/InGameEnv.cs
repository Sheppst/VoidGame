using UnityEngine;

[CreateAssetMenu(fileName = "NewEnv", menuName = "Scriptable Objects/InGameEnv")]
public class InGameEnv : ScriptableObject
{
    public enum EnvType
    {
        None,
        Normal,
        Void,
    }
    [Header("Data")]
    public EnvType Environment;
    public bool IsDangerous;
    [Min(0)] public float KillTime;

    [Header("Physics")]
    public PhysicsMaterial EnvMaterial;
}
