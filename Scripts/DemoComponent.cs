using UnityEngine;

public class DemoComponent : MonoBehaviour
{   
    int a = 0;
    int b = 5;
    int increment = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        string s = "";
        for (int i = 1; i < 11; ++i)
        {   
            s = s + " " + i;           
        }

        Debug.Log(s);

        while (a < b)
        {
               a++;
               increment++;
        }
        
        Debug.Log(a);
        Debug.Log(b);
         Debug.Log("Total increment count is " +  $"{increment}" );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
