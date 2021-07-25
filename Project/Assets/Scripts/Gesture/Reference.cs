using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GestuerRecognition
{
    public sealed class Reference
    {
        private Spell test;

        public Spell LoadSpell(SpellName spellName)
        {
            Spell gameObject = null;
            GameObject spellMark = null;
            int damage = 0;
            if (spellName == SpellName.FireOne || spellName == SpellName.FireTwo || spellName == SpellName.FireThree)
            {
                switch (spellName)
                {
                    case SpellName.FireOne: damage = 1;
                        break;
                    case SpellName.FireTwo: damage = 2;
                        break;
                    case SpellName.FireThree: damage = 3;
                        break;
                }
                gameObject = Resources.Load<Spell>("FireAura");
            }
            if (spellName == SpellName.AirOne || spellName == SpellName.AirTwo || spellName == SpellName.AirThree)
            {
                switch (spellName)
                {
                    case SpellName.AirOne: damage = 2;
                        break;
                    case SpellName.AirTwo: damage = 4;
                        break;
                    case SpellName.AirThree: damage = 6;
                        break;
                }

                gameObject = Resources.Load<Spell>("AirAura");
            }
            if (spellName == SpellName.EarthOne || spellName == SpellName.EarthTwo || spellName == SpellName.EarthThree)
            {
                switch (spellName)
                {
                    case SpellName.EarthOne: damage = 3;
                        break;
                    case SpellName.EarthTwo: damage = 6;
                        break;
                    case SpellName.EarthThree: damage = 9;
                        break;
                }
                gameObject = Resources.Load<Spell>("EarthAura");
            }
            if (spellName == SpellName.WaterOne || spellName == SpellName.WaterTwo || spellName == SpellName.WaterThree)
            {
                switch (spellName)
                {
                    case SpellName.WaterOne:
                        damage = 4;
                        break;
                    case SpellName.WaterTwo:
                        damage = 8;
                        break;
                    case SpellName.WaterThree:
                        damage = 12;
                        break;
                }
                gameObject = Resources.Load<Spell>("WaterAura");
            }

            test = Object.Instantiate(gameObject);
            gameObject.Damage = damage;
            var wand = GameObject.FindObjectOfType<DragObject>();
            test.transform.parent = wand.transform;
            test.transform.localRotation = Quaternion.Euler(0, 0, 0);
            test.transform.localPosition = new Vector3(0, 0, 1f);
            return test;
        }
    }
}

