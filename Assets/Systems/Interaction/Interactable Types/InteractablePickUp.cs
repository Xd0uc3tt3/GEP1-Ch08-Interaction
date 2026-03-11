using UnityEngine;

public class InteractablePickUp : MonoBehaviour, IInteractable
{
    [SerializeField] private string pickupName = "Coin";

    public void Interact()
    {
        Debug.Log($"Picked up {pickupName}");
        Destroy(gameObject);
    }

    public void OnFocus()
    {
        ServiceHub.Instance.UIManager.ShowInteractionPrompt(true);
    }

    public void OnUnfocus()
    {
        ServiceHub.Instance.UIManager.ShowInteractionPrompt(false);
    }
}
