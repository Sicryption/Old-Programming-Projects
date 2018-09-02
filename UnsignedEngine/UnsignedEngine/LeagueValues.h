#pragma once
#include "Offsets.h"
#include "Processes.h"

static class LeagueValues
{
	public:
	LeagueValues();
	~LeagueValues();

	static const bool isPreGame()
	{
		if (Processes::ReadString(Offsets::playerNameOffset) == "")
			return true;
		else
		{
			printf("\"%s\"", Processes::ReadString(Offsets::playerNameOffset));
			return false;
		}
	}

	static const int TotalAD()
	{
		return Processes::ReadFloat(Offsets::Player_TotalADOffset(), true);
	}

	static const int BaseAD()
	{
		return Processes::ReadFloat(Offsets::Player_BaseADOffset(), true);
	}

	static const int BonusAD()
	{
		return Processes::ReadFloat(Offsets::Player_BonusAttackDamageOffset(), true);
	}

	static const int Gold()
	{
		return Processes::ReadFloat(Offsets::Player_Gold(), true);
	}

	static const int Mana()
	{
		return Processes::ReadFloat(Offsets::ManaOffset(), true);
	}

	static const string PlayerName()
	{
		return Processes::ReadString(Offsets::playerNameOffset, true);
	}

	static const int PlayerHealth()
	{
		return Processes::ReadInt(Offsets::playerHealthOffset, true);
	}

	static const float PlayerHealthRounded()
	{
		return Processes::ReadFloat(Offsets::playerHealthRoundedOffset, true);
	}

	static const int LevelUpPoints()
	{
		return Processes::ReadInt(Offsets::SkillLevelUpPointsOffset(), true);
	}

	static const bool TowerFireEnabled()
	{
		return Processes::ReadInt(Offsets::TowerFireEnabledOffset(), true) == 1;
	}
};

