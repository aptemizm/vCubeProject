using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private UnityEvent _actionOn;
    [SerializeField] private UnityEvent _actionOff;

    private int _numberOfAffectedObjects;
    private bool _isOn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            _numberOfAffectedObjects++;            
        }

        Debug.Log(_numberOfAffectedObjects);

        if (!_isOn && _numberOfAffectedObjects > 0)
        {
            _actionOn?.Invoke();
            _isOn = true;
            _animator.SetBool("on", _isOn);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            _numberOfAffectedObjects--;
        }

        Debug.Log(_numberOfAffectedObjects);

        if (_isOn && _numberOfAffectedObjects == 0) 
        {
            _actionOff?.Invoke();
            _isOn = false;
            _animator.SetBool("on", _isOn);
        }
    }
}
