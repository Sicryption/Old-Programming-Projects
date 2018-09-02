#pragma once
#include "stdafx.h"
#include "Processes.h"
#include <string>
#include <windows.h>

using namespace std;

bool close = false;

bool TryInject()
{
	HWND window = ::FindWindowA(0, (LPCSTR)("HookTestProject"));

	if (window == 0) {
		printf("Not Injected\n");
		return false;
	}

	printf("Injecting\n");

	//load information

	//load scripts
}

int main()
{
	cout << "Started HookTesting!\n";
	bool isProcessOpen = Processes::tryToFindProcess();
	if(!isProcessOpen)
		cout << "Waiting for Process to Load\n";

	while (!isProcessOpen)
		isProcessOpen = Processes::tryToFindProcess();


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
				//Hook();
				//	WriteProcessMemory(handle, (LPVOID)(playerBase + offset1), &newAmmo, sizeof(newAmmo), 0);
				cout << "End of usage\n\n";
				Sleep(1000000);
				close = true;
			}
		}
	}
}