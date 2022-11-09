// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <iostream>

BOOL APIENTRY DllMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved) {
    switch (ul_reason_for_call) {
    case DLL_PROCESS_ATTACH: 
#ifdef _DEBUG 
        std::cout << "PROC ATCH" << std::endl; break; 
#endif
    case DLL_THREAD_ATTACH: 
#ifdef _DEBUG
        std::cout << "THRD ATCH" << std::endl; break;
#endif
    case DLL_THREAD_DETACH: 
#ifdef _DEBUG
        std::cout << "THRD DTCH" << std::endl; break;
#endif
    case DLL_PROCESS_DETACH: 
#ifdef _DEBUG
        std::cout << "PROC DTCH" << std::endl; break;
#endif
    }
    return TRUE;
}

#define dllout __declspec(dllexport)
#define callcon __stdcall

extern "C" {
    dllout void callcon Clear() {
        system("cls");
    }
}