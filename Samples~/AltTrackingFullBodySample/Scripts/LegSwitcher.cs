using UnityEngine;

/// <summary>
/// Script for selecting leg models.
/// </summary>
[ExecuteInEditMode]
public class LegSwitcher : MonoBehaviour {
    public enum Models {
        Shin,
        Foot
    }

    public Models CurrentModel {
        get { return _currentModel; }
        set {
            _currentModel = value;
            SwitchModel();
        }
    }

    [SerializeField] private Models _currentModel = Models.Shin;

    private void SwitchModel() {
        foreach (Transform leg in transform) {
            foreach (Transform child in leg.transform) {
                child.gameObject.SetActive(child.name == _currentModel.ToString());
            }
        }
    }
    private void Update() {
        CurrentModel = _currentModel;
    }
}
