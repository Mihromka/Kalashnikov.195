#include <iostream>

double divide(int, int);

int main()
{
	std::cout << "Enter the first number";
	double num1;
	std::cin >> num1;

	std::cout << "Enter the second number";
	double num2;
	std::cin >> num2;
	try
	{
	  double res = divide(num1, num2);
		std::cout << res << std::endl;
	}
	catch (const std::exception& err)
	{
		std::cout << "Error!!!" << std::endl;
	}
	std::cout << "The End..." << std::endl;
	return 0;
}

double divide(int num1, int num2)
{
	if (num2 == 0)
		throw std::exception();
	return num1 / num2;
}
