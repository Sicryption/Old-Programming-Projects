#pragma once
#include "stdafx.h"
#include "Processes.h"
#include <memory>
#include <windows.h>
#include <iostream>

class Offsets
{
	public:
		Offsets();
		~Offsets();

		static const DWORD LocalHero = 0x164C890;
		static const DWORD PlayerInstance = 0x164FC04;//Not sure if this is the right name
		static const DWORD playerNameOffset = 0x164BC00;
		static const DWORD playerHealthRoundedOffset = 0x383366F0;
		static const DWORD playerHealthOffset = 0x7F6F060;

		struct LocalHero
		{
			int BaseAD;
			static const DWORD base = 0x164C890;
			static DWORD BaseAD = Processes::ReadDWORD(base) + 
		};

		static const DWORD ManaOffset() 
		{
			DWORD pointer2 = Processes::ReadDWORD(PlayerInstance) + 0x18;
			DWORD pointer3 = Processes::ReadDWORD(pointer2, true) + 0x4;
			DWORD value = Processes::ReadDWORD(pointer3, true) + 0x5C;

			return value;
		}

		static const DWORD Player_TotalADOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(PlayerInstance) + 0x20;
			DWORD pointer3 = Processes::ReadDWORD(pointer2, true) + 0x04;
			DWORD pointer4 = Processes::ReadDWORD(pointer3, true) + 0x10;
			DWORD value = Processes::ReadDWORD(pointer4, true) + 0x10;

			return value;
		}

		static const DWORD Player_BaseADOffset()
		{
			return LocalHero::base;
		}

		static const DWORD Player_BonusAttackDamageOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94;

			return pointer2;
		}

		static const DWORD Player_BonusAbilityPowerOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94 + 0x8;

			return pointer2;
		}

		static const DWORD Player_BonusArmorOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94 + 0xA0;

			return pointer2;
		}

		static const DWORD Player_BonusMagicResistanceOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94 + 0xA4;

			return pointer2;
		}

		static const DWORD Player_TotalMagicResistanceOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94 + 0xA8;

			return pointer2;
		}

		static const DWORD Player_TotalArmorOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94 + 0x9C;

			return pointer2;
		}

		static const DWORD Player_TotalMovementSpeedOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(LocalHero) + 0xD94 + 0xB4;

			return pointer2;
		}

		static const DWORD Player_Gold()
		{
			DWORD pointer2 = Processes::ReadDWORD(PlayerInstance) + 0x48;
			DWORD pointer3 = Processes::ReadDWORD(pointer2, true) + 0x44;

			return pointer3;
		}

		static const DWORD SkillLevelUpPointsOffset()
		{
			DWORD pointer2 = Processes::ReadDWORD(PlayerInstance) + 0x8;
			DWORD pointer3 = Processes::ReadDWORD(pointer2, true) + 0x2C;
			DWORD value = Processes::ReadDWORD(pointer3, true) + 0x1C0;

			return value;
		}

		static const DWORD TowerFireEnabledOffset()
		{
			DWORD pointer1 = 0x32C0738;
			DWORD pointer2 = Processes::ReadDWORD(pointer1) + (0xB*0x8);
			DWORD pointer3 = Processes::ReadDWORD(pointer2, true) + 0x0C;
			DWORD value = Processes::ReadDWORD(pointer3, true) + 0x290;

			return value;
		}

		static const DWORD Player_CSScore()
		{
			DWORD value = Processes::ReadDWORD(LocalHero) + 0x41F8;

			return value;
		}
};

