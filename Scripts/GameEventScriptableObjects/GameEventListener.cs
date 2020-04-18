using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour {

    public GameEventSO eventSO;
    public UnityEvent response;

    private void OnEnable()
    {
        eventSO.RegisterListener(this);
    }

    private void OnDisable()
    {
        eventSO.RemoveListener(this);
    }

    public void OnEventRaised(){
        response.Invoke();
    }
}
