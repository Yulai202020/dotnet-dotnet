#include <iostream>
#include <thread>
#include <chrono>
using namespace std;
void dor(int &q){
    for (int i = 0; i < 10; i++) {
        q += 5;
        cout << "DOR ## ID = " << this_thread::get_id() << endl;
        this_thread::sleep_for(chrono::milliseconds(1000));
    }
}
int main(){
    int q = 5;
    thread th(dor,q);
    for (int i = 0; i < 10; i++) {
        cout << "MAIN ## ID = " << this_thread::get_id() << endl;
        this_thread::sleep_for(chrono::milliseconds(1000));
    }
    th.join();
}