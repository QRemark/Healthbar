using TMPro;
using UnityEngine;

public class TextHealthbar : MonoBehaviour
{
    [SerializeField] private PlayerHealthContainer _playerHealth;
    [SerializeField] private TMP_Text _healthText;

    private void Start()
    {
        _playerHealth.OnHealthChanged.AddListener(UpdateHealthText);
        UpdateHealthText(_playerHealth.CurrentHealth, _playerHealth.MaxHealth);
    }

    private void UpdateHealthText(float currentHealth, float maxHealth)
    {
        _healthText.text = $"{currentHealth} / {maxHealth}";
    }

    private void OnDestroy()
    {
        _playerHealth.OnHealthChanged.RemoveListener(UpdateHealthText);
    }
}
