using UnityEngine;

public class Trigger : MonoBehaviour
{
    private bool _isBusy = false;

    public bool IsBusy => _isBusy;

    public void TriggerState()
    {
        _isBusy = true;
    }
}
