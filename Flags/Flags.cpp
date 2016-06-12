#include <iostream>
#include <string>

using namespace std;

int main() {
	int numOfTests = 0;
	cin >> numOfTests;
	for (int i = 0; i < numOfTests; ++i) {
		int numOfLevels = 0;
		cin >> numOfLevels;
		int *arrOfFlags = new int[numOfLevels];
		int *arrOfPrb = new int[numOfLevels];
		int sumOfFlags = 0;
		for (int i = 0; i < numOfLevels; ++i) {
			cin >> arrOfFlags[i];
			sumOfFlags += arrOfFlags[i];
		}
	}
}