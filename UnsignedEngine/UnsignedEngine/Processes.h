#pragma once
#include "stdafx.h"
#include <windows.h>
#include <TlHelp32.h> 
#include <iostream> 
#include <tlhelp32.h> 
#include <string>

using namespace std;

#pragma once
class Processes
{
public:
	Processes();
	~Processes();

	static HWND LeagueWindow()
	{
		return FindWindowA(NULL, "League of Legends (TM) Client");
	}

	static DWORD FindProcessId(const wstring& processName)
	{
		PROCESSENTRY32 processInfo;
		processInfo.dwSize = sizeof(processInfo);

		HANDLE processesSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);
		if (processesSnapshot == INVALID_HANDLE_VALUE)
			return 0;

		Process32First(processesSnapshot, &processInfo);
		if (!processName.compare(processInfo.szExeFile))
		{
			CloseHandle(processesSnapshot);
			return processInfo.th32ProcessID;
		}

		while (Process32Next(processesSnapshot, &processInfo))
		{
			if (!processName.compare(processInfo.szExeFile))
			{
				CloseHandle(processesSnapshot);
				return processInfo.th32ProcessID;
			}
		}

		CloseHandle(processesSnapshot);
		return 0;
	}

	//Get process ids/handles/modules functions 
	static HANDLE GetProcessHandle(wchar_t *ProcessName, ULONG *ReturnedProcessId)
	{
		PROCESSENTRY32W *pe = new PROCESSENTRY32W;
		HANDLE Snap;

		pe->dwSize = sizeof(PROCESSENTRY32W);
		Snap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);

		if (Snap == INVALID_HANDLE_VALUE)
		{
			delete pe;
			return 0;
		}

		BOOL bProcess = Process32FirstW(Snap, pe);
		while (bProcess)
		{
			if (_wcsicmp(pe->szExeFile, ProcessName) == 0)
			{
				HANDLE ProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, 0, pe->th32ProcessID);

				if (ReturnedProcessId)
					*ReturnedProcessId = pe->th32ProcessID;

				CloseHandle(Snap);
				delete pe;
				return ProcessHandle;
			}

			bProcess = Process32NextW(Snap, pe);
		}

		CloseHandle(Snap);
		delete pe;
		return 0;
	}

	static ULONG GetModuleBase(wchar_t *ModuleName, ULONG ProcessId)
	{
		MODULEENTRY32W *me = new MODULEENTRY32W;

		HANDLE Snap = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, ProcessId);

		me->dwSize = sizeof(MODULEENTRY32W);
		if (Snap == INVALID_HANDLE_VALUE)
		{
			delete me;
			return 0;
		}

		BOOL bModule = Module32First(Snap, me);
		while (bModule)
		{
			if (!ModuleName || _wcsicmp(me->szModule, ModuleName) == 0)
			{
				CloseHandle(Snap);
				return (ULONG)me->modBaseAddr;
			}

			bModule = Module32Next(Snap, me);
		}

		CloseHandle(Snap);
		delete me;
		return 0;
	}

	static string ReadString(DWORD Offset, bool direct = false)
	{
		char buffer[256];
		//not sure about anything beneath this
		DWORD ProcessID = FindProcessId(L"League of Legends.exe");
		HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, 0, ProcessID);
		ULONG baseAddr = GetModuleBase(0, ProcessID);
		DWORD offset = (direct) ? Offset : baseAddr + Offset;

		ReadProcessMemory(hProcess, (LPCVOID)(offset), &buffer, sizeof(buffer), 0);
		return string(buffer);
	}

	static int ReadInt(DWORD Offset, bool direct = false)
	{
		int buffer;
		//not sure about anything beneath this
		DWORD ProcessID = FindProcessId(L"League of Legends.exe");
		HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, 0, ProcessID);
		ULONG baseAddr = GetModuleBase(0, ProcessID);

		DWORD offset = (direct) ? Offset : baseAddr + Offset;

		ReadProcessMemory(hProcess, (LPCVOID)(offset), &buffer, sizeof(buffer), 0);
		return buffer;
	}

	static float ReadFloat(DWORD Offset, bool direct = false)
	{
		float buffer;
		//not sure about anything beneath this
		DWORD ProcessID = FindProcessId(L"League of Legends.exe");
		HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, 0, ProcessID);
		ULONG baseAddr = GetModuleBase(0, ProcessID);

		DWORD offset = (direct) ? Offset : baseAddr + Offset;

		ReadProcessMemory(hProcess, (LPCVOID)(offset), &buffer, sizeof(buffer), 0);
		return buffer;
	}

	static DWORD ReadDWORD(DWORD Offset, bool direct = false)
	{
		DWORD buffer;
		//not sure about anything beneath this
		DWORD ProcessID = FindProcessId(L"League of Legends.exe");
		HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, 0, ProcessID);
		ULONG baseAddr = GetModuleBase(0, ProcessID);

		DWORD offset = (direct) ? Offset : baseAddr + Offset;

		ReadProcessMemory(hProcess, (LPCVOID)(offset), &buffer, sizeof(buffer), 0);
		return buffer;
	}

	static ULONG GetBaseAddress()
	{
		DWORD buffer;
		//not sure about anything beneath this
		DWORD ProcessID = FindProcessId(L"League of Legends.exe");
		HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, 0, ProcessID);
		ULONG baseAddr = GetModuleBase(0, ProcessID);

		return baseAddr;
	}

	static bool tryToFindLeagueClient()
	{
		if (LeagueWindow == NULL)
			return false;
		cout << "League is open!\n";
		return true;
	}
};

