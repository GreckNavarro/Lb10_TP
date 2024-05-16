using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public List<ParticleSO> particleSO;
    private List<Particle> particles = new List<Particle>();
    [SerializeField] private GameObject particleObject;

    private void Awake()
    {
        
    }
    void Start()
    {
        if (particleSO.Count > 0)
        {
            CreateParticle(new Vector3(0, 0, 0), particleSO[0], 5.0f);
        }
    }

    void Update()
    {
        float deltaTime = Time.deltaTime;
        UpdateParticles(deltaTime);
        RenderParticles();
    }

    public void CreateParticle(Vector3 position, ParticleSO flyweight, float lifetime)
    {
        Particle particle = new Particle(position, lifetime, flyweight, particleObject);
        particles.Add(particle);
    }

    public void UpdateParticles(float deltaTime)
    {
        for (int i = particles.Count - 1; i >= 0; i--)
        {
            particles[i].Update(deltaTime);
            if (particles[i].Lifetime <= 0)
            {
                particles.RemoveAt(i);
            }
        }
    }

    public void RenderParticles()
    {
        foreach (var particle in particles)
        {
            particle.Render();
        }
    }
}
