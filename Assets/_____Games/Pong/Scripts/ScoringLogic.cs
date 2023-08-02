using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringLogic : MonoBehaviour
{
    public EventTrigger.TriggerEvent trigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PongBall ball = collision.gameObject.GetComponent<PongBall>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.trigger.Invoke(eventData);
        }
    }
}
