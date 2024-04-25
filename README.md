# Zoo Management System - By Dewald Breed

## About

This is a WinForms app written in C# for a school project. Its primary purpose is to manage a Zoo's animals records in a simple and user-friendly manner. In its current state it offers the following functionality:

- Add animals to the Zoo record by selecting a species (Currently only has 3 species)
and providing the animal's name, age, sex, and location (Pen 1-4).
- View all recorded animal's details in an easy-to-use interface.
- Interact with each animal through buttons, with the result being displayed in an action log.

## Objectives

### Task 1: Class Hierarchy and Inheritance
- This project uses an Animal base class with common animal properties and two methods (`Eat`, `Sleep`).

### Task 2: Polymorphism and Method Overriding
- This project implements method overriding in the derived classes by altering the output of the `Eat()` method for each derived class.

### Task 3: Methods and Method Overloading
- This project implements various methods within each derived class, and specifically the `Sleep()` method is overloaded to accept an argument, whereas the base class `Sleep()` method does not.

### Task 4: Implementing Interfaces
- This project implements 3 different interfaces which provide the `Feed()`, `Play()` and `Vocalize()` method. 

# How it works

## Animal classes

The project's functionality is built around a base class `Animals`.
This class contains some basic properties one would associate with an animal (Name, age, sex ect.) and two basic methods, `Eat()` and `Sleep()`.

We then create 3 derived classes, each representing a specific species of animal. 
In this case they are Giraffe, Squirrel Monkey and Wolf. 

Each derived class has a constructor which assigns the inherited properties' values (example of inheritance). They all override the `Eat()` method to return a more unique string specific to the species (example of polymorphism), and they all overload the `Sleep()` method to accept an argument which is used to alter the returned string.

Each derived class also makes use of interfaces to add additional methods, namely `Feed()`, `Vocalize()` and `Play()`. For demonstrative purposes, only the Wolf and Squirrel Monkey derived classes implement all 3 interfaces, while Giraffe only implements `Feed()`.

## GUI

To demonstrate all the various methods in action, a GUI is added to easily create and interact with new instances of the derived class animals. By using the various `Action` buttons in the `View All Animals` tab, one can see all the methods in action as their returned strings are displayed in the Action Log.

This is done by storing new animal instances in a list once they are created. Then, depending on which animal is selected for viewing/interaction, we find that specific animal in their list, and invoke the desired method via buttons.

# Shortfalls

I realize that ideally one would store all derived class instances in a generic list of `Animal` objects, however, I was unable to figure out how to invoke interface provided methods for a specific animal when accessing it inside a list of Animals. Because of this, I opted to rather use three separate lists, one for each derived class. 


