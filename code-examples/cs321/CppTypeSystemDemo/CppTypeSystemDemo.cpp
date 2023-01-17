#include <iostream>

int main()
{
    char* text = new char[13] { "Hello World!" };
    std::cout << text << std::endl;
    int* ptr = (int*)(text);
    ptr[2] = 98;
    std::cout << text << std::endl;
}
