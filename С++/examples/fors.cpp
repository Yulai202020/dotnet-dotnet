using namespace std;
#include <stdlib.h>
#include <stdio.h>
#include <string>
#include <iostream>
int main() {
    printf("for");
    for (int i = 0; i < 4; i++ ){
       std::cout << i;
    }
    printf("while");
    int i = 0;
    while (i < 4){
        cout << i++;
    }
    printf("do while");
    int a = 0;
    do {
        cout << a++;
    } while (a < 4);
    
}
