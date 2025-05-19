using UnityEngine;

public class BackgroundScrollingScript : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer bgRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
