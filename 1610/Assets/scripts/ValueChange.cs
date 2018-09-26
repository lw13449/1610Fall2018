using UnityEngine;

[CreateAssetMenu]
public class ValueChange : ScriptableObject
{

    public FloatData Data;

    public void AddValue(FloatData data)
    {
        data.Value += FloatData.Value;
    }

    public void SubtractValue(FloatData data)
    {
        data.Value -= FloatData.Value;
    }

    public void MultiplyValue(FloatData data)
    {
        data.Value *= FloatData.Value;
    }

    public void DivideValue(FloatData)
    {
        FloatData.Value /= FloatData.Value;
    }
}
