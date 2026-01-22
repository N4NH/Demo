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
        if (engineFire != null)
            engineFire.SetActive(true);
    }
}
