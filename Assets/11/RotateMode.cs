using UnityEngine;
using System.Collections;

public class RotateMode : MonoBehaviour
{

    public float speed = 20.0F;
    private float flag;
    private bool bRotate;
    // Use this for initialization  
    void Start()
    {
        bRotate = false;
    }

    // Update is called once per frame  
    void Update()
    {

        // 这里乘以Time.deltaTime 函数是为了使旋转效果更加平滑。  
        flag = Input.GetAxis("Mouse X");

        if (Input.GetKey("left"))
        {
            Debug.Log("left");
            this.transform.Rotate(Vector3.up * Time.deltaTime * -speed);
        }
        if (Input.GetKey("right"))
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
    }

    void OnGUI()
    {
        if (Event.current.type == EventType.MouseDrag)
        {
            if (bRotate)
            {
                transform.Rotate(new Vector3(0, -Input.GetAxis("Mouse X"), 0) * speed);
            }
        }
    }
    void OnMouseEnter()
    {
       // clickObj scriptObj = (clickObj)gameObject.GetComponent("clickObj");
       // bool bFlag = clickObj.bDrag;
        if (!bRotate)
            bRotate = true;
        //  print("Enter in horse model");  
    }
    void OnMouseExit()
    {
        if (bRotate)
            bRotate = false;
        //  print("Exit horse area");  
    }

    void OnCollisionEnter()
    {
        print("On collision enter");
    }
    void OnTriggerEnter()
    {
        print("On trigger enter");
    }
}