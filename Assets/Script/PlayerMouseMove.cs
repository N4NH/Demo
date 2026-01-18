using UnityEngine;

public class PlayerMouseMove : MonoBehaviour
{
    public Camera mainCamera;
    public float moveSpeed = 12f;

    public Vector2 minBounds = new Vector2(-8f, -4.5f);
    public Vector2 maxBounds = new Vector2( 8f,  4.5f);

    void Awake()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
    }

    void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        Vector3 mousePos = Input.mousePosition;
        float zDist = Mathf.Abs(transform.position.z - mainCamera.transform.position.z);
        mousePos.z = zDist;

        Vector3 targetPos = mainCamera.ScreenToWorldPoint(mousePos);
        targetPos.z = transform.position.z;

        targetPos.x = Mathf.Clamp(targetPos.x, minBounds.x, maxBounds.x);
        targetPos.y = Mathf.Clamp(targetPos.y, minBounds.y, maxBounds.y);

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPos,
            moveSpeed * Time.deltaTime
        );
    }
}
