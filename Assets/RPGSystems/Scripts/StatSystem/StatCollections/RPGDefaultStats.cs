﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGSystems.StatSystem{
	public class RPGDefaultStats : RPGStatCollection {
		protected override void ConfigureStats ()
		{
			var stamina = CreateOrGetStat<RPGAttribute>(RPGStatType.Stamina);
			stamina.StatName = "Stamina";
			stamina.StatBaseValue = 10;

			var wisdom = CreateOrGetStat<RPGAttribute>(RPGStatType.Wisdom);
			wisdom.StatName = "Wisdom";
			wisdom.StatBaseValue = 5;

			var health = CreateOrGetStat<RPGVital>(RPGStatType.Health);
			health.StatName = "health";
			health.StatBaseValue = 100;
			health.AddLinker (new RPGStatLinkerBasic (CreateOrGetStat<RPGAttribute> (RPGStatType.Stamina), 10f));
			health.UpdateLinkers ();
			health.SetCurrentValueToMax ();

			var mana = CreateOrGetStat<RPGVital>(RPGStatType.Mana);
			mana.StatName = "mana";
			mana.StatBaseValue = 2000;
			mana.AddLinker (new RPGStatLinkerBasic (CreateOrGetStat<RPGAttribute> (RPGStatType.Wisdom), 50f));
			mana.UpdateLinkers ();
			mana.SetCurrentValueToMax ();
		}
	}
}