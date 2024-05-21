using UnityEngine;

public class HighlightOnHover : MonoBehaviour
{
    private Color originalColor;
    private Renderer objectRenderer;
    private HoverDetection hoverDetection;

    void Start()
    {
        
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;

        hoverDetection = GetComponent<HoverDetection>();
    }

    void Update()
    {
        if (hoverDetection != null)
        {
            if (hoverDetection.IsHovering)
            {
                
                objectRenderer.material.color = Color.red;
            }
            else
            {
                
                objectRenderer.material.color = originalColor;
            }
        }
    }
}
