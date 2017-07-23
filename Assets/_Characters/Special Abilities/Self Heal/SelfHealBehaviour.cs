using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    public class SelfHealBehaviour : AbilityBehaviour
    {
        Player player = null;

        void Start()
        {
            player = GetComponent<Player>();
        }

		public override void Use(AbilityUseParams useParams)
		{
            PlayAbilitySound();
            player.Heal((config as SelfHealConfig).GetExtraHealth());
            PlayParticleEffect();
		}
    }
}