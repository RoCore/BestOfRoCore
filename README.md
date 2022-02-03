# Intro

I have experienced a lot of things that can be good and whatnot. It's time to share it with you all ;)

# Automapper vs Custom Mapper

Automapper (no matter what kind of) is a great thing if you have CRUD API. The maintenance is linear, and it will save a lot of time. Should we really use automapping all the time? The best practice is to analyze your application.

Let's start with:

1. Properties
   1. Computed properties
   2. Matching names
   3. Read or write only
2. Constructors
   1. Empty or parametrized .ctr
   2. Private or public
   3. Class generators


## Generics hell

To reduce the code, we using generics. But what happens if we have a method with generic parameters. We will not be able to follow the code. We reduced so much that the code became unreadable. To reduce this complexity, the best way is to create separate method for each generic in the class/interface.


