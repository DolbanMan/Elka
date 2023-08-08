using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class EndLevel : MonoBehaviour
{
    [SerializeField]private GameObject _winPanel;
    [SerializeField] private ParticleSystem[] _booms;
 
    private Trigger[] _triggers;
    
    private void Start()
    {
        _triggers = GetComponentsInChildren<Trigger>();
    }

    private void Update()
    {
        ActiveWinPanel();
    }

    private void ActiveWinPanel()
    {
        for (int i = 0; i < _triggers.Length; i++)
        {

            if (_triggers.All(_triggers => _triggers.IsBusy == true))
            {
                _winPanel.SetActive(true);
                //ActiveBooms();
            }

        }
    }

    /*private void ActiveBooms()
    {
        foreach (var boom in _booms)
        {
            if (boom.isPlaying == false)
                boom.Play(true);
        }
    }*/
}
