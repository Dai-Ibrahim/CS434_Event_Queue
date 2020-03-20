using UnityEngine;
public class Car : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("Honk", Honk);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Honk", Honk);
        }
    }

    void Honk()
    {
            Debug.Log("Received a honk event : car honking!");
        
    }
}