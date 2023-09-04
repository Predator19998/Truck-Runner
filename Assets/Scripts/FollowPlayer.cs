using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2, 1);
    private bool cameraToggle = false;

    private PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (playerInput.actions["CameraToggle"].WasPressedThisFrame())
        {
            cameraToggle = !cameraToggle;
        }

        Vector3 offset = cameraToggle ? offset2 : offset1;
        transform.GetChild(5).transform.position = transform.position + offset;
    }
}

