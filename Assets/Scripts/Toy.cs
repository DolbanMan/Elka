using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    [SerializeField] private SpringJoint2D _connector;
    [SerializeField] private LineRenderer _lineRenderer;

    private Collider2D _trigger;

    private void Start()
    {
        _lineRenderer.enabled = false;
    }

    private void Update()
    {
        Pursuit(_trigger,_connector);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Trigger trigger))
        {
            if(trigger.IsBusy!=true)
            {
                _connector.enabled = true;
                _connector.connectedAnchor = trigger.transform.position;
                _trigger = collision;
            }
            trigger.TriggerState();
        }
        
    }

    private void Pursuit(Collider2D collision, SpringJoint2D joint)
    {
        
        if(collision!=null)
        {
            _lineRenderer.enabled = true;
            _lineRenderer.SetPosition(0, transform.position);
            _lineRenderer.SetPosition(1, collision.transform.position);
        }
        if(joint==null)
        {
            _lineRenderer.enabled = false;
        }
    }

    public void Crash()
    {
        Destroy(gameObject);
    }
}
