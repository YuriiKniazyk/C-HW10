using System;

namespace DelegateEvent
{
    public class Parent
    {
        public void OnMarkChange(int marks)
        {
            Console.WriteLine($"A new mark in your child: {marks}");
        }
    }
}