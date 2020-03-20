using UnityEngine;
public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            EventBus.AddToQueue("Shoot");
        }

        if (Input.GetKeyDown("l"))
        {
            EventBus.AddToQueue("Launch");
        }
		if (Input.GetKeyDown("c"))
        {
            EventBus.AddToQueue("Scream");
        }
		if (Input.GetKeyDown("h"))
        {
            EventBus.AddToQueue("Honk");
        }

		if (Input.GetKeyDown("b"))
        {
            EventBus.AddToQueue("Boom");
        }


    }
}

