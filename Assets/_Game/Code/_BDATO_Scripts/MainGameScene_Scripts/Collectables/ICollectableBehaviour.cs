using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface for any collectables added to allow for shared behaviour
public interface ICollectableBehaviour
{
    void OnCollected(GameObject Player);
}
