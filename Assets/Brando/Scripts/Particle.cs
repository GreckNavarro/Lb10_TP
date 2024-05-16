using UnityEngine;

public class Particle
{
    public Vector3 Position { get; private set; }
    public float Lifetime { get; private set; }
    private readonly ParticleSO flyweight;
    private GameObject particleObject;

    public Particle(Vector3 position, float lifetime, ParticleSO flyweight,GameObject particleObject)
    {
        Position = position;
        Lifetime = lifetime;
        this.flyweight = flyweight;
        this.particleObject = particleObject;
        particleObject.transform.position = Position;
        particleObject.GetComponent<Renderer>().material = flyweight.material;
        particleObject.GetComponent<Renderer>().material.color = flyweight.color;

    }

    public void Update(float deltaTime)
    {
        Lifetime -= deltaTime;
        Position += Vector3.up * flyweight.speed * deltaTime;
        particleObject.transform.position = Position;

        if (Lifetime <= 0)
        {
            GameObject.Destroy(particleObject);
        }
    }

    public void Render()
    {
        particleObject.transform.position = Position;
        particleObject.GetComponent<Renderer>().material = flyweight.material;
        particleObject.GetComponent<Renderer>().material.color = flyweight.color;
    }
}
