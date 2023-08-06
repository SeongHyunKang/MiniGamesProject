using System.Collections;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SequentialGradientChanger : MonoBehaviour
{
    private TextMeshProUGUI tmpText;
    public float interval = 0.5f;

    private float hueValue = 0f;

    private void Start()
    {
        tmpText = GetComponent<TextMeshProUGUI>();
        tmpText.enableVertexGradient = true;
        StartCoroutine(ChangeRainbowColor());
    }

    private IEnumerator ChangeRainbowColor()
    {
        while (true)
        {
            Color color = Color.HSVToRGB(hueValue, 1f, 1f);
            tmpText.colorGradient = new VertexGradient(color, color, color, color);

            hueValue += 0.01f;
            if (hueValue > 1f)
            {
                hueValue = 0f;
            }

            yield return new WaitForSeconds(interval);
        }
    }
}






