using UnityEngine;

[ExecuteInEditMode]
public class SZUIRenderQueue : MonoBehaviour
{
    public int renderQueue = 3000;
    public bool runOnlyOnce = false;

    private void Start()
    {
        Update();
    }

    private void Update()
    {
        var particles = gameObject.GetComponentsInChildren<ParticleSystem>();
        foreach (var particle in particles)
        {
            if (particle.gameObject.GetComponent<Renderer>() != null && particle.gameObject.GetComponent<Renderer>().sharedMaterial != null)
            {
                particle.gameObject.GetComponent<Renderer>().sharedMaterial.renderQueue = renderQueue;
            }
        }

        if (runOnlyOnce && Application.isPlaying)
        {
            this.enabled = false;
        }
    }
}