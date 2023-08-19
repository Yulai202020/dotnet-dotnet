#include <iostream>
#include <thread>
#include <chrono>
using namespace std;
void dor(){
    for (int i = 0; i < 10; i++) {
        cout << "ID = " << this_thread::get_id() << endl;
        this_thread::sleep_for(chrono::milliseconds(1000));
    }
}
int main(){
    thread th(dor);
    th.detach();
    for (int i = 0; i < 10; i++) {
        cout << "ID = " << this_thread::get_id() << endl;
        this_thread::sleep_for(chrono::milliseconds(1000));
    }
    return 1;
}