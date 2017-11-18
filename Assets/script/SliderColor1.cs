using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SliderColor1 : MonoBehaviour
{

    public Color[] colors = new Color[] { Color.red, Color.yellow, Color.green };
    Slider mSlider;
    // Use this for initialization
    void Start()
    {
        mSlider = GetComponent<Slider>();
        mSlider.fillRect.transform.GetComponent<Image>().color = Color.red;
        Update();
    }
    void Update()
    {
        float val = mSlider.value;
        val *= (colors.Length - 1);
        int startIndex = Mathf.FloorToInt(val);

        Color c = colors[0];

        if (startIndex >= 0)
        {
            if (startIndex + 1 < colors.Length)
            {
                float factor = (val - startIndex);
                c = Color.Lerp(colors[startIndex], colors[startIndex + 1], factor);
            }
            else if (startIndex < colors.Length)
            {
                c = colors[startIndex];
            }
            else c = colors[colors.Length - 1];
        }
        c.a = mSlider.fillRect.transform.GetComponent<Image>().color.a;
        mSlider.fillRect.transform.GetComponent<Image>().color = c;
    }
}