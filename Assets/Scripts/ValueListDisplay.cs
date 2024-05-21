using UnityEngine;
using TMPro;

public class ValueListDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMeshPro;

    public void DisplayValues(RotateOnHover rotateOnHover, ValueCalculator valueCalculator)
    {
        if (textMeshPro == null) return;

        int maxIndex = rotateOnHover.MaxIndex + 1;
        string[] values = new string[maxIndex];

        for (int i = 1; i < maxIndex; i++)
        {
            float value = valueCalculator.CalculateValue(i);
            if (i == rotateOnHover.CurrentIndex)
            {
                values[i] = valueCalculator.FormatValueString(value, i);
            }
            else
            {
                values[i] = "0";
            }
        }

        string displayText = string.Join("\n", values);
        textMeshPro.text = displayText;
    }
}