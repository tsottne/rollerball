
using UnityEngine;

public class test2 : MonoBehaviour
{
    public int a = 5;
    public float b = 0.645632f;
    public bool c = true;
    public Vector3 scspeed;
    public Vector3 speed;



    void Start()
    {

        
    }

    void Update() {
        transform.localScale = transform.localScale + speed;
        transform.position = transform.position + scspeed;

    }

}
   

