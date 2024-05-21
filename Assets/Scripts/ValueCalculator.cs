using UnityEngine;

public class ValueCalculator : MonoBehaviour
{
    [SerializeField]
    private float P = 400f; 

    [SerializeField]
    private float R = 1000f; 

    public float CalculateValue(int index)
    {
        switch (index)
        {
            case 0:
                return 0f; 
            case 1:
                return 0.01f; 
            case 2:
                return Mathf.Sqrt(P * R); 
            case 3:
                return R; 
            case 4:
                return Mathf.Sqrt(P / R); 
            default:
                return 0f; 
        }
    }

    
    public string FormatValueString(float value, int index)
    {
        return (index == 0 || index == 3) ? value.ToString("F0") : value.ToString("F2");
    }
}