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

        //水平方向に入力の取得
        float horizontalInput = _PlayerInput.ReadValue<Vector2>().x;
        //垂直方向に入力の取得
        float verticalInput = _PlayerInput.ReadValue<Vector2>().y;
       // _stage.transform.Rotate(horizontalInput*0.1f, 0f, verticalInput*0.1f);

        //Vector2の入力をVector3に変換
        Vector3 rotation = new Vector3(horizontalInput,0f,verticalInput);

        //オイラー角に変換
        Quaternion tilt = Quaternion.Euler(rotation.x,0f,rotation.z);
        
        //変換した値をRigidbodyに渡す
        _stage.GetComponent<Rigidbody>().MoveRotation(_stage.GetComponent<Rigidbody>().transform.rotation * tilt);

    }
}
