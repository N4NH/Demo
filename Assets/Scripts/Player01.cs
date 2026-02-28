using UnityEngine;

public class Player01 : MonoBehaviour
{
    void Update()
    {
        var worldPoint =
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }
}
