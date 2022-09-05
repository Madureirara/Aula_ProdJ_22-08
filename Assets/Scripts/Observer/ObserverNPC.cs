using UnityEngine;

public class ObserverNPC : MonoBehaviour, ObserverInterface { 

    public void Start()
    {
        SubjectPlayer.instance.AddObeserver(this);
    }
    public void NotifyObeserver()
    {
        Debug.Log("Avisado:" + gameObject.name);
    }

}
