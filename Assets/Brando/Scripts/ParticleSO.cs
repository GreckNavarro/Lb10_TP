using UnityEngine;

[CreateAssetMenu(fileName = "ParticleSO", menuName = "ParticleSO/ParticleSO")]
public class ParticleSO : ScriptableObject
{
    public Color color;
    public Material material;
    public float speed;
}