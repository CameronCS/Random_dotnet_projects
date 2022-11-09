#include "pch.h"
#include "CS_DLL.h"

#include <iostream>
#include <string>
#include <limits>

extern "C" {
	const char* SCALL getStr(const char* prompt, bool newLine) {
		if (prompt != NULL) { std::cout << prompt; }
		if (newLine == true) { std::cout << std::endl; }
		std::string user_input;
		std::getline(std::cin, user_input, '\n');
		return user_input.c_str();
	}
}