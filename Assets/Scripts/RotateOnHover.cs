using UnityEngine;

public class RotateOnHover : MonoBehaviour
{
    [SerializeField]
    private float rotationAngle = 27f;

    [SerializeField]
    private int maxIndex = 4;

    private int currentIndex = 0;

    public int MaxIndex => maxIndex;

    public int CurrentIndex
    {
        get { return currentIndex; }
        private set
        {
            if (value >= 0 && value <= maxIndex)
            {
                currentIndex = value;
                RotateObject();
            }
        }
    }

    private void Start()
    {
        SetRotation(0);
    }

    public void RotateControl(float scrollAmount)
    {
        if (scrollAmount > 0 && CurrentIndex < maxIndex)
        {
            CurrentIndex++;
        }
        else if (scrollAmount < 0 && CurrentIndex > 0)
        {
            CurrentIndex--;
        }
    }

    private void RotateObject()
    {
        float newAngle = currentIndex * rotationAngle;
        SetRotation(newAngle);
    }

    private void SetRotation(float angle)
    {
        transform.localEulerAngles = new Vector3(0, angle, 0);
    }
}
