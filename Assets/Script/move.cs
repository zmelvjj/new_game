using UnityEngine;
using UnityEngine.InputSystem;

public class move : MonoBehaviour
{

    public GameObject player;
    void Start()
    {
        player = this.gameObject;
    }

    void Update()
    {
        if (InputSystem.GetDevice<Keyboard>().wKey.isPressed)
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        if (InputSystem.GetDevice<Keyboard>().sKey.isPressed)
        {
            player.transform.Translate(Vector3.back * Time.deltaTime * 5);
        }
        if (InputSystem.GetDevice<Keyboard>().aKey.isPressed)
        {
            player.transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (InputSystem.GetDevice<Keyboard>().dKey.isPressed)
        {
            player.transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
    }
}
