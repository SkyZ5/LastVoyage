using Unity.VisualScripting;
using UnityEngine;

public class CockpitScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private BoxCollider BoxCollider;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        BoxCollider = GetComponent<BoxCollider>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ran");
        spriteRenderer.enabled = true;

    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("running");
        spriteRenderer.enabled = false;
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("stopped");
        spriteRenderer.enabled = true;
    }
}
