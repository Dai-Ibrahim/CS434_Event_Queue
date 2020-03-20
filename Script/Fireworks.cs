using UnityEngine;
public class Fireworks : MonoBehaviour
{
    private bool m_IsQuitting;
    private bool m_IsReleased = false;

    void OnEnable()
    {
        EventBus.StartListening("Boom", Boom);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Boom", Boom);
        }
    }

    void Boom()
    {
        if (m_IsReleased == false)
        {
            m_IsReleased = true;
            Debug.Log("Received a boom event : fireworks booming!");
        }
    }
}