#include <cstdio>
#include <cstdlib>
#include <ctime>
#include <sys/timeb.h>


int Fib2(int n)
{
	int current = 1;
	int next = 1;
	while (1)
	{
		if (n < 2)
			return current;
		else
		{
			n = --n;
			const auto old_current = current;
			current = next;
			next = old_current + next;
		}
	}
}
int main()
{
	Fib2(40);
	return 0;
}