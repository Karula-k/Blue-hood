using UnityEngine;

public class CameraControler : MonoBehaviour
{
    // Room Camera
    [SerializeField] private float seped;
    private float currentX;
    private Vector3 velocity = Vector3.zero;

    //Follow player
    [SerializeField] private Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
