using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth = 100;
    [SerializeField] private UnityEvent<int> OnReceiveDamage;
    [SerializeField] private UnityEvent OnZeroHealth;
    [SerializeField] private UnityEvent<int> OnReceiveHealth;

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    public int CurrentHealth
    {
        get => _currentHealth;
        set => _currentHealth = value;
    }

    public void ReceiveDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        OnReceiveDamage?.Invoke(CurrentHealth);
        if (CurrentHealth <= 0)
        {
            OnZeroHealth?.Invoke();
        }
    }

    public void GainHealth(int gainAmount)
    {
        _currentHealth += gainAmount;
        _currentHealth = Mathf.Clamp(CurrentHealth, 0, _maxHealth);
        OnReceiveDamage?.Invoke(_currentHealth);
    }
}
