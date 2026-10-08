using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    private InputAction _PlayerInput;

    [SerializeField]
    private GameObject _stage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _PlayerInput = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
   
        float horizontalInput = _PlayerInput.ReadValue<Vector2>().x;
        float verticalInput = _PlayerInput.ReadValue<Vector2>().y;
        _stage.transform.Rotate(horizontalInput*0.15f, 0f, verticalInput*0.15f);
    }
}
