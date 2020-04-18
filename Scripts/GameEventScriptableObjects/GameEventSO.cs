using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEventSO : ScriptableObject {

    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise(){
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }


    public void RegisterListener(GameEventListener listenerToRegister){
        listeners.Add(listenerToRegister);
    }

    public void RemoveListener(GameEventListener listenerToRemove)
    {
        listeners.Remove(listenerToRemove);
    }
}
