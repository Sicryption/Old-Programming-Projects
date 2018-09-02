#pragma once
#include "Processes.h"
#include "stdafx.h"
#include "Offsets.h"
#include "LeagueValues.h"
#include <string>
#include "capstone.h"
#include "PolyHook.hpp"

bool close = false;

bool TryInject()
{
	HWND window = ::FindWindowA(0, (LPCSTR)("League of Legends (TM) Client"));

	if (window == 0) {
		printf("Not Injected\n");
		return false;
	}

	printf("Injecting\n");

	//load information

	//load scripts
}

void Debug()
{
	DWORD offset = Offsets::Player_CSScore();
	cout << "test: " << Processes::ReadInt(offset, true) << "\n";
	printf("%x\n", offset);
}

#define FN_CREATE_OBJECT	0x4A29D0
#define FN_PRINT_CHAT		0x53F320
#define CHAT_CLIENT			0x32D38D8
typedef int(__thiscall *fnCreateObject)(DWORD ptr, DWORD NetworkID);
typedef int(__thiscall *fnPrintChat)(DWORD ptr, const char* Message, int Type);
fnCreateObject oCreateObject;
fnPrintChat oPrintChat;

void PrintChat(const char* Message, int Type = 0)
{
	oPrintChat(CHAT_CLIENT + Processes::GetBaseAddress(), Message, Type);
}

int hkCreateObject(DWORD ptr, DWORD NetworkID)
{
	PrintChat("Create Object");
	cout << "awk";
	return oCreateObject(ptr, NetworkID);
}

void WINAPI HookCreateObject()
{
	oPrintChat = (fnPrintChat)(FN_PRINT_CHAT + Processes::GetBaseAddress());

	//PrintChat("Hooking CreateObject.");
	std::shared_ptr<PLH::X86Detour> DetourEx(new PLH::X86Detour);
	DetourEx->SetupHook((BYTE*)(Processes::GetBaseAddress() + FN_CREATE_OBJECT), (BYTE*)hkCreateObject);
	DetourEx->Hook();
	oCreateObject = DetourEx->GetOriginal<fnCreateObject>();
}

void Test(const char* Message, int Type)
{
	cout << "ffff\n";
}

void Hook()
{
	HookCreateObject();
}

int main()
{
	cout << "Welcome to Unsigned Engine!\n";
	bool isLeagueOpen = Processes::tryToFindLeagueClient();
	if(!isLeagueOpen)
		cout << "Waiting for League Client to Load\n";

	while (!isLeagueOpen)
		isLeagueOpen = Processes::tryToFindLeagueClient();


	while (!close)
	{
		Sleep(200);
		DWORD procID;
		GetWindowThreadProcessId(Processes::LeagueWindow(), &procID);
		HANDLE handle = OpenProcess(PROCESS_ALL_ACCESS, 0, procID);


		if (procID == NULL)
		{
			cout << "Failed";
			Sleep(2000);
		}
		else
		{
			//if (LeagueValues::isPreGame())
			{
				printf("Base Address: %x\n", Processes::GetBaseAddress());
				TryInject();
				Debug();
				//Hook();
				//	WriteProcessMemory(handle, (LPVOID)(playerBase + offset1), &newAmmo, sizeof(newAmmo), 0);
				cout << "End of usage\n\n";
				Sleep(1000000);
				close = true;
			}
		}
	}
}