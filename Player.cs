using UnityEngine;

public class Player : MonoBehaviour
{
    void Start() //called before the first frame update
    {

    }

    //SerializedField allows to keep private and still access field via editor
    [SerializeField] private float moveSpeed = 7f;

    private void Update() //called once per frame
    {
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        //normalizes input vector - this keeps actual distance moved diagonally the same going straight
        inputVector = inputVector.normalized;

        //transforms Vector 2 (x and y vector inputs) to specific vector3 input we want
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        //Time.deltaTime makes our movement speed independent of framerate
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        Debug.Log(inputVector);
    }

}
