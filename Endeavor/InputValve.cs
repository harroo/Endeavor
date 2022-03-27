
namespace Endeavor {

    public static class Input {

        private static float _horizontal;
        public static float Horizontal {

            get {
                if (_horizontal == 0.0f)
                    return UnityEngine.Input.GetAxis("Horizontal");
                else return _horizontal;
            }
            set { _horizontal = value; }
        }

        private static float _vertical;
        public static float Vertical {

            get {
                if (_vertical == 0.0f)
                    return UnityEngine.Input.GetAxis("Vertical");
                else return _vertical;
            }
            set { _vertical = value; }
        }

        private static bool _jump;
        public static bool Jump {

            get {
                if (!_jump)
                    return UnityEngine.Input.GetKey(UnityEngine.KeyCode.Space);
                else return _jump;
            }
            set { _jump = value; }
        }
    }
}
