using UnityEngine;
using TMPro;

public class CurrentValueDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro currentValueTextMeshPro;

    public void DisplayCurrentValue(RotateOnHover rotateOnHover, ValueCalculator valueCalculator)
    {
        if (currentValueTextMeshPro == null) return;

        int currentIndex = rotateOnHover.CurrentIndex;
        float value = valueCalculator.CalculateValue(currentIndex);
        string formattedValue = valueCalculator.FormatValueString(value, currentIndex);
        currentValueTextMeshPro.text = formattedValue;
    }
}
