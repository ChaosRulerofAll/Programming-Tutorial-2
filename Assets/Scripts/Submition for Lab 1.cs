using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitionforLab1 : MonoBehaviour
{

    private float y;
    private float x = 0f;


    // Start is called before the first frame update
    void Start()
    {
        print("Hello!\nI will be starting now...");

    }

    // Update is called once per frame
    void Update()
    {
        y = (x * x);

        print("The square of " + x + " is " + y);

        x = x + 0.01f;


    }
}
