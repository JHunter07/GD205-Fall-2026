using UnityEngine;
using UnityEngine.InputSystem;

public class physicsscript : MonoBehaviour

{
    InputAction moveAction;
    InputAction lookAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 rawMove = moveAction.ReadValue<Vector2>();
        //  Debug.Log("Raw move input= " + rawMove);
        Vector3 directionMove = new Vector3(rawMove.x, 0f, rawMove.y);

        GetComponent<Rigidbody>().AddRelativeForce(directionMove);

        //   Vector2 rawLook = lookAction.ReadValue<Vector2>();
        // Debug.Log("Raw move input= " + rawLook);// to show it in console

        //        Vector3 look = new Vector3(rawLook.y, rawLook.x, 0f);
        //      transform.Rotate(look);
    }

    void Update()
    {
        Vector2 rawLook = lookAction.ReadValue<Vector2>();
        //      Debug.Log("Raw move input= " + rawLook);// to show it in console

        Vector3 look = new Vector3(rawLook.y, rawLook.x, 0f);
        transform.Rotate(look);


    }

    void OnCollisionEnter(Collision colReport)
    {
        Debug.Log("Hit Tree");
        // Destroy(gameObject); // destroy this game object 
        //if (colReport.transform.CompareTag("Opp"))
        // {
        //collision..simulated=false;
        // Destroy(gameObject);
        Destroy(colReport.gameObject); // now destroy the object that you collided with 
        // }


     



        //void ApplyForce(Rigidbody.body) { 

        // }
    }
}