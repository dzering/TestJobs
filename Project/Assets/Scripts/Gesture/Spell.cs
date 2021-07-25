using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GestuerRecognition
{
    public class Spell : InteractiveObject
    {
        public int Damage;

        public void Fire()
        {
                var wandPosition = transform.parent;
                transform.parent = null;
                gameObject.AddComponent<Rigidbody>();
                var RB = gameObject.GetComponent<Rigidbody>();
                RB.AddForce(transform.forward * 50f, ForceMode.Impulse);
                Invoke("DestroySpell", 5f);
                EventBroker.SpellPerformed -= this.Fire;
        }

        private void DestroySpell()
        {
            Destroy(gameObject);
        }
        protected override void Interaction()
        {
            
        }
    }

}

