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

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        verticalInput = context.ReadValue<Vector2>().y;
        horizontalInput = context.ReadValue<Vector2>().x;
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
    }

}
