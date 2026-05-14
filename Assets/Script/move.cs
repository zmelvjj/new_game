using UnityEngine;
using UnityEngine.InputSystem;

public class move : MonoBehaviour
{
    public GameObject player;

    private PlayerInput playerInput;

    void Start()
    {
        player = this.gameObject;
        playerInput = this.GetComponent<PlayerInput>();

        playerInput.actions["Move"].performed += OnMove;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed){
            Vector2 inputVector = context.ReadValue<Vector2>();
            Vector2 movement = new Vector2(inputVector.x, inputVector.y);
            player.transform.Translate(movement * Time.deltaTime * 5f);
        }
    }

    void OnDestroy()
    {
        playerInput.actions["Move"].performed -= OnMove;
    }
}
