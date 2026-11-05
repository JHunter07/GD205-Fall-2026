using UnityEngine;

public class seeker : MonoBehaviour
{
    public Transform target;
    public float forceMultiplier = 3f; // write f at the end of the number to identify it as a float 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate() {

        Vector3 targetOffset = target.position - transform.position;
        Vector3 targetDirection = Vector3.Normalize(targetOffset);

        GetComponent<Rigidbody>().AddForce(targetDirection);
    }
}
