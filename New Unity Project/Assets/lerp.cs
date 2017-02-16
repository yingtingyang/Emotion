using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lerp : MonoBehaviour
{
    public Slider slider;
    public float speed = 1f;
    public GameObject ObjectToRotate;
    public GameObject ObjectToGrow;
    public GameObject group1;
    public GameObject group2;
    public GameObject group3;
    public GameObject plants;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float sliderValue = GetComponent<Slider>().value;
        ObjectToRotate.transform.rotation = Quaternion.Euler(sliderValue * 360, 0, 90);
        if (sliderValue >= 0.8) {

            group1.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
            group2.transform.localScale += new Vector3(-0.001f, -0.001f, -0.001f);
            group3.transform.localScale += new Vector3(-0.001f, 0.001f, 0.001f);
            plants.transform.localScale += new Vector3(-0.001f, -0.001f, 0.001f);

        }
        else if (sliderValue <= 0.2)
        {
            group1.transform.localScale += new Vector3(-0.001f, -0.001f, -0.001f);
            group2.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
            group3.transform.localScale += new Vector3(0.001f,-0.001f,-0.001f);
            plants.transform.localScale += new Vector3(-0.001f, 0.001f,-0.001f);

        }
        else if (sliderValue >=0.3 & sliderValue <= 0.7)
        {
           
            ObjectToGrow.transform.localScale += new Vector3(-0.00001f, -0.00001f, -0.00001f);

        }
      

    }

    
}
