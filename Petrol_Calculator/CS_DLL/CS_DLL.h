#pragma once
#ifndef __CS_DLL_H__
#define __CS_DLL_H__

#define CSOUT __declspec(dllexport)
#define SCALL __stdcall

extern "C" {
	CSOUT const char* SCALL getStr(const char* prompt, bool newLine);
}

#endif