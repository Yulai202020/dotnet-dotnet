using namespace std;
#include <iostream>
#include <fstream>
int main() {
    ofstream myfile;
    char str[80];
    myfile.open("read.txt");
    myfile << "Writing this to a file.\n";
    myfile.close();
    return 0;
}