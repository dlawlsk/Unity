using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(x, y, 0) * Time.deltaTime * 6f);
    }
    public class Control : MonoBehaviour
    {
        // Update is called once per frame

        void Update()
        {
           
        }
    }
}
    

