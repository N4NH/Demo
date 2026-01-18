using UnityEngine;

public class EngineFireToggle : MonoBehaviour
{
    public GameObject engineFire;

    void Start()
    {
        if (engineFire != null)
            engineFire.SetActive(false); // ban đầu tắt lửa
    }

    void Update()
    {
        bool isMoving = Input.GetMouseButton(0); // giữ chuột trái mới bay
        if (engineFire != null)
            engineFire.SetActive(isMoving);
    }
}
