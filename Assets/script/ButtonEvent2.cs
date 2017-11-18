using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent2 : MonoBehaviour
{
    public UISlider slider;
    public GameObject people;
    public Transform people_tf;
    void Start()
    {
        slider = GetComponent<UISlider>();
        people_tf = people.transform;
    }
    public void changeValue()
    {
        float a = slider.value;
        people_tf.localScale = new Vector3(a * 2, a * 2, 1);
    }
}
