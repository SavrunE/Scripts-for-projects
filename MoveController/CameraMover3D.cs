//закрпим камеру за персонажем на координатах CameraPosition
public class CameraMover : MonoBehaviour
{
    public GameObject PlayerPosition;
    public Vector3 CameraPosition = new Vector3(0,4,-4);
    void Start()
    {
        CameraPosition -= PlayerPosition.transform.position;
    }

    void FixedUpdate()
    {
        transform.position = PlayerPosition.transform.position + CameraPosition;
    }
}
