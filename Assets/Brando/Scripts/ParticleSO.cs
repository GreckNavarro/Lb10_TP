using UnityEngine;

[CreateAssetMenu(fileName = "ParticleSO", menuName = "Flyweight/ParticleSO")]
public class ParticleSO : ScriptableObject
{
    public Color color;
    public Material material;
    public float speed;
}