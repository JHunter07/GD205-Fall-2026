using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform redport;
    public Transform BlueBoard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == redport.position)
        {
            Debug.Log("instanttransmission");
            BlueBoard.position = new Vector3(19, 1, 1);
            transform.position = new Vector3(45, 0, 5);
        }
    }
}
