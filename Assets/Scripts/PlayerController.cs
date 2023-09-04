using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput = 0.0f;
    private float verticalInput = 0.0f;

    private PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();

    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = playerInput.actions["Movement"].ReadValue<Vector2>().y;
        horizontalInput = playerInput.actions["Movement"].ReadValue<Vector2>().x;

        //Move the vehicle
        if (verticalInput != 0f )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        }
        //Turn the vehicle
        if(horizontalInput != 0f)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);
        }
    }
}
