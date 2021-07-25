 #if ENABLE_INPUT_SYSTEM 
using UnityEngine.InputSystem;
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class LookWithMouse : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public Transform wand;
    public GameObject wandTrailParticlSystem;
    private Vector3 wandStartPosition;
    private Vector3 mousePosition;
    private float zMove;

    float xRotation = 0f;
    bool isLocked = false;
    private Animator playerMovementAnimation;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementAnimation = GameObject.FindObjectOfType<DragObject>().GetComponent<Animator>();
        wandStartPosition = wand.localPosition;
        zMove = Camera.main.WorldToScreenPoint(wand.position).z;
        Cursor.lockState = CursorLockMode.Locked;
        wandTrailParticlSystem.SetActive(false);
        Cursor.visible = false;
    }

    void Update()
    {
        GetLockModeCursor();
        RotationPlayerWithMouse();

    }

    Vector3 GetMouseInWorld()
    {
        mousePosition = Input.mousePosition - new Vector3(Screen.width * 0.3f, Screen.height * 0.25f, 0);
        mousePosition.z = zMove;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    // ”правление блокировкой курсора мыши при нажатии на кнопку мыши
    void GetLockModeCursor()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerMovementAnimation.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            isLocked = true;
            wandTrailParticlSystem.SetActive(true);

        }
        if (Input.GetMouseButtonUp(0))
        {
            playerMovementAnimation.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            isLocked = false;
            wand.localPosition = wandStartPosition;
            wandTrailParticlSystem.SetActive(false);
        }
        if (Input.GetMouseButton(0))
        {
            wand.position = GetMouseInWorld();
        }
    }


    void RotationPlayerWithMouse()
    {
        if (!isLocked)
        {
#if ENABLE_INPUT_SYSTEM
        float mouseX = 0, mouseY = 0;

        if (Mouse.current != null)
        {
            var delta = Mouse.current.delta.ReadValue() / 15.0f;
            mouseX += delta.x;
            mouseY += delta.y;
        }
        if (Gamepad.current != null)
        {
            var value = Gamepad.current.rightStick.ReadValue() * 2;
            mouseX += value.x;
            mouseY += value.y;
        }

        mouseX *= mouseSensitivity * Time.deltaTime;
        mouseY *= mouseSensitivity * Time.deltaTime;
#else
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
#endif

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            playerBody.Rotate(Vector3.up * mouseX);
        }
    }

    // Update is called once per frame

}
