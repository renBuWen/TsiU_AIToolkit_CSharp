using UnityEngine;

namespace AIToolkitDemo
{
    class AIBehaviorRequest
    {
        public AIBehaviorRequest(float timeStamp, Vector3 nextMovingTarget)
        {
            this.timeStamp = timeStamp;
            this.nextMovingTarget = nextMovingTarget;
        }

        // Note :【03】属性成熟的写法
        public float timeStamp { get; private set; }
        public Vector3 nextMovingTarget { get; private set; }
    }
}
