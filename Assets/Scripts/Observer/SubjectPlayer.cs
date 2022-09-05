using System.Collections.Generic;
using UnityEngine;

public class SubjectPlayer : MonoBehaviour
{
    public static SubjectPlayer instance;
    public List <ObserverInterface> list;
    private void Awake()
    {
        instance=this;
        list = new List<ObserverInterface>();
    }
    public void AddObeserver(ObserverInterface obs)
    {
        list.Add(obs);
    }
    public void NotifyObservers()
    {
        foreach (ObserverInterface obs in list)
        {
            obs.NotifyObserver();
        }
    }
}
