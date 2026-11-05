using UnityEngine;

public class objectBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(gameObject);

    }
     void OnCollisionEnter2D(Collision2D collision)
     {
      Destroy(gameObject);
   }
}
