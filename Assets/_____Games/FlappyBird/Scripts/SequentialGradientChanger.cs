using System.Collections;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SequentialGradientChanger : MonoBehaviour
{
    private TextMeshProUGUI tmpText;
    public float interval = 0.5f;

    private float hueValue = 0f; // 현재 hue 값. 0.0에서 1.0 사이의 값.

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
            Color color = Color.HSVToRGB(hueValue, 1f, 1f); // 채도(Saturation)와 명도(Value)는 최대값인 1로 설정
            tmpText.colorGradient = new VertexGradient(color, color, color, color);

            hueValue += 0.01f; // Hue 값 조절. 색상 변경 속도를 변경하려면 이 값을 조절하세요.
            if (hueValue > 1f)
            {
                hueValue = 0f;
            }

            yield return new WaitForSeconds(interval);
        }
    }
}






