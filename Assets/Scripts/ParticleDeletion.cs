using UnityEngine;
using System.Collections;

using System.Linq;
/// <summary>
/// Destroys particles that are farther than DistanceToDestroy from the particlesystem emitter
/// </summary>
[RequireComponent(typeof(ParticleSystem))]
public class ParticleDeletion : MonoBehaviour
{
	public float DistanceToDestroy;
	private ParticleSystem cachedSystem;
	private Vector3 staticPosition;
	void Start()
	{
		cachedSystem = this.GetComponent<ParticleSystem>();
		staticPosition = this.transform.position;
	}
	void Update()
	{
		ParticleSystem.Particle[] ps = new ParticleSystem.Particle[cachedSystem.particleCount];
		cachedSystem.GetParticles(ps);
		// keep only particles that are within DistanceToDestroy
		var distanceParticles = ps.Where(p => Vector3.Distance(staticPosition, p.position) < DistanceToDestroy).ToArray();
		cachedSystem.SetParticles(distanceParticles, distanceParticles.Length);
	}
}