#include <stdio.h>
#include "TestClass.h"


char* GetMemory()
{
	//char buf[] = "hello world";
	
	char buf[] = "Hello world";

	return buf;
}


int main()
{
	char* str = GetMemory();

	//str = "hi world";
	printf(str);


	TestClass * testClass = new TestClass();
	testClass->TestMethod();
	//testClass->
	//print something

	delete(testClass);



	return 0;
}