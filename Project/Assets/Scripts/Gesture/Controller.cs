using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GestuerRecognition
{
    public sealed class Controller : MonoBehaviour
    {
        private InputController inputController;
        private GestureTemplates gestureTemplates;
        private Reference reference;
        private Spell spell;

        private void Awake()
        {
            gestureTemplates = new GestureTemplates();
            inputController = new InputController(gestureTemplates);
            reference = new Reference();
            inputController.HappenedSpell += CreateSpell;
            
        }

        private void Update()
        {
            inputController.Execute();
        }

        private void CreateSpell(object o, SpellName spellName)
        {
            spell = reference.LoadSpell(spellName);
            EventBroker.SpellPerformed += spell.Fire;
        }

    }
}

