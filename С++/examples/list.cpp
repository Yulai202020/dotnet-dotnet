#include <iostream>
using namespace std;
template<typename T>
class list
{
private:
    template<typename T0>
    class node
    {
    public:
        node *pNext;
        T0 data;
        node (T0 data=T0(),node *pNext=nullptr){
            this->data = data;
            this->pNext = pNext;
        }
    };
    int Size;
    node<T> *head;
public:
    T& operator[](const int index);
    int GetSize(){return Size;};

    void push_front(T data);
    void push_back(T data);

    void removeAt(int id);
    void pop_front();
    void pop_back(){removeAt(Size-1);}

    void insert(T val , int id);
    void clear();

    list();
    ~list();
};

template<typename T>
list<T>::list() {
    Size = 0;
    head = nullptr;
}

template<typename T>
list<T>::~list(){ clear(); }

template<typename T>
T & list<T>::operator[](const int index){
    int counter = 0;
    node<T> *curr = this->head;
    while (curr != nullptr) {
        if (counter == index)
            return curr->data;
        curr = curr->pNext;
        counter++;
    }
}

template<typename T>
void list<T>::pop_front() {
    node<T> tmp = head;
    head = head->pNext;
    delete tmp;
    Size--;
}

template<typename T>
void list<T>::push_front(T data) {
    head = new node<T>(data,head);
    Size++;
}

template<typename T>
void list<T>::removeAt(int id) {
    if (id == 0)
        pop_front();
    else {
        node<T> *perv = this->head;
        for (int i = 0; i < id-1; i++)
            perv = perv->pNext;
        node<T> *deleter = perv->pNext;
        perv->pNext = deleter->pNext;
        delete deleter;
        Size--;
    }
}

template<typename T>
void list<T>::insert(T val,int id) {
    if (id == 0)
        push_front(val);
    else {
        node<T> *perv = this->head;
        for (int i = 0; i < id-1; i++)
            perv = perv->pNext;
        node<T> *newnode = new node<T>(val,perv->pNext);
        perv->pNext = newnode;
        Size++;
    }
}

template<typename T>
void list<T>::clear() {
    while (Size) {pop_front();}
}

template<typename T>
void list<T>::push_back(T data) {
    if (head == nullptr)
        head = new node<T>(data);
    else {
        node<T> *curr = this->head;
        while (curr->pNext!=nullptr)
            curr = curr->pNext;
        curr->pNext = new node<T>(data);
    }
    Size++;
}

int main(){
    list<int> lst;
    lst.push_back(123);
    lst.push_back(12);
    cout << lst[0] << endl;
    return 0;
}