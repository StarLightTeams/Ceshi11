using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent1 : MonoBehaviour {
    public UISlider slider;
    public GameObject people;
    public Transform people_tf;
    void Start()
    {
        Debug.Log("start");
        slider = GetComponent<UISlider>();
        people_tf = people.transform;
    }
    public void changeValue()
    {
        float a =slider.value;
        Debug.Log(a);
        people_tf.localScale = new Vector3(1, 1, a*2);
    }
}
