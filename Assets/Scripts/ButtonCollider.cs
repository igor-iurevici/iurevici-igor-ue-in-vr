using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class ButtonCollider : MonoBehaviour
{
    private Button button;
    [SerializeField] private LayerMask layer = LayerMask.GetMask();
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        var boxCollider = gameObject.AddComponent<BoxCollider>();
        var sizeDelta = button.GetComponent<RectTransform>().sizeDelta;
        boxCollider.size = new Vector3(sizeDelta.x, sizeDelta.y, 0.01f);
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if ((layer.value & (1 << other.gameObject.layer)) > 0)
        {
            button.onClick?.Invoke();
            Debug.Log("Pressed");
        }
    }
}
