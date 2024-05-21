using UnityEngine;

public class ScrollRotation : MonoBehaviour
{
    [SerializeField]
    private RotateOnHover rotateOnHover; 
    private HoverDetection hoverDetection;

    private void Start()
    {
        hoverDetection = GetComponent<HoverDetection>();
        if (rotateOnHover == null)
        {
            rotateOnHover = GetComponent<RotateOnHover>();
        }
    }

    private void Update()
    {
        if (hoverDetection != null && hoverDetection.IsHovering)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0)
            {
                rotateOnHover.RotateControl(scroll);
            }
        }
    }
}
