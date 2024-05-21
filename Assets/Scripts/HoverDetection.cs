using UnityEngine;

public class HoverDetection : MonoBehaviour
{
    public bool IsHovering { get; private set; } = false;

    private void OnMouseEnter()
    {
        IsHovering = true;
    }

    private void OnMouseExit()
    {
        IsHovering = false;
    }
}
