
using System.Collections;
using System.Collections.Generic;
using System;
class HelloWorld {
  static void Main() {
    Ob x = new Ob();
    x.add_Stack("sgv");
    x.remove_Stack();
    Console.WriteLine(x.count_Stack());
  }
}
class Ob{
    ArrayList arrayList = new ArrayList();
    List<object> list = new List<object>();
    Stack<object> stack = new Stack<object>();
    Queue<object> queue = new Queue<object>();
    
    public void add_arrayList(object x){
        arrayList.Add(x);
    }
    public void remove_arrayList(object x){
        arrayList.Remove(x);
    }
    public object return_arrayList(int x){
        return arrayList[x - 1];
    }
    public object count_arrayList(){
        return arrayList.Count;
    }
    
    public void add_List(object x){
        list.Add(x);
    }
    public void remove_List(object x){
        list.Remove(x);
    }
    public object return_List(int x){
        return list[x - 1];
    }
    public object count_List(){
        return list.Count;
    }
    
    public void add_Stack(object x){
        stack.Push(x);
    }
    public object remove_Stack(){
        return stack.Pop();
    }
    public object return_Stack(){
        return stack.Peek();
    }
    public object count_Stack(){
        return stack.Count;
    }
    
    public void add_Queue(object x){
        queue.Enqueue(x);
    }
    public object remove_Queue(){
        return queue.Dequeue();
    }
    public object return_Queue(int x){
        return stack.Peek();
    }
    public object count_Queue(){
        return queue.Count;
    }
    
    
}
