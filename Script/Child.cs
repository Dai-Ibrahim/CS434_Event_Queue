using UnityEngine;
public class Child : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("Scream", Scream);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Scream", Scream);
        }
    }

    void Scream()
    {
            Debug.Log("Received a scream event : child screaming!");
        
    }
}