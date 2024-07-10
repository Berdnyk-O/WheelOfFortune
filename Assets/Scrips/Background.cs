using UnityEngine;

public class Background : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time*0.3f), Mathf.Cos(Time.time * 0.3f), 12.88f);  
    }
}
