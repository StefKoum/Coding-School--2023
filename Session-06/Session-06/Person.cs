﻿using System;

public class Person
{
    //Properties
	public Guid ID { get; set; }
	public string? Name { get; set; }
	public int Age { get; set; }

    //Constructors
    public Person()
    { 
    }

    public Person(Guid id)
    {
        ID = id;
    }

    public Person(Guid id, string name)
    {
        ID = id;
        Name = name;
    }
    public Person(Guid id, string name, int age)
    {
        ID = id;
        Name = name;
        Age = age;
    }

    //Methods
    public void GetName()
    {
    }

    public void SetName(string name)
    {
    }

}
