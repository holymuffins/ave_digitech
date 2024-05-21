using UnityEngine;

public class ValueDisplay : MonoBehaviour
{
    [SerializeField]
    private RotateOnHover rotateOnHover;

    [SerializeField]
    private ValueCalculator valueCalculator;

    [SerializeField]
    private ValueListDisplay valueListDisplay;

    [SerializeField]
    private CurrentValueDisplay currentValueDisplay;

    private void Update()
    {
        if (rotateOnHover != null && valueCalculator != null && valueListDisplay != null && currentValueDisplay != null)
        {
            valueListDisplay.DisplayValues(rotateOnHover, valueCalculator);
            currentValueDisplay.DisplayCurrentValue(rotateOnHover, valueCalculator);
        }
    }
}