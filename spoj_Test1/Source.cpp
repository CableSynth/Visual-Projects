//Author: Loren Baum
//Purpose: To recieve and output to the screen
//Date: 5/21/2016 - created

#include <iostream>

using namespace std;

int main() {
	int input = 0;
	while (input != 42) {
		cin >> input;
		if (input != 42) {
			cout << input << endl;
		}
	}
	return 0;
}