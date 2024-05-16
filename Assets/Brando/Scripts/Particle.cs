using UnityEngine;

public class Particle
{
    public Vector3 Position { get; private set; }
    public float Lifetime { get; private set; }
    private readonly ParticleSO flyweight;
    private GameObject particleObject1;

    public Particle(Vector3 position, float lifetime, ParticleSO flyweight,GameObject particleObject)
    {
        Position = position;
        Lifetime = lifetime;
        this.flyweight = flyweight;
        particleObject1.GetComponent<MeshFilter>().mesh = particleObject.GetComponent<MeshFilter>().mesh;
        this.particleObject1.transform.position = Position;
        this.particleObject1.GetComponent<Renderer>().material = flyweight.material;
        this.particleObject1.GetComponent<Renderer>().material.color = flyweight.color;

    }

    public void Update(float deltaTime)
    {
        Lifetime -= deltaTime;
        Position += Vector3.up * flyweight.speed * deltaTime;
        particleObject1.transform.position = Position;

        if (Lifetime <= 0)
        {
            GameObject.Destroy(particleObject1);
        }
    }

    public void Render()
    {
        particleObject1.transform.position = Position;
        particleObject1.GetComponent<Renderer>().material = flyweight.material;
        particleObject1.GetComponent<Renderer>().material.color = flyweight.color;
    }
}
