
using UnityEngine;

public class AndroidInputController : MonoBehaviour {

    public void Forward_PointerUp () { Endeavor.Input.Vertical = 0.0f; }
    public void Forward_PointerDown () { Endeavor.Input.Vertical = 1.0f; }

    public void Backward_PointerUp () { Endeavor.Input.Vertical = 0.0f; }
    public void Backward_PointerDown () { Endeavor.Input.Vertical = -1.0f; }

    public void Left_PointerUp () { Endeavor.Input.Horizontal = 0.0f; }
    public void Left_PointerDown () { Endeavor.Input.Horizontal = -1.0f; }

    public void Right_PointerUp () { Endeavor.Input.Horizontal = 0.0f; }
    public void Right_PointerDown () { Endeavor.Input.Horizontal = 1.0f; }

    public void Jump_PointerUp () { Endeavor.Input.Jump = false; }
    public void Jump_PointerDown () { Endeavor.Input.Jump = true; }
}
